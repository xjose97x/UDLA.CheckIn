import { NgModule } from '@angular/core';

import { NgxEchartsModule } from 'ngx-echarts';

import { ThemeModule } from '../../@theme/theme.module';
import { DashboardComponent } from './dashboard.component';
import { ChartsModule } from '../../@charts/charts.module';


@NgModule({
  imports: [
    ThemeModule,
    NgxEchartsModule,
    ChartsModule
  ],
  declarations: [
    DashboardComponent,

  ],
})
export class DashboardModule { }
