import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ApplicationScoringResultComponent } from './application-scoring-result.component';

describe('ScoringResultComponent', () => {
  let component: ApplicationScoringResultComponent;
  let fixture: ComponentFixture<ApplicationScoringResultComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ApplicationScoringResultComponent]
    }).compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ApplicationScoringResultComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
