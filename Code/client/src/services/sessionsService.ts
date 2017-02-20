import {Http} from '@angular/http';
import {Session} from '../models/session';
import {Observable} from 'rxjs';
import {Injectable} from '@angular/core';
import 'rxjs/add/operator/map';

export abstract class BaseSessionsService {
    public abstract getSessions(): Array<any>;
}

@Injectable()
export class SessionsService {

    private _apiRoot: string = 'https://bastaspring2017api.azurewebsites.net/api/';

    constructor(private _http: Http){

    }


    private _composeUrl(url: string) : string{
        return `${this._apiRoot}${url}`;
    }


    public getSessions(): Observable<Array<Session>> {
        return this._http.get(this._composeUrl('sessions/list'))
            .map(response => response.json());

    }

}
