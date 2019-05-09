import { City } from '../../city-management/city-model/city';

export class BuyTicketFormModel {
    constructor(
        depCity: City,
        arrCity: City,
        depTime: Date,
        arrTime: Date,
        minPrice: number,
        maxPrice: number
    ){}
}