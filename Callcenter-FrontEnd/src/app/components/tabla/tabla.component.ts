import { ChangeDetectionStrategy, Component, OnInit } from '@angular/core';
import { APIService } from 'src/app/services/api.service';
@Component({
  selector: 'app-tabla',
  templateUrl: './tabla.component.html',
  styleUrls: ['./tabla.component.css'],
  changeDetection: ChangeDetectionStrategy.OnPush
})
export class TablaComponent implements OnInit {

  constructor(private APIService:APIService) { }

  objetoAgentes:any;
  agents: any[] = [];
  first = 0;
  rows = 10;

  ngOnInit(): void {
    this.fetchData();
  }

  fetchData(){
    this.APIService.getData().subscribe(data =>{
      this.objetoAgentes = data;
      this.agents = this.objetoAgentes.sessions
      console.log(this.agents);
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

}
