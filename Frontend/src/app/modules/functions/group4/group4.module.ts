import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';
import { ModelCarManagementGroup4Component } from './model-car-management-group4/model-car-management-group4.component';

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    RouterModule
  ],
  declarations: [ModelCarManagementGroup4Component],
  exports: [ModelCarManagementGroup4Component]
})
export class Group4Module { }
