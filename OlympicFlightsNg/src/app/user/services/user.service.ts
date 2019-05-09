import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { User } from '../models/user';
import { environment } from 'src/environments/environment';
import { Router } from '@angular/router';
import { Observable } from 'rxjs';
import { ToastrService } from 'ngx-toastr';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  private url = environment.apiUrl + 'api/users/';

  constructor(
    private http: HttpClient,
    private router: Router,
    private toastr: ToastrService) { }

  addUser(user: User) {
    return this.http.post(`${this.url}signup`, user);
  }

  getUserByName(userName: string): Observable<User>{
    return this.http.get<User>(`${this.url}${userName}`);
  }

  getCurrentUserId(): string{
    var id = localStorage.getItem('userId');
    return id;
  }

  loginUser(user: User) {
    return this.http.post(`${this.url}signin`, user);
  }

  logoutUser() {
    localStorage.removeItem('token');
    localStorage.removeItem('userName');
    localStorage.removeItem('userId');
    localStorage.removeItem('userPassword');
    localStorage.removeItem('userRole');
    localStorage.removeItem('userEmail');
    this.router.navigateByUrl(`/user/signin`);
  }

  isUserAdmin(): boolean {
    const userRole = localStorage.getItem('userRole');

    if(userRole === 'applicationAdmin'){
      return true;
    }
    // if (this.http.get<boolean>(`${this.url}isAdmin/${userId}`)) {
    //   return true;
    // }

    return false;
  }

  changePassword(newPassword: string){

    var user = new User(
      localStorage.getItem('userName'),
      localStorage.getItem('userEmail'),
      localStorage.getItem('userPassword')
    );

    user.newPassword=newPassword;
    user.userRole = localStorage.getItem('userRole');
    user.userId = localStorage.getItem('userId');

    this.http.put(`${this.url}changePassword`,user).subscribe((res:any) => {
      if(res.successMessage !== undefined){
        this.toastr.success(res.successMessage);
        localStorage.removeItem('userPassword');
        localStorage.setItem('userPassword',res.newPassword);
      }
      else{
        this.toastr.success(res.errorMessage);
      }
    })

  }



  getCurrentUser() {
    const name = localStorage.getItem('userName');
    const id = localStorage.getItem('userId');

    if (id !== null && name !== null) {
      return {
        userName: name,
        userId: id
      };
    }

    return null;
  }

}
