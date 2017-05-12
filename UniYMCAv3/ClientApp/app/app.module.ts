import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { UniversalModule } from 'angular2-universal';
import { FormsModule } from '@angular/forms';

import { AppComponent } from './components/app/app.component'
import { NavMenuComponent } from './components/navmenu/navmenu.component';
import { HomeComponent } from './components/home/home.component';
import { FetchDataComponent } from './components/fetchdata/fetchdata.component';
import { CounterComponent } from './components/counter/counter.component';
import { AlumnoComponent } from './components/alumno/alumno.component';
import { MenuTop } from './components/pagetop/pagetop.component';
import { UsuarioComponent } from './components/usuario/usuario.component';

import { PrimeComponent } from './components/prime/prime.component';
import {
    ButtonModule,
    GrowlModule,
    DataTableModule,
    SharedModule,
    DropdownModule
} from 'primeng/primeng';

@NgModule({
    bootstrap: [AppComponent],
    declarations: [
        AppComponent,
        NavMenuComponent,
        CounterComponent,
        FetchDataComponent,
        HomeComponent,
        PrimeComponent,
        AlumnoComponent,
        MenuTop,
        UsuarioComponent
    ],
    imports: [
        UniversalModule, // Must be first import. This automatically imports BrowserModule, HttpModule, and JsonpModule too.
        RouterModule.forRoot([
            { path: '', redirectTo: 'home', pathMatch: 'full' },
            { path: 'home', component: HomeComponent },
            { path: 'counter', component: CounterComponent },
            { path: 'prime', component: PrimeComponent },
            { path: 'fetch-data', component: FetchDataComponent },
            { path: 'alumno', component: AlumnoComponent },
            { path: 'usuario', component: UsuarioComponent },
            { path: '**', redirectTo: 'home' }
        ]),
        FormsModule,
        ButtonModule,
        GrowlModule,
        DataTableModule,
        SharedModule,
        DropdownModule
    ]
})
export class AppModule {
}
