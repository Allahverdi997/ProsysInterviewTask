import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ExamResultComponent } from './components/exam-result/exam-result.component';
import { LessonComponent } from './components/lesson/lesson.component';
import { StudentComponent } from './components/student/student.component';

const routes: Routes = [
  {path:"",component:LessonComponent,pathMatch:"full"},
  {path:"student",component:StudentComponent},
  {path:"exam",component:ExamResultComponent},
  {path:"lesson",component:LessonComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
