export * from './employee.service';
import { EmployeeService } from './employee.service';
export * from './faculty.service';
import { FacultyService } from './faculty.service';
export const APIS = [EmployeeService, FacultyService];
