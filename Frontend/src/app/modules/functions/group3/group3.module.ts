import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';
import { DxCarAddGroup3Component } from './dx-car-add-group3/dx-car-add-group3.component';

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    RouterModule
  ],
  declarations: [DxCarAddGroup3Component],
  exports: [DxCarAddGroup3Component]
})
export class Group3Module { }
