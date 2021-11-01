
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamProgramEntities.Entities
{
    public class Lesson
    {
        public string LessonCode { get; set; }
        public string LessonName { get; set; }
        public decimal Class { get; set; }
        public string TeacherName { get; set; }
        public string TeacherSurname { get; set; }
    }
}
