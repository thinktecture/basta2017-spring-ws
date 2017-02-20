import {AppComponent} from './app/app.component';
import {NavigationComponent} from './navigation/navigation';
import {SessionsListComponent} from './sessions/list';

export const ALL_COMPONENTS: Array<any> = [
    AppComponent,
    SessionsListComponent,
    NavigationComponent
];

export const BOOTSTRAP_COMPONENT: any = AppComponent;
