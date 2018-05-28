import { Component } from '@angular/core';
import { LocalDataSource } from 'ng2-smart-table';
import { FacultyService, FacultyDto, EmployeeService, EntryRecordDto } from '../../../@core/data/api';

@Component({
  selector: 'ngx-tables-entries-component',
  templateUrl: './tables-entries.component.html',
  styles: [`
    nb-card {
      transform: translate3d(0, 0, 0);
    }
  `],
})

export class TablesEntriesComponent {

  settings = {
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
        title: 'ID',
        type: 'number',
        editable: false,
        addable: false
      },
      dateCreated: {
        title: 'Fecha Ingreso',
        type: 'date',
      },
      employeeId: {
          title: 'ID Empleado',
          type: 'number'
      }
    },
  };

  source: LocalDataSource = new LocalDataSource();

  constructor(private employeeService: EmployeeService) {
    this.employeeService.apiEmployeeGet()
        .subscribe(employees => {
            let entryRecords : EntryRecordDto[] = [];
            employees.forEach(e => this.employeeService.apiEmployeeByEmployeeIdEntryrecordsGet(e.id)
                .subscribe(entries => {
                    entryRecords.push(...entries);
                    console.log(entryRecords);
                    this.source.load(entryRecords);
                }));
            });
  }

  onDeleteConfirm(event): void {
    if (window.confirm('Are you sure you want to delete?')) {
    } else {
      event.confirm.reject();
    }
  }

  addRecord(event): void {
    if (window.confirm('Are you sure you want to create this element?')) {
    } else {
      event.confirm.reject();
    }
  }

  editRecord(event): void {
    if (window.confirm('Are you sure you want to edit this element?')) {
    } else {
      event.confirm.reject();
    }
  }
}
