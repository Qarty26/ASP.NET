import { Generic } from './Generic'

export class Map extends Generic {
    protected routeName: string = 'Map'
}

export interface IMap {
    id: string,
    startLatitude: number,
    endLatitude: number,
    startLongitude: number,
    endLongitude: number,
}