import { NgModule } from '@angular/core';

import { NgxEchartsModule } from 'ngx-echarts';

import { ThemeModule } from '../../@theme/theme.module';
import { DashboardComponent } from './dashboard.component';
import { ChartsModule } from '../../@charts/charts.module';
import { DataModule } from '../../@core/data/data.module';


@NgModule({
  imports: [
    ThemeModule,
    NgxEchartsModule,
    ChartsModule,
    DataModule
  ],
  declarations: [
    DashboardComponent,

  ],
})
export class DashboardModule { }
