import {Component, OnInit} from '@angular/core';
import {FormGroup, FormBuilder} from '@angular/forms';
import {SessionsService} from '../../services/sessionsService';
import {Router} from '@angular/router';

@Component({
    selector: 'basta-session-create',
    templateUrl: 'create.html'
})
export class SessionsCreateComponent implements OnInit {
    public addSession: FormGroup;

    constructor(private _formBuilder: FormBuilder,
                private _sessionsService: SessionsService,
                private _router: Router) {

    }

    public ngOnInit(): void {
        this.addSession = this._formBuilder.group({
            title: '',
            description: ''
        });
    }

    public formSubmit(): void {
        this._sessionsService.createSession(this.addSession.value)
            .subscribe(() => {
                this._router.navigate(['/']);
            });
    }

}
