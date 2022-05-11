using System;
using JogoAbst.src.Entities;

namespace JogoAbst
{
    class Program
    {
        static void Main(string[] args)
        {
            Knigth knigth = new Knigth("Arus", 12, "Knigth");
            Wizard wizard = new Wizard("Jennica", 15, "White Wizard");
            Vampire vampire = new Vampire("Alucard", 20, "Vampire");
            Hunter hunter = new Hunter("Growth", 8, "Hunter");

            Console.WriteLine($"{knigth.name} and {hunter.name} VS {vampire.name} and {wizard.name}");
            Console.WriteLine($@"
            **** Card Heroes ****
            Name - Level - Type
            {knigth}
            {hunter}
            {vampire}
            {wizard}            
            ");


            Console.WriteLine(knigth.Attack());
            Console.WriteLine(wizard.Attack(2));
            Console.WriteLine(wizard.Attack(7));
            Console.WriteLine(vampire.Attack());
            Console.WriteLine(hunter.Attack(5));

        }
    }
}
