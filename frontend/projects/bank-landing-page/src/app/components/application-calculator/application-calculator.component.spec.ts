import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ApplicationCalculatorComponent } from './application-calculator.component';

describe('ApplicationCalculatorComponent', () => {
  let component: ApplicationCalculatorComponent;
  let fixture: ComponentFixture<ApplicationCalculatorComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ApplicationCalculatorComponent]
    }).compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ApplicationCalculatorComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
