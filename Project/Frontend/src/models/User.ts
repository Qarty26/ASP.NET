import { Generic } from './Generic'
import axios from "axios";

export class User extends Generic {
    protected routeName: string = "User"

    public createUser = async (payload : any) => {
        return await axios.post(`${this.routeName}/create`,payload)
            .then((response => response.data))
            .catch((error => {
                console.error(error.response);
                throw error.response.data.title;
            }))
    }

    public deleteUser = async (id: string) => {
        return await axios.post(`${this.routeName}/delete/${id}`)
            .then((response => response.data))
            .catch((error => {
                console.error(error.response);
                throw error.response.data.title;
            }))
    }
}

export interface IUser {
    id: string,
    userName: string,
    email: string,
    experience : number
}