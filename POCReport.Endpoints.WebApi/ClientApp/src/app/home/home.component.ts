import { HttpClient } from '@angular/common/http';
import { Component, Inject } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {
  public students: Student[];
  public baseUrl: string

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Student[]>(baseUrl + 'student/get/all').subscribe(result => {
      this.students = result;
    }, error => console.error(error));
    this.baseUrl = baseUrl;
  }
}

interface Student {
  id:string;
  firstName: string
  lastName: string
}