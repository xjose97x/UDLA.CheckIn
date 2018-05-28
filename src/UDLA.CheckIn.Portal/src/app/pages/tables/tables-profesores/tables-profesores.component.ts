import { Component, ANALYZE_FOR_ENTRY_COMPONENTS } from '@angular/core';
import { LocalDataSource } from 'ng2-smart-table';
import { EmployeeService, EmployeeDto } from '../../../@core/data/api';

@Component({
  selector: 'ngx-tables-profesores-component',
  templateUrl: './tables-profesores.component.html',
  styles: [`
    nb-card {
      transform: translate3d(0, 0, 0);
    }
  `],
})
export class TablesProfesoresComponent {

  settings = {
    actions: {
      add: true,
      edit: true,
      delete: true
    },
    add: {
      addButtonContent: '<i class="nb-plus"></i>',
      createButtonContent: '<i class="nb-checkmark"></i>',
      cancelButtonContent: '<i class="nb-close"></i>',
      confirmCreate:true
    },
    edit: {
      editButtonContent: '<i class="nb-edit"></i>',
      saveButtonContent: '<i class="nb-checkmark"></i>',
      cancelButtonContent: '<i class="nb-close"></i>',
      confirmSave: true
    },
    delete: {
      deleteButtonContent: '<i class="nb-trash"></i>',
      confirmDelete: true,
    },
    columns: {
      id: {
        title: 'Id',
        type: 'Number',
        editable: false,
        addable: false,
      },
      name: {
        title: 'Nombre',
        type: 'string',
      },
      lastName: {
        title: 'Apellido',
        type: 'string',
      },
      facultyId: {
        title: 'Id Facultad',
        type: 'Number',
      }
    },
  };

  source: LocalDataSource = new LocalDataSource();

  constructor(private employeeService: EmployeeService) {
    this.employeeService.apiEmployeeGet().subscribe(data => this.source.load(data))
  }

  onDeleteConfirm(event): void {
    if (window.confirm('Are you sure you want to delete?')) {
      this.employeeService.apiEmployeeByIdDelete(event.data.id).subscribe(event.confirm.resolve());
    } else {
      event.confirm.reject();
    }
  }

  addRecord(event): void {
    if (window.confirm('Are you sure you want to create this element?')) {
      const employee : EmployeeDto = event.newData;
      this.employeeService.apiEmployeePost(employee)
      .subscribe(event.confirm.resolve(), 
      err => console.error(err));
    } else {
      event.confirm.reject();
    }
  }

  editRecord(event): void {
    if (window.confirm('Are you sure you want to edit this element?')) {
      const employee : EmployeeDto = event.newData;
      this.employeeService.apiEmployeePut(employee)
      .subscribe(event.confirm.resolve(), 
                err => console.error(err));
    } else {
      event.confirm.reject();
    }
  }
}
