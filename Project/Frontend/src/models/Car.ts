import { Generic } from './Generic'

export class Car extends Generic {
    protected routeName: string = 'Car'
}

export interface ICar {
    id: string,
    make: string,
    model: string,
    year: number,
    color: string
}