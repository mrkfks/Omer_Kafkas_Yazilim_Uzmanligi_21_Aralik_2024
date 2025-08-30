import { ComponentFixture, TestBed } from '@angular/core/testing';

import { BackgroundItem } from './background-item';

describe('BackgroundItem', () => {
  let component: BackgroundItem;
  let fixture: ComponentFixture<BackgroundItem>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [BackgroundItem]
    })
    .compileComponents();

    fixture = TestBed.createComponent(BackgroundItem);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
