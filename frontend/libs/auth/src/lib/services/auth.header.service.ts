import { HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
@Injectable({
  providedIn: 'root'
})
export class AuthHeaderService {
  public get Headers(): HttpHeaders {
    return new HttpHeaders({
      Authorization: 'Bearer ' + sessionStorage.getItem('bankingdemo.token')
    });
  };
}
