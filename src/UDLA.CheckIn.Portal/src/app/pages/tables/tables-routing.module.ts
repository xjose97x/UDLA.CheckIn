import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { TablesComponent } from './tables.component';
import { TablesFacultadesComponent } from './tables-facultades/tables-facultades.component';
import { TablesProfesoresComponent } from './tables-profesores/tables-profesores.component';

const routes: Routes = [{
  path: '',
  component: TablesComponent,
  children: [{
    path: 'facultades',
    component: TablesFacultadesComponent,
  },
  {
    path: 'profesores',
    component: TablesProfesoresComponent,
  }],
}];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class TablesRoutingModule { }

export const routedComponents = [
  TablesComponent,
  TablesFacultadesComponent,
  TablesProfesoresComponent
];
