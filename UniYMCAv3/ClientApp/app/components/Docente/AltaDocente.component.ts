
import { Component, Injectable, OnInit, ViewEncapsulation } from '@angular/core';
import { Http, Headers, Response } from '@angular/http';
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
    private items: MenuItem[];
    activeIndex: number = 0;
    tab1: boolean = true;
    tab2: boolean = false;
    checked: boolean = false;
    es: any;

    msgs: Message[] = [];
    userform:FormGroup;
    submitted: boolean;
    nacional: SelectItem[];
    description: string;

    constructor(private fb: FormBuilder) { }



    ngOnInit() {

        //Wizard//
        this.items = [{
            label: 'Personales',
            command: (event: any) => {
                this.activeIndex = 0;
            }
        },
        {
            label: 'Contacto',
            command: (event: any) => {
                this.activeIndex = 1;
            }
        },
        {
            label: 'Payment',
            command: (event: any) => {
                this.activeIndex = 2;
            }
        },
        {
            label: 'Confirmation',
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
        this.userform = this.fb.group({
            'nombre': new FormControl('', Validators.compose([Validators.required, Validators.minLength(3)])),
            'paterno': new FormControl('', Validators.compose([Validators.required, Validators.minLength(3)])),
            'materno': new FormControl('', Validators.compose([Validators.required, Validators.minLength(3)])),
            'nacimiento': new FormControl('', Validators.required),
            'nacionalidad': new FormControl('', Validators.required),
            'lugarnacimiento': new FormControl('', Validators.required),
            'curp': new FormControl('', Validators.compose([Validators.required, Validators.minLength(18), Validators.maxLength(18)])),
            'rfc': new FormControl('', Validators.compose([Validators.required, Validators.minLength(12), Validators.maxLength(13)])),
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
            'checked': new FormControl(''),
            'callef': new FormControl('', Validators.compose([Validators.required, Validators.minLength(3)])),
            'exteriorf': new FormControl('', Validators.required),
            'interiorf': new FormControl(''),
            'cpf': new FormControl('', Validators.compose([Validators.required, Validators.minLength(5), Validators.maxLength(5)])),
            'coloniaf': new FormControl('', Validators.compose([Validators.required, Validators.minLength(3)])),
            'estadof': new FormControl('', Validators.required),
            'municipiof': new FormControl('', Validators.required)
            
        });

        this.nacional = [];
        this.nacional.push({ label: '--Seleccionar--', value: '' });
        this.nacional.push({ label: 'Mexicana ', value: '1' });
        this.nacional.push({ label: 'Extranjera ', value: '2' });
        
    }

    onSubmit(value: string) {
        this.submitted = true;
        this.msgs = [];
        this.msgs.push({ severity: 'info', summary: 'Success', detail: 'Form Submitted' });
    }

    get diagnostic() { return JSON.stringify(this.userform.value); }

    Siguente() {
        if (this.activeIndex < 3)
        {
            this.activeIndex = this.activeIndex + 1;
            this.activarTabs();
        }
    }

    Atras() {
        if (this.activeIndex > 0)
        {
            this.activeIndex = this.activeIndex - 1;
            this.activarTabs();
        }
        
    }

    MismaDiceccion()
    {
        if (this.checked == true) {
            alert("hola");
        }
    }

    activarTabs() {
        if (this.activeIndex == 0)
        {
            this.tab1 = true;  
            this.tab2 = false;
        } else if (this.activeIndex == 1) {
            this.tab1 = false;
            this.tab2 = true;
        }
    }



}