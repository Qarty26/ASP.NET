import { Generic } from './Generic'
import axios from '@/helpers/AxiosInstance'

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
}

export interface ITrack {
    id: string,
    name: string,
    xp: number,
    confirmed: boolean
}