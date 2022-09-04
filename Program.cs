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
            ushort scoresProgramming = 76;
            ushort scoresMathematics = 80;
            ushort scoresPhysics = 60;

            UInt32 allScores = 0;
            UInt32 averageScore = 0;

            Console.WriteLine($"Ф.И.О: {fullName};\n Возраст: {age};\n Почта: {mail};\n Баллы по программированию: {scoresProgramming};\n" +
                $" Баллы по математике: {scoresMathematics};\n Баллы по физике: {scoresPhysics}");

            Console.ReadLine();

            allScores = (UInt32)(scoresProgramming + scoresMathematics + scoresPhysics);
            averageScore = (UInt32)((scoresProgramming + scoresMathematics + scoresPhysics) / 3);

            Console.WriteLine($"Общий балл: {allScores};\n Средний балл: {averageScore}");

            Console.ReadLine();
        }
    }
}
