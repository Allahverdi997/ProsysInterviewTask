import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { DataResult } from 'src/app/models/DataResult';
import { Lesson } from 'src/app/models/lesson';

@Component({
  selector: 'app-lesson',
  templateUrl: './lesson.component.html',
  styleUrls: ['./lesson.component.css']
})
export class LessonComponent implements OnInit {

  apiUrl:string="https://localhost:44382/api/Lesson";
  model:Lesson[];
  success:boolean=false;
  constructor(private httpClient:HttpClient) { }

  ngOnInit(): void {
  }

  getStudents(){
    return this.httpClient.get<DataResult<Lesson>>(this.apiUrl).subscribe(
      (response)=>{
        this.model=response.data,
        this.success=response.success
      }
    );
  }

}
