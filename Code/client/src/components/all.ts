import {AppComponent} from './app/app.component';
import {NavigationComponent} from './navigation/navigation';
import {SessionsListComponent} from './sessions/list';
import {SessionsCreateComponent} from './sessions/create';

export const ALL_COMPONENTS: Array<any> = [
    AppComponent,
    SessionsListComponent,
    SessionsCreateComponent,
    NavigationComponent
];

export const BOOTSTRAP_COMPONENT: any = AppComponent;
