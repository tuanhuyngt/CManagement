import { Component, OnInit, Injector } from '@angular/core';
import { AppComponentBase } from '@shared/common/app-component-base';

@Component({
  selector: 'app-model-car-management-group4',
  templateUrl: './model-car-management-group4.component.html',
  styleUrls: ['./model-car-management-group4.component.css', '../../style.less']
})
export class ModelCarManagementGroup4Component extends AppComponentBase implements OnInit {

  constructor(injector: Injector) {
    super(injector);
  }

  ngOnInit() {
  }

}
