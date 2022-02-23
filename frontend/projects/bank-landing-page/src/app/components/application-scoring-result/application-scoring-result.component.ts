import { Component, OnInit } from '@angular/core';
import { ControlContainer, FormGroup } from '@angular/forms';
import { Router } from '@angular/router';
import { CalculationOwnerAddressModel } from '../../../../../../libs/application/src/lib/models/CalculationOwnerAddressModel';
import { CalculationOwnerConsentsModel } from '../../../../../../libs/application/src/lib/models/CalculationOwnerConsentsModel';
import { CalculationOwnerModel } from '../../../../../../libs/application/src/lib/models/CalculationOwnerModel';
import { GetCalculationRequestModel } from '../../../../../../libs/application/src/lib/models/GetCalculationRequestModel';
import { ScoringResultEnum } from '../../../../../../libs/application/src/lib/models/ScoringResultEnum';
import { ApplicationService } from '../../../../../../libs/application/src/lib/services/application.service';

@Component({
  selector: 'blp-scoring-result',
  templateUrl: './application-scoring-result.component.html',
  styleUrls: ['./application-scoring-result.component.css']
})
export class ApplicationScoringResultComponent implements OnInit {
  public scoringResult = {
    result: ScoringResultEnum.Negative,
    validated: false
  };

  constructor(
    private service: ApplicationService,
    private controlContainer: ControlContainer,
    private router: Router) { }

  public formFinance: FormGroup = this.controlContainer?.control?.get('finance') as FormGroup;
  public formCustomer: FormGroup = this.controlContainer?.control?.get('customer') as FormGroup;
  public formAddress: FormGroup = this.controlContainer?.control?.get('address') as FormGroup;

  ngOnInit(): void {
    this.score();
  }

  public onNext() {
    if (this.scoringResult.validated && this.scoringResult.result === ScoringResultEnum.Positive) {
      this.router.navigateByUrl('/documents');
    }
  }

  public score() {
    if (this.formFinance.valid && this.formCustomer.valid && this.formAddress.valid) {
      const request: GetCalculationRequestModel = new GetCalculationRequestModel();
      request.amount = this.formFinance.get('amount')?.value;
      request.periods = this.formFinance.get('periods')?.value;
      request.owner = new CalculationOwnerModel();
      request.owner.birthDate = this.formCustomer.get('birthDate')?.value;
      request.owner.firstName = this.formCustomer.get('firstName')?.value;
      request.owner.lastName = this.formCustomer.get('lastName')?.value;
      request.owner.ssn = this.formCustomer.get('ssn')?.value;
      request.owner.address = new CalculationOwnerAddressModel();
      request.owner.address.address1 = this.formAddress.get('address1')?.value;
      request.owner.address.address2 = this.formAddress.get('address2')?.value;
      request.owner.address.zip = this.formAddress.get('zip')?.value;
      request.owner.address.country = this.formAddress.get('country')?.value;
      request.owner.address.phone = this.formAddress.get('phone')?.value;
      request.owner.address.email = this.formAddress.get('email')?.value;
      request.owner.consents = new CalculationOwnerConsentsModel();

      this.service.ScoringResult(request).subscribe((result) => {
        this.scoringResult = {
          result: result.scoringResult,
          validated: true
        };
      });
    }
  }
}
