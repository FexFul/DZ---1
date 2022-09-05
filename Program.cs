using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ___1
{
    class Program
    {
        static void Main(string[] args)
        {
            String fullName = "Степанович Степан Степанов";
            ushort age = 22;
            String mail = @"StepanSuper@gmail.com";
            double scoresProgramming = 76.2;
            double scoresMathematics = 80.12;
            double scoresPhysics = 60.3;

            Console.WriteLine($"Ф.И.О: {fullName};\n Возраст: {age};\n Почта: {mail};\n Баллы по программированию: {scoresProgramming};\n" +
                $" Баллы по математике: {scoresMathematics};\n Баллы по физике: {scoresPhysics}");

            Console.ReadLine();

            double allScores = 0;
            double averageScore = 0;

            allScores = (scoresProgramming + scoresMathematics + scoresPhysics);
            averageScore = (scoresProgramming + scoresMathematics + scoresPhysics) / 3;

            Console.WriteLine($"Общий балл: {allScores};\n Средний балл: {averageScore}");

            Console.ReadLine();
        }
    }
}
