using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace LAB6
{
        abstract class Question
        {
            protected int num;
            protected string body;
            protected int mark;

            public Question() : this(0, "", 0) 
            {
            }

            public Question(int num, string body, int mark)
            {
                this.num = num;
                this.body = body;
                this.mark = mark;
            }

            public abstract void Show();
        }
    }

