import { Component } from '@angular/core';
import { Http } from '@angular/http';

@Component({
    selector: 'employeedata',
    templateUrl: './employeedata.component.html'
})
export class EmployeeDataComponent {

    public employees: employee[];

    constructor(http: Http) {
        http.get('localhost:58934/api/employees').subscribe(result => {
            this.employees = result.json() as employee[];
        }, error => console.error(error));
    }
}

interface employee {
    employeeId: number;
    firstName: string;
    lastName: string;
    phoneNumber: string;
    email: string;
    pesel: string;
    nip: string;
}