import { Component } from '@angular/core';
import { LocalDataSource } from 'ng2-smart-table';
import { FacultyService, FacultyDto } from '../../../@core/data/api';

@Component({
  selector: 'ngx-tables-facultades-component',
  templateUrl: './tables-facultades.component.html',
  styles: [`
    nb-card {
      transform: translate3d(0, 0, 0);
    }
  `],
})
export class TablesFacultadesComponent {

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
      name: {
        title: 'Nombre',
        type: 'string',
      }
    },
  };

  source: LocalDataSource = new LocalDataSource();

  constructor(private facultyService: FacultyService) {
    this.facultyService.apiFacultyGet().subscribe(data => this.source.load(data))
  }

  onDeleteConfirm(event): void {
    if (window.confirm('Are you sure you want to delete?')) {
      this.facultyService.apiFacultyByIdDelete(event.data.id).subscribe(event.confirm.resolve());
    } else {
      event.confirm.reject();
    }
  }

  addRecord(event): void {
    if (window.confirm('Are you sure you want to create this element?')) {
      const faculty : FacultyDto = event.newData;
      this.facultyService.apiFacultyPost(faculty)
      .subscribe(event.confirm.resolve(), 
      err => console.error(err));
    } else {
      event.confirm.reject();
    }
  }

  editRecord(event): void {
    if (window.confirm('Are you sure you want to edit this element?')) {
      const faculty : FacultyDto = event.newData;
      this.facultyService.apiFacultyPut(faculty)
      .subscribe(event.confirm.resolve(), 
                err => console.error(err));
    } else {
      event.confirm.reject();
    }
  }
}
