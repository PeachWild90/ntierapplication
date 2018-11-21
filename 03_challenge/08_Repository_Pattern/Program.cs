using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Repository_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ProgramUI program = new ProgramUI(); //calling a class, making a new instance of this class. "program" is variable
            program.Run(); //cntrl-.-enter automatically makes a Run() method in ProgramUI
        }
    }
}
