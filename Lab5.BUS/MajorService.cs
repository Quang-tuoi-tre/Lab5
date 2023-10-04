using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab5.DAL.NewFolder1;
namespace Lab5.BUS
{
    public class MajorService
    {
        public List<Major> GetAllByFaculty(int facultyID)
        {
            StudentModel context = new StudentModel();
            return context.Majors.Where(p => p.FacultyID == facultyID).ToList();
        }
    }
}
