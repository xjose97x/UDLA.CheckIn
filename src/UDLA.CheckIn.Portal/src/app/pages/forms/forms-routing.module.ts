import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { FormsComponent } from './forms.component';
import { FormFacultadesComponent } from './form-facultades/form-facultades.component';
import { FormProfesoresComponent } from './form-profesores/form-profesores.component';

const routes: Routes = [{
  path: '',
  component: FormsComponent,
  children: [{
    path: 'facultades',
    component: FormFacultadesComponent,
  }, {
    path: 'profesores',
    component: FormProfesoresComponent,
  }],
}];

@NgModule({
  imports: [
    RouterModule.forChild(routes),
  ],
  exports: [
    RouterModule,
  ],
})
export class FormsRoutingModule {

}

export const routedComponents = [
  FormsComponent,
  FormFacultadesComponent,
  FormProfesoresComponent,
];
