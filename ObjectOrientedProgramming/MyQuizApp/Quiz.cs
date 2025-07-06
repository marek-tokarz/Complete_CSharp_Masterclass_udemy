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
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(
                "╔═════════════════════════════════════════════════════════════════════════╗"
            );
            Console.WriteLine(
                "║                                 Question                                ║"
            );
            Console.WriteLine(
                "╚═════════════════════════════════════════════════════════════════════════╝"
            );
            Console.ResetColor();
            Console.WriteLine(question.QuestionText);

            for (int i = 0; i < question.Answers.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("  ");
                Console.Write(i + 1);
                Console.ResetColor();
                Console.WriteLine($". {question.Answers[i]}");
            }
        }
    }
}
