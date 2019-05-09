import { Component, OnInit } from '@angular/core';
import { FormBuilder, NgForm } from '@angular/forms';
import { User } from '../models/user';
import { UserService } from '../services/user.service';
import { ToastrService } from 'ngx-toastr';
import { Router } from '@angular/router';
import { HttpErrorResponse, HttpResponse } from '@angular/common/http';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styles: []
})
export class LoginComponent implements OnInit {

  constructor(
    private userService: UserService,
    private toastr: ToastrService,
    private router: Router
  ) { }

  userForm = {
    userName: '',
    userPassword: ''
  };

  ngOnInit() {
    if (localStorage.getItem('token') !== null) {
      this.router.navigate(['/countries']);
    }
  }

  onSubmit(userForm: NgForm) {
    const user = new User(
      this.userForm.userName,
      '',
      this.userForm.userPassword);

    this.userService.loginUser(user).subscribe(
      (res: any) => {
        if (res.successMessage !== null) {

          localStorage.setItem('token', res.token);
          localStorage.setItem('userName', res.userName);
          localStorage.setItem('userId', res.userId);
          localStorage.setItem('userPassword', res.userPassword);
          localStorage.setItem('userRole', res.userRole);
          localStorage.setItem('userEmail',res.userEmail);
          
          this.toastr.success('Welcome!', 'Sign in success');

          if (res.userRole === 'applicationAdmin') {
            this.router.navigateByUrl('/admin');
          }
          else {
            this.router.navigateByUrl('/user/main');
          }
        }
      },
      (error: HttpErrorResponse) => {
        if(error.status === 400){
        this.toastr.error('Failed',error.error.errorMessage);
        }
      }
    );
  }
}
