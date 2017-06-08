
import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { UniversalModule } from 'angular2-universal';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { AppComponent } from './components/app/app.component'
import { NavMenuComponent } from './components/navmenu/navmenu.component';
import { HomeComponent } from './components/home/home.component';
import { AltaDocenteComponent } from './components/Docente/AltaDocente.component';
import { MenuTop } from './components/pagetop/pagetop.component';
import {
    ButtonModule,
    GrowlModule,
    DataTableModule,
    SharedModule,
    DropdownModule,
    StepsModule, TabViewModule, PanelModule, ChipsModule, CalendarModule, CheckboxModule, FileUploadModule
} from 'primeng/primeng';


@NgModule({
    bootstrap: [AppComponent],
    declarations: [
        AppComponent,
        NavMenuComponent,
        HomeComponent,
        AltaDocenteComponent,
        MenuTop,
    ],
    imports: [
        UniversalModule, // Must be first import. This automatically imports BrowserModule, HttpModule, and JsonpModule too.
        RouterModule.forRoot([
            { path: '', redirectTo: 'home', pathMatch: 'full' },
            { path: 'home', component: HomeComponent },
            { path: 'AltaDocente', component: AltaDocenteComponent },
            { path: '**', redirectTo: 'home' }
        ]),
        FormsModule,
        ReactiveFormsModule,
        ButtonModule,
        GrowlModule,
        DataTableModule,
        SharedModule,
        DropdownModule,
        StepsModule,
        TabViewModule,
        PanelModule,
        ChipsModule,
        CalendarModule,
        CheckboxModule,
        FileUploadModule
    ]
})
export class AppModule {
}










