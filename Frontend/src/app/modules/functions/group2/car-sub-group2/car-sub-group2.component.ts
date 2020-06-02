import { Component, OnInit, Injector } from '@angular/core';
import { AppComponentBase } from '@shared/common/app-component-base';

@Component({
  selector: 'app-car-sub-group2',
  templateUrl: './car-sub-group2.component.html',
  styleUrls: ['./car-sub-group2.component.css', '../../style.less']
})
export class CarSubGroup2Component extends AppComponentBase implements OnInit {

  constructor(injector: Injector) {
    super(injector);
  }

  ngOnInit() {
  }

}
