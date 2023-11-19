import { TestBed } from '@angular/core/testing';

import { ShoppersService } from './shoppers.service';

describe('ShoppersService', () => {
  let service: ShoppersService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ShoppersService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
