import { Component } from '@angular/core';
import { FacultyService } from '../../@core/data/api';

@Component({
  selector: 'ngx-dashboard',
  styleUrls: ['./dashboard.component.scss'],
  templateUrl: './dashboard.component.html',
})
export class DashboardComponent {
  constructor(private facultyService: FacultyService) {
      
    this.facultyService.apiFacultyGet().subscribe(
      s => console.log(s)
    );
      
   }
}
