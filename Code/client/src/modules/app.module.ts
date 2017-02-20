import {BrowserModule} from '@angular/platform-browser';
import {NgModule} from '@angular/core';
import {FormsModule} from '@angular/forms';
import {HttpModule} from '@angular/http';
import {AppRoutingModule} from './app-routing.module';
import {ALL_COMPONENTS, BOOTSTRAP_COMPONENT} from '../components/all';
import {ALL_SERVICES} from '../services/all';

@NgModule({
    declarations: [
        ALL_COMPONENTS
    ],
    imports: [
        BrowserModule,
        FormsModule,
        HttpModule,
        AppRoutingModule
    ],
    providers: [ALL_SERVICES],
    bootstrap: [BOOTSTRAP_COMPONENT]
})
export class AppModule {
}
