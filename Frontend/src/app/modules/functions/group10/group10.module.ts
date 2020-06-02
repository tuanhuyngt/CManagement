import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';
import { CarAddGroup10Component } from './car-add-group10/car-add-group10.component';

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    RouterModule
  ],
  declarations: [CarAddGroup10Component],
  exports: [CarAddGroup10Component]
})
export class Group10Module { }
