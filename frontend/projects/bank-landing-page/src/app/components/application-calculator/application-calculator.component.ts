import { Component, OnInit } from '@angular/core';
import { FormGroup, ControlContainer } from '@angular/forms';
import { Router } from '@angular/router';
import * as _ from 'lodash';
import { UICalculatorResponseModel } from '../../../../../../libs/application/src/lib/models/UICalculatorResponseModel';
import { ApplicationService } from '../../../../../../libs/application/src/lib/services/application.service';
@Component({
  selector: 'blp-calculator',
  templateUrl: './application-calculator.component.html',
  styleUrls: ['./application-calculator.component.css']
})
export class ApplicationCalculatorComponent implements OnInit {
  public form: FormGroup = this.controlContainer?.control?.get('finance') as FormGroup
  public calculationResponse: UICalculatorResponseModel = new UICalculatorResponseModel();
  constructor(
    private applicationService: ApplicationService,
    private controlContainer: ControlContainer,
    private router: Router
  ) { }

  ngOnInit(): void {
    this.form.valueChanges?.subscribe(() => this.calc());
    this.calc();
  }

  public calc() {
    const amount = this.form?.get('amount')?.value;
    const periods = this.form?.get('periods')?.value;

    if (_.isNumber(amount) && _.isNumber(periods)) {
      this.calculationResponse = this.applicationService.CalculateLoan({
        amount: amount,
        periods: periods
      });
      this.applicationService.applicationData.calculation.totalCost = this.calculationResponse.totalCost;
      this.applicationService.applicationData.calculation.monthlyInstalment = this.calculationResponse.monthlyInstalment;
    }
  }

  public onNext() {
    if (this.form.valid) {
      this.router.navigateByUrl('/customer');
    }
  }
}
