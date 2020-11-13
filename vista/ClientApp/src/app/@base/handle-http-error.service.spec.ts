import { TestBed } from '@angular/core/testing';

import { HandleHttpErrorService } from './handle-http-error.service';

describe('HandleHttpErrorService', () => {
  let service: HandleHttpErrorService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(HandleHttpErrorService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
