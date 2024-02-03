import { Generic } from './Generic'
import axios from '@/helpers/AxiosInstance'

export class Hashtag extends Generic {
    protected routeName: string = "Hashtag"

    public createTag = async (payload : any) => {
        return await axios.post(`${this.routeName}/create`,payload)
            .then((response => response.data))
            .catch((error => {
                console.error(error.response);
                throw error.response.data.title;
            }))
    }

    public deleteTag = async (id: string) => {
        return await axios.post(`${this.routeName}/delete/${id}`)
            .then((response => response.data))
            .catch((error => {
                console.error(error.response);
                throw error.response.data.title;
            }))
    }
}

export interface IHashtag {
    id: string,
    tag: string,
    xp: number
}