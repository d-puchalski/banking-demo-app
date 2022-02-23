import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class ApplicationStore {
  rate: number = 0;
  instalment: number = 0;
  totalCost: number = 0;
}
