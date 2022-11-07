import { Component, Input, OnInit } from '@angular/core';
import { Subscription } from 'rxjs';
import { APIService } from 'src/app/services/api.service';
import { RefreshService } from 'src/app/services/refresh.service';
@Component({
  selector: 'app-tabla',
  templateUrl: './tabla.component.html',
  styleUrls: ['./tabla.component.css'],
})
export class TablaComponent implements OnInit {

  constructor(private api: APIService, private refresh: RefreshService) { }

  objetoAgentes: any = {};
  agents: any[] = [];
  first = 0;
  rows = 10;
  subscription1$!: Subscription

  ngOnInit(): void {
    this.subscription1$ = this.refresh.selectedRefresh$.subscribe((value) => {
      this.fetchData()
    });
  }

  fetchData(){


    this.api.getData().subscribe(data =>{
      this.objetoAgentes = data;
      this.agents = this.objetoAgentes.sessions
    });
  }

  next() {
    this.first = this.first + this.rows;
  }

  prev() {
    this.first = this.first - this.rows;
  }

  reset() {
    this.first = 0;
  }

  isLastPage(): boolean {
    return this.agents ? this.first === (this.agents.length - this.rows): true;
  }

  isFirstPage(): boolean {
    return this.agents ? this.first === 0 : true;
  }

  logout(agentid: number){
    this.api.postLogout(agentid).subscribe((result)=>{
      console.log(result)
      this.fetchData();
    });

  }

}
