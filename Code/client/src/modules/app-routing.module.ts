import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import {ALL_SERVICES} from '../services/all';
import {SessionsListComponent} from '../components/sessions/list';

const routes: Routes = [
  {
    path: '',
    component: SessionsListComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
  providers: [ ALL_SERVICES]
})
export class AppRoutingModule { }
