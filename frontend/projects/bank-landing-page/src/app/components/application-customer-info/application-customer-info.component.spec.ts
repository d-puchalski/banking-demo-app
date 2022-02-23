import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ApplicationCustomerInfoComponent } from './application-customer-info.component';

describe('ApplicationCustomerInfoComponent', () => {
  let component: ApplicationCustomerInfoComponent;
  let fixture: ComponentFixture<ApplicationCustomerInfoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ApplicationCustomerInfoComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ApplicationCustomerInfoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
