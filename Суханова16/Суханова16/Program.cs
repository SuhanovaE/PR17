using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Суханова16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Практическая работа №17");
            Console.WriteLine("Выполнила: студентка группы ИСП.20А");
            Console.WriteLine("Суханова Екатерина");
            Console.WriteLine("Вариант №3");
            Console.WriteLine();
            List<STUDENT> students = new List<STUDENT>();
            StreamReader sr = new StreamReader(@"Input.txt");
            while (!sr.EndOfStream)
            {
                string[] info = sr.ReadLine().Split(',');
                STUDENT studentFile = new STUDENT()
                {
                    FIO = info[0],
                    Group = info[1],
                    Math = int.Parse(info[2]),
                    English = int.Parse(info[3]),
                    Physics = int.Parse(info[4]),
                    Biology = int.Parse(info[5]),
                    Chemistry = int.Parse(info[6])
                };
                students.Add(studentFile);
                Console.WriteLine($"Фамилия и имя студента: {info[0]} \nГруппа: {info[1]}" +
                    $"\nМатематика: {info[2]} \nАнглийский язык: {info[3]}" +
                    $"\nФизика: {info[4]} \nБиология: {info[5]}"+
                    $"\nХимия: {info[6]}");
            }
            Console.WriteLine("Введите количество студентов:");
            int N = int.Parse(Console.ReadLine());                        
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"Введите оценки по предметам студента №{i + 1}.");
                Console.Write("Введите фамилию и имя: ");
                string fio = Console.ReadLine();
                Console.Write("Введите группу: ");
                string group = Console.ReadLine();
                Console.Write("Оценка по математике: ");
                int math = int.Parse(Console.ReadLine());
                Console.Write("Оценка по английскому языку: ");
                int english = int.Parse(Console.ReadLine());
                Console.Write("Оценка по физике: ");
                int physics = int.Parse(Console.ReadLine());
                Console.Write("Оценка по биологии: ");
                int biology = int.Parse(Console.ReadLine());
                Console.Write("Оценка по химии: ");
                int chemistry = int.Parse(Console.ReadLine());
                STUDENT student = new STUDENT()
                {
                    FIO = fio,
                    Group = group,
                    Math = math,
                    English = english,
                    Physics = physics,
                    Biology = biology,
                    Chemistry = chemistry
                };
                students.Add(student);
            }
            Console.WriteLine();
            bool flag = false;
            Console.WriteLine("Студенты, у которых есть хотя бы одна 2");
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].English == 2 || students[i].Math == 2 || students[i].Biology == 2 || students[i].Chemistry == 2 || students[i].Physics == 2 )
                {
                    Console.WriteLine(students[i].PrintInfo());
                    students[i].Save();
                    flag = true;
                }               
            }
            if (flag==false)
                Console.WriteLine("нет студентов, у которых есть 2");
            Console.ReadKey();
        }
    }
}
