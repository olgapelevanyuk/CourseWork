import { Component, OnInit } from '@angular/core';
import { UserService } from '../services/user.service';
import { User } from '../models/user';
import { FormBuilder } from '@angular/forms';

@Component({
  selector: 'app-profile',
  templateUrl: './profile.component.html',
  styleUrls: ['./profile.component.css']
})
export class ProfileComponent implements OnInit {

  constructor(private userService: UserService,
    private formBuilder: FormBuilder) { }

  currentUser : User;

  ngOnInit() {
    this.userService.getUserByName(localStorage.getItem('userName')).subscribe(res => {
      this.currentUser = res;
    })
  }

  formModel = this.formBuilder.group({
    newPassword:null,
    oldPassword:null
  })

  onSubmit(){
    this.userService.changePassword(this.formModel.value.newPassword);
  }
}
