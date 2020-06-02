import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';
import { DxCarPdGroup7Component } from './dx-car-pd-group7/dx-car-pd-group7.component';

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    RouterModule
  ],
  declarations: [DxCarPdGroup7Component],
  exports:[DxCarPdGroup7Component]
})
export class Group7Module { }
