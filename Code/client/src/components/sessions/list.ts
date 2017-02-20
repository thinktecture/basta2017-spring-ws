import {Component, OnInit} from '@angular/core';
import {SessionsService} from '../../services/sessionsService';
import {Session} from '../../models/session';

@Component({
    selector: 'basta-sessions-list',
    templateUrl: 'list.html'
})
export class SessionsListComponent implements OnInit  {

    public sessions: Array<Session> = [];

    constructor(private _sessionsService: SessionsService) {

    }

    public ngOnInit(): void {
        this._sessionsService.getSessions()
            .subscribe(
                (allSessions) => this.sessions = allSessions
            );
    }


}
