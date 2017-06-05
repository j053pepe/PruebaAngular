
import { Component, Injectable, OnInit, ViewEncapsulation } from '@angular/core';
import { Http, Headers, Response, RequestOptions } from '@angular/http';
import { Validators, FormControl, FormGroup, FormBuilder } from '@angular/forms';

import {
    MenuModule,
    MenuItem,
    Message,
    ButtonModule,
    SelectItem
} from 'primeng/primeng';

@Component({
    selector: 'altadocente-app',
    templateUrl: './AltaDocente.component.html',
    // styleUrls: ['../app/css/custom.css', '../app/css/layout.css', '../app/css/themes/default.css'],
    styles: [`
        .ui-steps .ui-steps-item {
            width: 25%;
        }
        
        .ui-steps.steps-custom {
            margin-bottom: 30px;
        }
         
        .ui-steps.steps-custom .ui-steps-item .ui-menuitem-link {
            height: 10px;
            padding: 0 1em;
        }
         
        .ui-steps.steps-custom .ui-steps-item .ui-steps-number {
            background-color: #0081c2;
            color: #FFFFFF;
            display: inline-block;
            width: 36px;
            border-radius: 50%;
            margin-top: -14px;
            margin-bottom: 10px;
        }
        
        .ui-steps.steps-custom .ui-steps-item .ui-steps-title {
            color: #555555;
        }
         .ui-widget-content {
         border: 0px solid !important;
        }

    `],
    encapsulation: ViewEncapsulation.None
})

export class AltaDocenteComponent implements OnInit {
    //tab/
    private items: MenuItem[];
    activeIndex: number = 0;
    tab1: boolean = true;
    tab2: boolean = false;
    tab3: boolean = false;

    //catalogos//
    public catalogos;
    public nacimientoLugar;
    public genero;
    public estadocivil;
    public estado;
    public municipio;
    public estadof;
    public municipiof;
    nacional: SelectItem[];
    //valores inicales catalogos//
    slcNacionalidad: string = '1';
    slcLugarNacimineto: string = '9';
    sclEstado: string ='9' ;
    sclEstadoF: string = '9' ;
    //formulario//
    validar: boolean = false;
    checked: boolean = false;
    es: any;
    msgs: Message[] = [];
    tab1form: FormGroup;
    tab2form: FormGroup;
    tab3form: FormGroup;
    submitted: boolean;
    description: string;

    constructor(private http: Http, private  fb: FormBuilder) { }



    ngOnInit() {

        //Wizard//
        this.items = [
            {
            label: 'Personales',
            command: (event: any) => {
                this.activeIndex = 0;
            }
        },
        {
            label: 'Datos Fiscales',
            command: (event: any) => {
                this.activeIndex = 1;
            }
        },
        {
            label: 'Formacion Profecional',
            command: (event: any) => {
                this.activeIndex = 2;
            }
        },
        {
            label: 'Fin',
            command: (event: any) => {
                this.activeIndex = 3;
            }
        }
        ];

        //formato calendario//
        this.es = {
            firstDayOfWeek: 1,
            dayNames: ["Domingo", "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado"],
            dayNamesShort: ["dom", "lun", "mar", "mié", "jue", "vie", "sáb"],
            dayNamesMin: ["D", "L", "M", "X", "J", "V", "S"],
            monthNames: ["Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"],
            monthNamesShort: ["ene", "feb", "mar", "abr", "may", "jun", "jul", "ago", "sep", "oct", "nov", "dic"]
        }
        //formulario//
        this.tab1form = this.fb.group({
            'nombre': new FormControl('', Validators.compose([Validators.required, Validators.minLength(3)])),
            'paterno': new FormControl('', Validators.compose([Validators.required, Validators.minLength(3)])),
            'materno': new FormControl('', Validators.compose([Validators.required, Validators.minLength(3)])),
            'nacimiento': new FormControl('', Validators.required),
            'nacionalidad': new FormControl('', Validators.required),
            'lugarnacimiento': new FormControl('', Validators.required),
            'curp': new FormControl('', Validators.compose([Validators.required, Validators.minLength(18), Validators.maxLength(18)])),
            'nss': new FormControl('', Validators.compose([Validators.required, Validators.minLength(11), Validators.maxLength(11)])),
            'genero': new FormControl('', Validators.required),
            'estadocivil': new FormControl('', Validators.required),
            'calle': new FormControl('', Validators.compose([Validators.required, Validators.minLength(3)])),
            'exterior': new FormControl('', Validators.required),
            'interior': new FormControl(''),
            'cp': new FormControl('', Validators.compose([Validators.required,Validators.minLength(5), Validators.maxLength(5)])),
            'colonia': new FormControl('', Validators.compose([Validators.required, Validators.minLength(3)])),
            'estado': new FormControl('', Validators.required),
            'municipio': new FormControl('', Validators.required),
            'celular': new FormControl('', Validators.compose([Validators.required, Validators.minLength(3)])),
            'telcasa': new FormControl('', Validators.compose([Validators.required, Validators.minLength(3)])),
            'teloficina': new FormControl('', Validators.compose([Validators.required, Validators.minLength(3)])),
            'email': new FormControl('', Validators.required)
            
        });

        this.tab2form = this.fb.group({
            'rfc': new FormControl('', Validators.compose([Validators.required, Validators.minLength(12), Validators.maxLength(13)])),
            'razon': new FormControl('', Validators.compose([Validators.required, Validators.minLength(3)])),
            'emailf': new FormControl('', Validators.required),
            'checked': new FormControl(''),
            'callef': new FormControl('', Validators.compose([Validators.required, Validators.minLength(3)])),
            'exteriorf': new FormControl('', Validators.required),
            'interiorf': new FormControl(''),
            'cpf': new FormControl('', Validators.compose([Validators.required, Validators.minLength(5), Validators.maxLength(5)])),
            'coloniaf': new FormControl('', Validators.compose([Validators.required, Validators.minLength(3)])),
            'estadof': new FormControl('', Validators.required),
            'municipiof': new FormControl('', Validators.required) 

        });
        this.tab3form = this.fb.group({
          

        });
        this.CargarCatalogos();
    }

    onSubmit(value: string) {
        this.submitted = true;
        this.msgs = [];
        this.msgs.push({ severity: 'info', summary: 'Success', detail: 'Form Submitted' });
    }

    get diagnostic() { return JSON.stringify(this.tab1form.value); }

    CargarCatalogos() {

        //nacionalidad//
        this.nacional = [];
        this.nacional.push({ label: '--Seleccionar--', value: '' });
        this.nacional.push({ label: 'Mexicana ', value: '1' });
        this.nacional.push({ label: 'Extranjera ', value: '2' });
       
        this.http.get('/api/Catalogos/altadocente').subscribe(result => {
            this.catalogos = result.json();
            //Lugar Nacimiento
            this.nacimientoLugar = this.catalogos.entidades;
            //Genero//
            this.genero = this.catalogos.generos;
            //Estado Civil
            this.estadocivil=this.catalogos.estadosCiviles;
            //Estado//
            this.estado = this.catalogos.entidades;
            this.ChangeEstado();
            this.estadof = this.catalogos.entidades;
            //Municipio  Delegacion//
            this.municipio = this.catalogos.entidades;
            this.municipiof = this.catalogos.entidades;
        });

     
    }

    ChangeNacionalidad()
    {
        if (this.slcNacionalidad == "1") {
            this.nacimientoLugar = this.catalogos.entidades;
        } else if (this.slcNacionalidad == "2")
        {
            this.nacimientoLugar = this.catalogos.paises;
        } else {
            this.nacimientoLugar = [{ label: '--Seleccionar--', value: ''}];
        }
    }

    ChangeEstado() {
        
        if (this.sclEstado != "") {
            this.http.get('/api/Catalogos/municipio/' + this.sclEstado).subscribe(result => {
                this.municipio = result.json();
            });
        } else
        {
            this.municipio = [{ label: '--Seleccionar--', value: '' }];
        }
        
    }

    Siguente() {
       
        if (this.activeIndex < 3)
        {
            if (this.activeIndex == 0)
            {
                if (!this.tab1form.valid)
                {
                    this.validar = true;
                    return false;
                }
            } else if (this.activeIndex == 1) {
                if (!this.tab2form.valid) {
                    this.validar = true;
                    return false;
                }
            }

            this.validar = false;
            this.activeIndex = this.activeIndex + 1;
            this.activarTabs();
        }// if (this.activeIndex < 4)
    }

    Atras() {
        if (this.activeIndex > 0)
        {
            this.activeIndex = this.activeIndex - 1;
            this.activarTabs();
        }
        
    }

    MismaDireccion()
    {
        if (this.checked == true)
        {
            this.tab2form.reset(
                {
                    checked: true,
                    callef: this.tab1form.get('calle').value,
                    exteriorf: this.tab1form.get('exterior').value,
                    interiorf: this.tab1form.get('interior').value,
                    cpf: this.tab1form.get('cp').value,
                    coloniaf: this.tab1form.get('colonia').value,
                    estadof: this.tab1form.get('estado').value,
                    municipiof: this.tab1form.get('municipio').value,
                }); 
            
        } else
        {
            this.tab2form.reset(
                {
                    callef: '',
                    exteriorf: '',
                    interiorf: '',
                    cpf: '',
                    coloniaf: '',
                    estadof: '',
                    municipiof: ''
                });
        }
    }

    activarTabs() {
        if (this.activeIndex == 0)
        {
            this.tab1 = true;  
            this.tab2 = false;
            this.tab3 = false;
        } else if (this.activeIndex == 1) {
            this.tab1 = false;
            this.tab2 = true;
            this.tab3 = false;
        }
        else if (this.activeIndex == 2) {
            this.tab1 = false;
            this.tab2 = false;
            this.tab3 = true;
        }
    }

    //valida correo electronico//
   emailValidator(control) {
        // RFC 2822 compliant regex
        if (control.value.match(/[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?/)) {
            return null;
        } else {
            return { 'invalidEmailAddress': true };
        }
    }

}

