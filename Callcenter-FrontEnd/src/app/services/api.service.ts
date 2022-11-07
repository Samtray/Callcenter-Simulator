import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class APIService {

  constructor(private http: HttpClient) { }

  readonly cumoki = 'https://mocki.io/v1/96e667bc-b80d-4989-90cc-d476a59f6bf9';

  getData(){
    return this.http.get(this.cumoki);
  }
}
