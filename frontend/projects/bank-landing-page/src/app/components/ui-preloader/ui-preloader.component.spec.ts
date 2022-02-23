import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UiPreloaderComponent } from './ui-preloader.component';

describe('UiPreloaderComponent', () => {
  let component: UiPreloaderComponent;
  let fixture: ComponentFixture<UiPreloaderComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [UiPreloaderComponent]
    }).compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(UiPreloaderComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
