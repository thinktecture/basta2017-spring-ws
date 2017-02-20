import {BaseSessionsService} from '../sessionsService';

export class FakeSessionsService extends BaseSessionsService {

    public getSessions(): Array<any> {
        return [{ title: 'Angular Session'}];
    }

}
