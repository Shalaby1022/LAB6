using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB6
{
 
    class TorFQuestion : Question
    {
        public TorFQuestion(int num, string body, int mark) : base(num, body, mark)
        {
        }

        public override void Show()
        {
            Console.WriteLine($"True or False Question {num}: {body} (Marks: {mark})");
            Console.WriteLine();
        }
    }

}
