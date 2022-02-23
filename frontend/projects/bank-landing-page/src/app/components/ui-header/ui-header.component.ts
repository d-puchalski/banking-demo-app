import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { AuthService } from '../../../../../../libs/auth/src/lib/services/auth.service';

@Component({
  selector: 'blp-ui-header',
  templateUrl: './ui-header.component.html',
  styleUrls: ['./ui-header.component.css']
})
export class UiHeaderComponent implements OnInit {
  constructor(public authService: AuthService) { }

  ngOnInit(): void { }

  isLoggedIn$: Observable<boolean> = this.authService.isLoggedIn$();

  public login() {
    this.authService.loginRedirect$();
  }

  public logout() {
    this.authService.logoutRedirect();
  }
}
