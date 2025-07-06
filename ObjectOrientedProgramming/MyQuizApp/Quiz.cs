using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQuizApp
{
    internal class Quiz
    {
        private Questions[] questions;

        public Quiz(Questions[] questions)
        {
            this.questions = questions;
        }

        public void DisplayQuestion(Questions question)
        {
            Console.WriteLine(question.QuestionText);
        }
    }
}
