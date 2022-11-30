using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicLib;
using Ninject;
namespace DecanatProConsole
{
    internal class Program
    {
        static IKernel ninjectKernel = new StandardKernel(new SimpleConfigModule());
        static private Logic logic = ninjectKernel.Get<Logic>();

        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Добавить студента: 1 | Удалить студента: 2 | Вывести список студентов: 3 | Вывести студента по Id: 4| Вывести распределение студентов по специальностям: 5 | Выйти: 0");

                string a = Console.ReadLine();

                switch (a)
                {
                    case "1":
                        AddStudent();
                        break;
                    case "2":
                        DeleteStudent();
                        break;
                    case "3":
                        ShowStudents();
                        break;
                    case "4":
                        ShowStudent();
                        break;
                    case "5":
                        StudentStat();
                        break;
                    case "0":
                        return;
                }

                Console.WriteLine();
            }
        }
        static private string[] NewStudent()
        {
            string[] Out = new string[3];

            Console.Write("Введите ФИО: ");
            Out[0] = Console.ReadLine();

            Console.Write("Введите специальность: ");
            Out[1] = Console.ReadLine();

            Console.Write("Введите Группу: ");
            Out[2] = Console.ReadLine();

            return Out;
        }
        static private void AddStudent()
        {
            string[] s = NewStudent();

            logic.AddStudent(s[0], s[1], s[2]);
        }
        static private void DeleteStudent()
        {
            Console.Write("Введите id Студента: ");

            try
            {
                int s = Int32.Parse(Console.ReadLine());

                logic.DeleteStudent(s);

            }
            catch (Exception e)
            {
                Console.WriteLine("not int try again");
            }
        }
        static private void ShowStudents()
        {
            string[,] s = logic.GetStudents();

            for (int i = 0; i < s.GetLength(0); i++)
            {
                Console.WriteLine($"id: {s[i, 0]} | ФИО: {s[i, 1]} | Специальность: {s[i, 2]} | Группа: {s[i, 3]}");
            }
        }
        static private void ShowStudent()
        {
            Console.Write("Введите Id: ");
            string temp = Console.ReadLine();

            int id; 
            if(Int32.TryParse(temp, out id))
            {
                string[] s = logic.GetStudent(id);

                Console.WriteLine($"id: {s[0]} | ФИО: {s[1]} | Специальность: {s[2]} | Группа: {s[3]}");
            }
        }
        static private void StudentStat()
        {
            string[,] s = logic.GetStat();

            for (int i = 0; i < s.GetLength(0); i++)
            {
                Console.WriteLine($"{s[i, 0]}: {s[i, 1]}");
            }
        }
    }
}
