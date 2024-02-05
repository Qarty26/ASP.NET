import { Generic } from './Generic'
import axios from '@/helpers/AxiosInstance'
import type {IMap} from "@/models/Map";

export class Track extends Generic {
    protected routeName: string = 'Track'

    public createTrack = async (payload : any) => {
        return await axios.post(`${this.routeName}/create`,payload)
            .then((response => response.data))
            .catch((error => {
                console.error(error.response);
                throw error.response.data.title;
            }))
    }

    public deleteTrack = async (id: string) => {
        return await axios.post(`${this.routeName}/delete/${id}`)
            .then((response => response.data))
            .catch((error => {
                console.error(error.response);
                throw error.response.data.title;
            }))
    }

    public all_map = async (params: string = '') => {
        return await axios.get(`${this.routeName}/get_map${params}`)
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

export interface ITrack {
    id: string,
    name: string,
    xp: number,
    confirmed: boolean
    map: IMap
}