using ExamProgramCoreLayer.DataAccessLayer.EntityFrameworkCore;
using ExamProgramCoreLayer.DataAccessLayer.EntityFrameworkCore.Concrete;
using ExamProgramDataAccessLayer.Abstract;
using ExamProgramEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamProgramDataAccessLayer.Concrete
{
    public class StudentDal:EntityRepository<Student>,IStudentDal
    {
        public StudentDal(ExamProgramDbContext context):base(context)
        {

        }
    }
}
