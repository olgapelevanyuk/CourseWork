import { ToastrService } from 'ngx-toastr';
import { Injectable } from '@angular/core';
import { HttpResponse } from '@angular/common/http';
import { CustomServerResponse } from './serverresponse';

@Injectable({
    providedIn: 'root'
})
export class ToastrHandler {

    constructor(private toastr: ToastrService) { }

    handle(response: CustomServerResponse) {
        if (response.status >= 200 && response.status < 300) {
            if (response.message !== null) {
                this.toastr.success(response.message, "Success!");
            }
        }

        if(response.status >=400 && response.status < 500){
            if(response.message !== null){
                this.toastr.warning(response.message,"Warning!")
            }
        }
        if (response.status >= 500) {
            if (response.message !== null) {
                this.toastr.error(response.message, "Failed!");
            }
        }
    }
}