import { Component, OnInit } from '@angular/core';
import { APIService } from 'src/app/services/api.service';
@Component({
  selector: 'app-tabla',
  templateUrl: './tabla.component.html',
  styleUrls: ['./tabla.component.css'],
})
export class TablaComponent implements OnInit {

  constructor(private APIService:APIService) { }

  objetoAgentes:any;
  agents: any[] = [];
  first = 0;
  rows = 10;
  dateMessage = "Hasn't Logged Out";
  ngOnInit(): void {
    this.fetchData();
  }

  fetchData(){
    this.APIService.getData().subscribe(data =>{
      this.objetoAgentes = data;
      this.agents = this.objetoAgentes.sessions
      this.agents.forEach(obj =>{
        if(obj.dateTimeLogout == "0001-01-01T00:00:00"){
          obj.dateTimeLogout = this.dateMessage;
        }
      });
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

  test(agent:any){
    console.log(agent);
    //this.agents = [this.agents[0]];
  }

}
