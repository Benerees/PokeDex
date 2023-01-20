import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { LayoutComponent } from './layout.component';
import { FooterModule } from '../_shared/footer/footer.module';
import { NavbarModule } from '../_shared/navbar/navbar.module';
import { RouterModule } from '@angular/router';



@NgModule({
  declarations: [
    LayoutComponent
  ],
  imports: [
    CommonModule,

    NavbarModule,
    RouterModule

  ],
  exports:[
    LayoutComponent
  ]
})
export class LayoutModule { }
