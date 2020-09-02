import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ReservationPreorderComponent } from './reservation-preorder.component';

describe('ReservationPreorderComponent', () => {
  let component: ReservationPreorderComponent;
  let fixture: ComponentFixture<ReservationPreorderComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ReservationPreorderComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ReservationPreorderComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
