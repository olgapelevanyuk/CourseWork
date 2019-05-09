import { City } from 'src/app/city-management/city-model/city';

export class Airport{
    constructor(
        public airportId: number,
        public airportName: string,
        public airportCode: string,
        public cityId: number,
        public isDeleted: boolean,
        public cityName: string
    ){}

    public city : City;
}