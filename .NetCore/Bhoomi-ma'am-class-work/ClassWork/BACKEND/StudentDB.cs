using ClassWork.Models;
using Microsoft.EntityFrameworkCore;

namespace ClassWork.BACKEND
{
    public class StudentDB:DbContext
    {
        public StudentDB(DbContextOptions<StudentDB>options):base(options)
        {

        }


        public DbSet<StudentModel> student { get; set; }

    }
}
