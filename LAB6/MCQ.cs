using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB6
{
  
        class MCQQuestion : Question
        {
            private string[] answers;

            public MCQQuestion(int num, string body, int mark, string[] answers) : base(num, body, mark)
            {
                this.answers = answers;
            }

            public string[] Answers
            {
                get { return answers; }
                set { answers = value; }
            }


            public override void Show()
            {
                Console.WriteLine($"MCQ Question {num}: {body} (Marks: {mark})");
                Console.WriteLine("Answers:");
                foreach (var answer in answers)
                {
                    Console.WriteLine(answer);
                }
                Console.WriteLine();
            }
        }

    }

