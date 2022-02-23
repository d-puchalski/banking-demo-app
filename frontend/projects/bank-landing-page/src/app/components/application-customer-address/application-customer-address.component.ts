import { Component, OnInit } from '@angular/core';
import { FormGroup, ControlContainer } from '@angular/forms';
import { Router } from '@angular/router';
import { ApplicationService } from '../../../../../../libs/application/src/lib/services/application.service';

@Component({
  selector: 'app-application-customer-address',
  templateUrl: './application-customer-address.component.html',
  styleUrls: ['./application-customer-address.component.css']
})
export class ApplicationCustomerAddressComponent implements OnInit {
  public form: FormGroup = this.controlContainer?.control?.get('address') as FormGroup;
  public isValidated = false;
  constructor(
    private applicationService: ApplicationService,
    private controlContainer: ControlContainer,
    private router: Router
  ) { }

  ngOnInit(): void {
  }

  public onNext() {
    this.isValidated = true;
    if (this.form.valid) {
      this.router.navigateByUrl('/verify');
    }
  }
}
