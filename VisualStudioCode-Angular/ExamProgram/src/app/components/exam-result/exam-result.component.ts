import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { DataResult } from 'src/app/models/DataResult';
import { ExamResult } from 'src/app/models/examResult';

@Component({
  selector: 'app-exam-result',
  templateUrl: './exam-result.component.html',
  styleUrls: ['./exam-result.component.css']
})
export class ExamResultComponent implements OnInit {

  apiUrl:string="https://localhost:44382/api/ExamResult";
  model:ExamResult[];
  success:boolean=false;
  constructor(private httpClient:HttpClient) { }

  ngOnInit(): void {
  }

  getStudents(){
    return this.httpClient.get<DataResult<ExamResult>>(this.apiUrl).subscribe(
      (response)=>{
        this.model=response.data,
        this.success=response.success
      }
    );
  }

}
