import { Injectable } from '@angular/core';
import { UserManagerSettings, UserManager, User } from 'oidc-client';
import { Observable, from, defer } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  constructor() { }

  settings: UserManagerSettings = {
    authority: 'XXX',
    client_id: 'XXX',
    redirect_uri: 'XXX',
    // silent_redirect_uri: `${environment.clientRoot}assets/silent-callback.html`,
    post_logout_redirect_uri: 'XXX',
    response_type: 'code',
    scope: 'XXX',
    loadUserInfo: false
  };

  private _userManager = new UserManager(this.settings);

  public loginRedirect$(): Observable<any> {
    return from(this._userManager.signinRedirect());
  }

  public logoutRedirect(): void {
    this._userManager.signoutRedirect();
    this._userManager.clearStaleState();
  }

  public accessToken$(): Observable<string> {
    return defer(() => this._userManager.getUser().then(user => {
      if (user == null) {
        throw new Error('User is not logged in');
      }
      return user?.id_token;
    }));
  }

  public handleCallBack(): Observable<User> {
    return from(this._userManager.signinRedirectCallback());
  }

  public isLoggedIn$(): Observable<boolean> {
    return defer(() => this._userManager.getUser().then(user => {
      return user != null;
    }));
  }
}
