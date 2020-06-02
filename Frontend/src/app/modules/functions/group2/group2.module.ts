import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';
import { CarSubGroup2Component } from './car-sub-group2/car-sub-group2.component';

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    RouterModule
  ],
  declarations: [CarSubGroup2Component],
  exports: [CarSubGroup2Component]
})
export class Group2Module { }
