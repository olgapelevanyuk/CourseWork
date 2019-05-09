import { Country } from 'src/app/country-management/models/country';

export class City {

    public country: Country;

    constructor(
        public cityId: number,
        public countryId: number,
        public cityName: string,
        public countryName: string
    ){}
}