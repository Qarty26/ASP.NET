import { Generic } from './Generic'

export class Track extends Generic {
    protected routeName: string = 'Track'
}

export interface ITrack {
    id: string,
    name: string,
    xp: number,
    confirmed: boolean
}