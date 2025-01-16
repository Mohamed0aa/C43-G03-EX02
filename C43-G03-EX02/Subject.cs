using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G03_EX02
{
    internal class Subject
    {
        public int Subject_Id { get; set; }
        public string Subject_Name { get; set; }
        public Exam Subject_Exam { get; set; }
 
        public Subject(int id, string name)
        {
            Subject_Id = id;
            Subject_Name = name;
        }
        public void Create_Exam (Exam exam)
        {
            Subject_Exam = exam;
        }
      
    }
}
