import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CallbackSigninComponent } from './callback-signin.component';

describe('CallbackSigninComponent', () => {
  let component: CallbackSigninComponent;
  let fixture: ComponentFixture<CallbackSigninComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CallbackSigninComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(CallbackSigninComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });
});
