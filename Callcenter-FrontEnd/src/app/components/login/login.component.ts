import { ChangeDetectionStrategy, Component, EventEmitter, OnInit, Output } from '@angular/core';
import { APIService } from 'src/app/services/api.service';
import { RefreshService } from 'src/app/services/refresh.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css'],
  changeDetection: ChangeDetectionStrategy.OnPush
})
export class LoginComponent implements OnInit {

  agentid!: number;
  agentpin!: number;
  station!: number;
  @Output() messageEvent = new EventEmitter<boolean>();

  constructor(private api: APIService, private refresh: RefreshService) { }

  ngOnInit(): void {
  }

  login(agentid: number, agentpin: number, station: number){
      this.api.postLogin(agentid, agentpin, station).subscribe((result)=>{
        console.log(result)
        this.refresh.sendRefresh();
      });
    }

  }

