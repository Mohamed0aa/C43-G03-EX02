using System;

namespace C43_G03_EX02
{
    internal class Program
    {
        static void Main()
        {
            Answers answers = new Answers();
            Question question = new Question();
            Exam exam=new Practical_Exam();


            Subject subject = new Subject(1,"math");
            exam.Time_of_exam = 40;
            exam.Number_of_Questions = 2;
            int co=exam.Number_of_Questions;

            question.Header = "mcq";
            question.Body = "1+2 ?";
            question.Mark = 3;

            answers.AnswerId = 1;
            answers.AnswerText = "3";
            question.AnswerList.Add(answers);
            answers = new Answers();
            answers.AnswerId = 2;
            answers.AnswerText = "4";
            question.AnswerList.Add(answers);

            answers.AnswerId = 3;
            answers.AnswerText = "5";
            question.AnswerList.Add(answers);
            answers = new Answers();

            answers.AnswerId = 4;
            answers.AnswerText = "6";

            question.AnswerList.Add(answers);
            answers = new Answers();

            exam.Questions.Add(question);
            question.RightAnswer = 0;

            question.RightAnswer = 0;

            //q2
            Question question2=new Question();
            Answers answers1 = new Answers();
            question2.AnswerList.Add(new Answers { AnswerId = 1, AnswerText = "3" });

            question2.Header = "mcq";
            question2.Body = "3+2 ?";
            question2.Mark = 3;

            answers1.AnswerId = 1;
            answers1.AnswerText = "1";
            question2.AnswerList.Add( answers1);
            answers1=new Answers();

            answers1.AnswerId = 2;
            answers1.AnswerText = "4";
            question2.AnswerList.Add(answers1);
            answers1 = new Answers();

            answers1.AnswerId = 3;
            answers1.AnswerText = "5";
            question2.AnswerList.Add(answers1);
            answers1 = new Answers();

            answers1.AnswerId = 4;
            answers1.AnswerText = "6";
            answers1 = new Answers();

            question2.RightAnswer = 3;

            exam.Questions.Add(question2);

            subject.Create_Exam(exam);


            for(int i = 0; i < co; i++)
            {
                Console.WriteLine(subject.Subject_Exam.Questions[i].Body);
                string Ans=Console.ReadLine();
            }

            Console.WriteLine("finish");
            subject.Subject_Exam.Show_Exam();













        }
    }
}
