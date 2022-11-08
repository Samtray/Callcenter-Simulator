import { ChangeDetectionStrategy, Component, OnInit } from '@angular/core';
import { APIService } from 'src/app/services/api.service';

@Component({
  selector: 'app-calls',
  templateUrl: './calls.component.html',
  styleUrls: ['./calls.component.css']
})
export class CallsComponent implements OnInit {

  objectCalls: any = {};
  calls: any[] = [];
  first = 0;
  rows = 5;

  constructor(private api: APIService) { }


  ngOnInit(): void {
    this.fetchData()
  }

  fetchData(){
    this.api.getCalls().subscribe(data =>{
      console.log(data)
      this.objectCalls = data;
      this.calls = this.objectCalls.calls
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
    return this.calls ? this.first === (this.calls.length - this.rows): true;
  }

  isFirstPage(): boolean {
    return this.calls ? this.first === 0 : true;
  }

}
