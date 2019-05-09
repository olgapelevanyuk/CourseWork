import { Client } from 'src/app/client-management/client';

export class Ticket {

    public client: Client;
    public flightId: number;
    constructor(
        public ticketId: number,
        public clientId: number,
        public isPurchaseApproved: boolean,
        public isDeleted: boolean,
        public created: Date
    ) { 
    }

}
