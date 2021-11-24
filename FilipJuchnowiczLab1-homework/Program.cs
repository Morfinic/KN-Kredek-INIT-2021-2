using System;

namespace FilipJuchnowiczLab1_homework
{
    class Program
    {
        static void Main(string[] args)
        {
            //* Zad. 1
            string string1;
            float num1;

            Console.WriteLine("Podaj wartosc tekstowa i liczbowa");
            string1 = Console.ReadLine();
            num1 = float.Parse(Console.ReadLine());

            Console.WriteLine($"Zmienna tekstowa: {string1}, zmienna liczbowa: {num1}");

            //* Zad. 2
            float CalcNum1, CalcNum2;

            Console.WriteLine("\nPodaj dwie liczby na ktorych zostana wykonane podstawowe operacje matematyczne");
            CalcNum1 = float.Parse(Console.ReadLine());
            CalcNum2 = float.Parse(Console.ReadLine());

            Console.WriteLine($"Wyniki:\n{CalcNum1} + {CalcNum2} = {CalcNum1 + CalcNum2}");
            Console.WriteLine($"{CalcNum1} - {CalcNum2} = {CalcNum1 - CalcNum2}");
            Console.WriteLine($"{CalcNum1} * {CalcNum2} = {CalcNum1 * CalcNum2}");
            Console.WriteLine($"{CalcNum1} / {CalcNum2} = {CalcNum1 / CalcNum2}");
        }
    }
}
