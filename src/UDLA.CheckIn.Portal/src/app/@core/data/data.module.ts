import { NgModule, ModuleWithProviders } from '@angular/core';
import { CommonModule } from '@angular/common';

import { UserService } from './users.service';
import { StateService } from './state.service';
import { ApiModule, EmployeeService, FacultyService } from './api';

const SERVICES = [
  UserService,
  StateService,
  EmployeeService,
  FacultyService
];

@NgModule({
  imports: [
    CommonModule,
    ApiModule
  ],
  providers: [
    ...SERVICES,
  ],
})
export class DataModule {
  static forRoot(): ModuleWithProviders {
    return <ModuleWithProviders>{
      ngModule: DataModule,
      providers: [
        ...SERVICES,
      ],
    };
  }
}
