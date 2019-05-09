import { Airport } from 'src/app/airport-management/models/airport';

export class Flight {
    constructor(
        public flightId: number,
        arriveString: string,
        departureString: string,
        public arriveAirportId: number,
        public departureAirportId: number,
        public flightPrice: number,
        public isDeleted: boolean
    ) {
        this.arriveTime = new Date(arriveString);
        this.departureTime = new Date(departureString);
    }

    public arriveTime: Date;
    public departureTime: Date;

    public arriveAirport: Airport;
    public departureAirport: Airport;
}