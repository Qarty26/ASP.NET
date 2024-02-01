import { Generic } from './Generic'

export class User extends Generic {
    protected routeName: string = "User";
}

export interface IUser {
    id: string,
    userName: string,
    email: string,
    experience : number
}