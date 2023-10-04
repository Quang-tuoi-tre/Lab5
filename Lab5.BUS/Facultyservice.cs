using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab5.DAL.NewFolder1;

namespace Lab5.BUS
{
    public class Facultyservice
    {
        public List<Faculty> GetAll()
        {
            StudentModel context = new StudentModel();
            return context.Faculties.ToList();

        }
    }
}
