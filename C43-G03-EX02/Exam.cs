using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G03_EX02
{
    internal abstract class Exam
    {
        public double Time_of_exam { get; set; }
        public int Number_of_Questions { get; set; }
        public List<Question> Questions { get; set; } = new List<Question>();
        public abstract void Show_Exam();
    }

    internal class Final_Exam : Exam
    {
        public override void Show_Exam()
        {
            
            foreach (   Question item in Questions)
            {
                Console.WriteLine(item.Body);
                Console.WriteLine($"right answer = {item.AnswerList[item.RightAnswer].AnswerText}");
            }
        }

    }

    internal class Practical_Exam : Exam
    {
        public override void Show_Exam()
        {
            foreach (Question item in Questions)
            {
                Console.WriteLine(item.Body);
                Console.WriteLine($"right answer = {item.AnswerList[item.RightAnswer].AnswerText}");
            }
        }
    }



}
