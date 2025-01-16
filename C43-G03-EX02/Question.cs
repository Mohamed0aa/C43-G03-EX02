using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G03_EX02
{
    internal class Question
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public double Mark { get; set; }
        public List<Answers> AnswerList { get; set; }
        public int RightAnswer { get; set; }
        public Question()
        {
            Header = string.Empty;
            Body = string.Empty;
            AnswerList = new List<Answers>(10);
        }
    }

    class Mcq : Question
    {
        public override string ToString()
        {
            return $"{AnswerList[RightAnswer]}";
        }
    }

    class True_False : Question
    { }


}
