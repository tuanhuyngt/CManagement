import { Component, OnInit, Injector } from '@angular/core';
import { AppComponentBase } from '@shared/common/app-component-base';

@Component({
  selector: 'app-car-add-group10',
  templateUrl: './car-add-group10.component.html',
  styleUrls: ['./car-add-group10.component.css', '../../style.less']
})
export class CarAddGroup10Component extends AppComponentBase implements OnInit {

  constructor(injector: Injector) {
    super(injector);
  }

  ngOnInit() {
  }

}
