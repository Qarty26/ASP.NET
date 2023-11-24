import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DecComponent } from './dec.component';

describe('DecComponent', () => {
  let component: DecComponent;
  let fixture: ComponentFixture<DecComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [DecComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(DecComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
