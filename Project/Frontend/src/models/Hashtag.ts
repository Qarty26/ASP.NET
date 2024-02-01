import { Generic } from './Generic'

export class Hashtag extends Generic {
    protected routeName: string = "Hashtag";
}

export interface IHashtag {
    id: string,
    tag: string,
    xp: number
}