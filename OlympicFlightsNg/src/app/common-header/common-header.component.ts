import { Component, OnInit } from '@angular/core';
import { UserService } from '../user/services/user.service';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-common-header',
  templateUrl: './common-header.component.html',
  styleUrls: ['./common-header.component.css']
})
export class CommonHeaderComponent implements OnInit {

  constructor(
    private userService: UserService,
    private route: ActivatedRoute
  ) {
    route.params.subscribe(val => {
      this.isSignedIn = localStorage.getItem('token') === null ? false : true;
    });
  }

  isAdmin = false;
  isSignedIn = false;

  ngOnInit() {
    this.isSignedIn = localStorage.getItem('token') === null? false : true;
    this.isAdmin = this.userService.isUserAdmin();
  }

  onLogout() {
    this.userService.logoutUser();

    this.isAdmin = false;
    this.isSignedIn = false;
  }
}
