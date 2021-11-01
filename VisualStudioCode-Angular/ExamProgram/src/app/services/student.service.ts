import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { DataResult } from '../models/DataResult';
import { Student } from '../models/student';

@Injectable({
  providedIn: 'root'
})
export class StudentService {


  constructor(private httpClient:HttpClient) { }

}
