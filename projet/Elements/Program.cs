using System;
using Element;
using System.Text;
using static System.Console;
using Modele;
using System.Collections.Generic;
using System.Linq;
using Test;

namespace Elements
{
    class Program
    {


        static void Main(string[] args)
        {
            Manager MonManager = new Manager(new Stub.Stub());
            TestManager testmanager = new TestManager();
            TestClassAnnecdote testannecdote = new TestClassAnnecdote();
            testQuizz méthodetestmquizz = new testQuizz();
            TestClassAstreEtSesFille méthodetestastre = new TestClassAstreEtSesFille();
            int b;
            Console.WriteLine("test des class:");
            Console.WriteLine("1 Tester les méthodes de Manager");
            Console.WriteLine("2 Tester les méthodes de Ancecdote");
            Console.WriteLine("3 Tester les méthodes de Quizz");
            Console.WriteLine("4 Tester les méthodes de ");


            Console.WriteLine("choisissez la class que vous voulez tester.");
            Console.WriteLine("tapez une lettre si vous voulez arreter.");
            string a = Console.ReadLine();
            if (a.All(char.IsDigit))
            {
                b = int.Parse(a);
                while (b == 0 | b > 4)
                {
                    Console.WriteLine("il n'y a que 4 choix possible!");
                    a = Console.ReadLine();
                    b = int.Parse(a);
                }
            }
            b = int.Parse(a);
            while (a.All(char.IsDigit))
            {
                switch (b)
                {
                    case 1:
                        testmanager.méthodetestmanager();
                        break;
                    case 2:
                        testannecdote.méthodetestannecdote();
                        break;
                    case 3:
                        méthodetestmquizz.méthodetestmquizz();
                        break;
                    case 4:
                        méthodetestastre.méthodetestAstreEtFille();
                        break;


                }
                Console.WriteLine("choisissez la class que vous voulez tester.");
                Console.WriteLine("tapez une lettre si vous voulez arreter.");
                a = Console.ReadLine();
                if (a.All(char.IsDigit))
                {
                    b = int.Parse(a);
                    while (b == 0 | b > 4)
                    {
                        Console.WriteLine("il n'y a que 4 choix possible!");
                        a = Console.ReadLine();
                        b = int.Parse(a);
                    }
                }
                else
                {
                    break;
                }
            }
        }

    }
}