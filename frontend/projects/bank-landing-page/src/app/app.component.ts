import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'blp-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'bank-landing-page';
  public mainForm: FormGroup = new FormGroup({
    finance: new FormGroup({
      amount: new FormControl(25000, Validators.required),
      periods: new FormControl(12, Validators.required)
    }),
    customer: new FormGroup({
      ssn: new FormControl('', Validators.required),
      firstName: new FormControl('', Validators.required),
      lastName: new FormControl('', Validators.required),
      birthDate: new FormControl('', Validators.required)
    }),
    address: new FormGroup({
      address1: new FormControl('', Validators.required),
      address2: new FormControl(''),
      zip: new FormControl('', Validators.required),
      country: new FormControl('', Validators.required),
      phone: new FormControl('', Validators.required),
      email: new FormControl('', [Validators.required, Validators.pattern('^[a-z0-9._%+-]+@[a-z0-9.-]+\\.[a-z]{2,4}$')])
    }),
    documents: new FormGroup({
      consentMarketing: new FormControl(false, Validators.required),
      consentRodo: new FormControl(false, Validators.required),
      openAccountSigned: new FormControl('', Validators.required)
    })
  });

  constructor() { }

  ngOnInit(): void {

  }
}
