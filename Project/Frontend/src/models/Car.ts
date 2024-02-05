import { Generic } from './Generic'
import axios from '@/helpers/AxiosInstance'

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

    public all_between = async (start: number, end: number) => {
        return await axios.get(`${this.routeName}/get_interval?startYear=${start}&endYear=${end}`)
            .then((response) => response.data)
            .catch((error) => {
                if (error.response.status == 404) {
                    console.log(error.response.data.message);
                }
                console.error(error.response);
                return [];
            });
    }
}

export interface ICar {
    id: string,
    make: string,
    model: string,
    year: number,
    color: string
}