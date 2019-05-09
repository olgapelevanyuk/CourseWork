import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators, FormGroup } from '@angular/forms';
import { User } from '../models/user';
import { UserService } from 'src/app/user/services/user.service';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-registration',
  templateUrl: './registration.component.html',
  styles: []
})
export class RegistrationComponent implements OnInit {


  constructor(
    private fb: FormBuilder,
    private userService: UserService,
    private toastr: ToastrService) { }

  formModel = this.fb.group({
    userName: ['', [Validators.required, Validators.minLength(5)]],
    userEmail: ['', [Validators.email, Validators.required]],
    userPasswords: this.fb.group({
      userPassword: ['', [Validators.required, Validators.minLength(4)]],
      userConfirmPassword: ['', Validators.required]
    }, { validator: this.comparePasswords })
  });

  ngOnInit() {
    this.formModel.reset();
  }

  comparePasswords(fg: FormGroup) {
    const confirmPswrdCntrl = fg.get('userConfirmPassword');

    if (confirmPswrdCntrl.errors === null || 'passwordMissmatch' in confirmPswrdCntrl.errors) {
      if (fg.get('userPassword').value !== confirmPswrdCntrl.value) {
        confirmPswrdCntrl.setErrors({ passwordMissmatch: true });
      } else {
        confirmPswrdCntrl.setErrors(null);
      }

    }
  }

  onSubmit() {
    const user = new User(
      this.formModel.value.userName,
      this.formModel.value.userEmail,
      this.formModel.value.userPasswords.userPassword
    );

    console.log(user);
    this.userService.addUser(user).subscribe(
      (res: any) => {
        if (res.status === 200) {
          this.formModel.reset();
          this.toastr.success('You are welcome!', 'Registration successfull');

        } else {
          res.errors.forEach(element => {
            switch (element.code) {
              case 'DuplicateUserName':
                this.toastr.error('Such username already taken!', 'Registration failed');
                break;
              default:
                this.toastr.error(element.description, 'Registration failed');
                break;
            }
          });
        }
      },
      err => {
        this.toastr.error(err, 'Registration failed');
      }
    );
    this.formModel.reset();
  }
}
