import { ChangeDetectionStrategy, Component, OnInit } from '@angular/core';
import { interval, takeWhile } from 'rxjs';
import { APIService } from 'src/app/services/api.service';

@Component({
  selector: 'app-calls',
  templateUrl: './calls.component.html',
  styleUrls: ['./calls.component.css']
})
export class CallsComponent implements OnInit {
  buttonFlag: boolean = false;
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
      this.objectCalls = data;
      this.calls = this.objectCalls.calls
    });
  }

  refreshEveryHalfSecond(status: boolean){
    this.buttonFlag = status
    interval(500)
    .pipe(takeWhile(() => this.buttonFlag))
    .subscribe(() => {
      this.fetchData()
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
