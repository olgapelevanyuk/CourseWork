export class CustomServerResponse{
    constructor(public message: string,
                public data: object,
                public status: number){}
}