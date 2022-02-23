import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ApplicationSigningComponent } from './application-signing.component';

describe('ApplicationSigningComponent', () => {
  let component: ApplicationSigningComponent;
  let fixture: ComponentFixture<ApplicationSigningComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ApplicationSigningComponent]
    }).compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ApplicationSigningComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
