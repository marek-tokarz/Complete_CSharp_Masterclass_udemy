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

        public void StartQuiz()
        {
            Console.WriteLine("Welcome to the quiz!");
            int questionNumber = 1;

            foreach (Questions questions in questions)
            {
                Console.WriteLine($"Question {questionNumber++}");
                DisplayQuestion(questions);
                int userChoice = GetUserChoice();
                if (questions.IsCorrectAnswer(userChoice))
                {
                    Console.WriteLine("Correct");
                }
                else
                {
                    Console.WriteLine(
                        $"Wrong, the correct answer was: {questions.Answers[questions.CorrectAnswerIndex]}"
                    );
                }
            }
        }

        private void DisplayQuestion(Questions question)
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

        private int GetUserChoice()
        {
            Console.Write("Your answer (number): ");
            string input = Console.ReadLine();
            int choice = 0;
            while (!int.TryParse(input, out choice) || choice < 1 || choice > 4)
            {
                Console.WriteLine("Invalid choice. Please enter a number between 1 and 4: ");
                input = Console.ReadLine();
            }

            return choice - 1;
        }
    }
}
