import { ChangeDetectionStrategy, Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-simulator',
  templateUrl: './simulator.component.html',
  styleUrls: ['./simulator.component.css'],
  changeDetection: ChangeDetectionStrategy.OnPush
})
export class SimulatorComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }

}
