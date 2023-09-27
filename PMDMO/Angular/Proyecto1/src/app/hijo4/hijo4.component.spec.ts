import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Hijo4Component } from './hijo4.component';

describe('Hijo4Component', () => {
  let component: Hijo4Component;
  let fixture: ComponentFixture<Hijo4Component>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [Hijo4Component]
    });
    fixture = TestBed.createComponent(Hijo4Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
