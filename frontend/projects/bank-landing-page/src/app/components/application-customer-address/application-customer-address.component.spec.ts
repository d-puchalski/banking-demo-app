import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ApplicationCustomerAddressComponent } from './application-customer-address.component';

describe('ApplicationCustomerAddressComponent', () => {
  let component: ApplicationCustomerAddressComponent;
  let fixture: ComponentFixture<ApplicationCustomerAddressComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ApplicationCustomerAddressComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ApplicationCustomerAddressComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
