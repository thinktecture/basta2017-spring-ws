import {NgModule} from '@angular/core';
import {Routes, RouterModule} from '@angular/router';
import {ALL_SERVICES} from '../services/all';
import {SessionsListComponent} from '../components/sessions/list';
import {SessionsCreateComponent} from '../components/sessions/create';

const routes: Routes = [
    {
        path: '',
        component: SessionsListComponent
    },
    {
        path: 'add',
        component: SessionsCreateComponent
    },
    {
        path: '**',
        redirectTo: ''
    }
];

@NgModule({
    imports: [RouterModule.forRoot(routes, { useHash: true})],
    exports: [RouterModule],
    providers: [ALL_SERVICES]
})
export class AppRoutingModule {
}
