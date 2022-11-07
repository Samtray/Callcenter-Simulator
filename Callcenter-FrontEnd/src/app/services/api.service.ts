import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class APIService {

  constructor(private http: HttpClient) { }

  readonly apiURL = 'https://localhost:7112/api/';

  getData(): Observable<any>{
    return this.http.get(this.apiURL + 'Sessions');
  }

  postLogout(agentid: number): Observable<any>{
    var formData: any = new FormData();
      formData.append("agentid", agentid);
      return this.http.post(this.apiURL + 'LogoutAgent', formData)
  }

  postLogin(agentid: number, agentpin: number, station: number): Observable<any>{
    var formData: any = new FormData();
      formData.append("agentid", agentid);
      formData.append("agentpin", agentpin);
      formData.append("stationid", station);
      return this.http.post(this.apiURL + 'LoginAgent', formData)
  }
}
