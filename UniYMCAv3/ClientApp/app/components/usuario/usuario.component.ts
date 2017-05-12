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

export interface user {
    nombre;
    paterno;
    materno;
    usuarioid;
}

@Component({
    selector: 'usuario-app',
    templateUrl: './usuario.component.html',
    styleUrls: ['../app/css/custom.css', '../app/css/layout.css', '../app/css/themes/default.css']
})

export class UsuarioComponent {
    listaus: user[];

    constructor(private http: Http) {
        this.GetUsuarios();
    }

    GetUsuarios() {
        this.http.get('api/usuario/')
            .subscribe(res => this.listaus = res.json() as user[]);
        
    }
}