import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { AuthService } from '../../../../../../libs/auth/src/lib/services/auth.service';

@Component({
  selector: 'blp-callback-signin',
  templateUrl: './callback-signin.component.html',
  styleUrls: ['./callback-signin.component.css']
})
export class CallbackSigninComponent implements OnInit {
  constructor(private router: Router, public authService: AuthService) { }

  ngOnInit() {
    if (this.router.url.includes('code')) {
      this.authService.handleCallBack().subscribe((user: any) => {
        window.location.replace('/overview');
      });
    }
  }
}
