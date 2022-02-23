import { TestBed } from '@angular/core/testing';

import { ApplicationService } from './application.service';

describe('ApplicationService', () => {
  let service: ApplicationService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ApplicationService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });

  it('#CalculateLoan should return correct value', () => {
    const assertObj: any = {};
    assertObj.Amount = 25000;
    assertObj.Period = 24;
    const expectObj: any = {};
    expectObj.EffectiveRate = 10;
    expectObj.MonthlyInstalment = 1153.62;
    expectObj.TotalCost = 27686.96;

    expect(service.CalculateLoan(assertObj)).toEqual(expectObj);
  });
});
