import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class RefreshService {

  private refresh$ = new BehaviorSubject<any>({});
  selectedRefresh$ = this.refresh$.asObservable();

  constructor() {}

  sendRefresh() {
    this.refresh$.next(true);
  }

}
