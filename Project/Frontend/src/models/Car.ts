import { Generic } from './Generic'
import axios from "axios";

export class Car extends Generic {
    protected routeName: string = 'Car'

    public createCar = async (payload : any) => {
        return await axios.post(`${this.routeName}/create`,payload)
            .then((response => response.data))
            .catch((error => {
                console.error(error.response);
                throw error.response.data.title;
            }))
    }

    public deleteCar = async (id: string) => {
        return await axios.post(`${this.routeName}/delete/${id}`)
            .then((response => response.data))
            .catch((error => {
                console.error(error.response);
                throw error.response.data.title;
            }))
    }
}

export interface ICar {
    id: string,
    make: string,
    model: string,
    year: number,
    color: string
}