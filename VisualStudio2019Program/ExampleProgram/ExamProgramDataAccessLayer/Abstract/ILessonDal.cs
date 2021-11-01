using ExamProgramCoreLayer.DataAccessLayer.EntityFrameworkCore.Abstract;
using ExamProgramEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamProgramDataAccessLayer.Abstract
{
    public interface ILessonDal:IEntityRepository<Lesson>
    {
    }
}
