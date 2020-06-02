import { Component, OnInit, Injector } from '@angular/core';
import { AppComponentBase } from '@shared/common/app-component-base';

@Component({
  selector: 'app-dx-car-add-group3',
  templateUrl: './dx-car-add-group3.component.html',
  styleUrls: ['./dx-car-add-group3.component.css', '../../style.less']
})
export class DxCarAddGroup3Component extends AppComponentBase implements OnInit {

  constructor(injector: Injector) {
    super(injector);
  }

  ngOnInit() {
  }

}
