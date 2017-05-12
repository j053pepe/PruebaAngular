import { Component, Injectable } from '@angular/core';
import { Http, Headers, Response } from '@angular/http';
import {
    ButtonModule,
    GrowlModule,
    Message,
    DataTableModule,
    SharedModule,
    DropdownModule
} from 'primeng/primeng';
import { Car } from './car'
    
@Component({
    selector: 'alumno-app',
    templateUrl: './alumno.component.html',
    styleUrls: ['../app/css/custom.css', '../app/css/layout.css', '../app/css/themes/default.css']
})

export class AlumnoComponent {
    public Alumnos: string;
    cars: JSON;
    cols: any[];

    constructor(private http: Http) {
        //var creds = "username=" + 'Jose' + "&password=" + 'jose1291';
        let creds = {
            token: '123',
            //objuser: {
                password: 'jose1291',
                username: 'jose',
            //},
            
        };        

        //var headers = new Headers();
        //headers.append('Content-Type', 'application/json');

        //http.post('api/usuario/' + creds.token,
        //    creds,{
        //        headers: headers
        //    })
        //    .subscribe(data => this.saveJwt(data.text()));

        this.getCarsSmall();
    }

    saveJwt(jwt) {
        if (jwt) {
            //localStorage.setItem('id_token', jwt)
            console.log(jwt);
            this.Alumnos = jwt;
        }
    }

    getCarsSmall() {
        this.http.get('api/alumno/')
            .subscribe(res => this.cars = res.json());

        this.cols = [
            { field: 'alumnoId', header: 'AlumnoId' },
            { field: 'nombre', header: 'Nombre' },
            { field: 'fechaRegistro', header: 'Fecha de Registro' },
            { field: 'descripcion', header: 'Ofertas Educativas' },
            { field: 'usuario', header: 'Usuario' }
        ];
    }

}
