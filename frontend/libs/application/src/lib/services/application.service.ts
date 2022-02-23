import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import * as _ from 'lodash';
import { Observable, tap } from 'rxjs';
import { GetCalculationRequestModel } from '../models/GetCalculationRequestModel';
import { GetCalculationResponseModel } from '../models/GetCalculationResponseModel';
import { UICalculatorRequestModel } from '../models/UICalculatorRequestModel';
import { UICalculatorResponseModel } from '../models/UICalculatorResponseModel';

@Injectable({
  providedIn: 'root'
})
export class ApplicationService {
  constructor(private http: HttpClient, @Inject('env') private env: any) { }

  public applicationData = {
    scoring: {
      result: 0,
      validated: false
    },
    calculation: {
      totalCost: 0,
      monthlyInstalment: 0
    }
  };

  public CalculateLoan(request: UICalculatorRequestModel): UICalculatorResponseModel {
    const response = new UICalculatorResponseModel();
    response.effectiveRate = 10;
    const q = 1 + (response.effectiveRate / 100 / 12);
    const s = Math.pow(q, request.periods);
    const f = request.amount * s * (q - 1);
    const r = f / (s - 1);
    response.monthlyInstalment = r;
    response.totalCost = response.monthlyInstalment * request.periods;

    response.monthlyInstalment = _.round(response.monthlyInstalment, 2);
    response.totalCost = _.round(response.totalCost, 2);

    return response;
  }

  public ScoringResult(model: GetCalculationRequestModel): Observable<GetCalculationResponseModel> {
    return new Observable(observer => {
      model.totalCost = this.applicationData.calculation.totalCost;
      model.instalment = this.applicationData.calculation.monthlyInstalment;
      this.http.post<GetCalculationResponseModel>(this.env.endpoints.apiApplicationEndpointUrl + 'calculation', model)
        .pipe(
          tap(console.debug)
        )
        .subscribe(post => {
          observer.next(post);
        });
    });
  }
}
