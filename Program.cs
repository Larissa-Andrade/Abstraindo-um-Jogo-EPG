using Projeto.src.Entities;
using static System.Console;

namespace Projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus ", 23, "Knight");
            Wizard wizard = new Wizard("Jennica ", 23, "White Wizard");
            Wizard blackWizard = new Wizard("Topapa ", 23, "Black Wizard");
            Ninja ninja = new Ninja("Wedge ", 23, "Ninja");

            WriteLine(arus.Attack());
            WriteLine(wizard.Attack(7));
            WriteLine(blackWizard.Attack(1));
            WriteLine(ninja.Attack());

        }
    }

   
}
