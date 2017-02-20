import {enableProdMode} from '@angular/core';
import {platformBrowserDynamic} from '@angular/platform-browser-dynamic';
import {environment} from './environments/environment';
import {AppModule} from './modules/app.module';

if (environment.production) {
    enableProdMode();
}

let bootstrapApp = () => {
    platformBrowserDynamic().bootstrapModule(AppModule);
};

if (window.cordova) {
    document.addEventListener('deviceready', bootstrapApp.bind(this), false);
} else {
    bootstrapApp();
}
