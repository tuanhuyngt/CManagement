import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';
import { ModelCarAddGroup9Component } from './model-car-add-group9/model-car-add-group9.component';

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    RouterModule
  ],
  declarations: [ModelCarAddGroup9Component],
  exports:[ModelCarAddGroup9Component]
})
export class Group9Module { }
