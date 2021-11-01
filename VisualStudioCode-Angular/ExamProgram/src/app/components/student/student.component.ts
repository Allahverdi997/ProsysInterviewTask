import { Component, OnInit } from '@angular/core';

import { HttpClient } from '@angular/common/http';
import { Student } from 'src/app/models/student';
import { DataResult } from 'src/app/models/DataResult';

@Component({
  selector: 'app-student',
  templateUrl: './student.component.html',
  styleUrls: ['./student.component.css']
})
export class StudentComponent implements OnInit {

  apiUrl:string="https://localhost:44382/api/Student";
  model:Student[];
  success:boolean=false;
  constructor(private httpClient:HttpClient) { }

  ngOnInit(): void {
  }

  getStudents(){
    return this.httpClient.get<DataResult<Student>>(this.apiUrl).subscribe(
      (response)=>{
        this.model=response.data,
        this.success=response.success
      }
    );
  }
}
