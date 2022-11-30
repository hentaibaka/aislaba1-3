using System.Collections.Generic;
using System.Linq;
using DALLib;
using StudentLib;

namespace LogicLib
{
    public class Logic
    {
        //public List<StudentLib.Student> Students { set; get; } = new List<Student>();

        IRepository<Student> repository;
        public Logic(IRepository<Student> repositoryS)
        {
            repository = repositoryS;
        }

        public void AddStudent(string name, string speciality, string group)
        {
            //Students.Add(new Student(name, speciality, group));

            repository.Create(new Student(name, speciality, group));
            repository.Save();
        }
        public void DeleteStudent(int id)
        {
            repository.Delete(repository.Get(id));
            repository.Save();

            //Student temp = Students.Find(x => x.Id == id);
            //if (temp != null) Students.Remove(temp);
        }
        public string[,] GetStudents()
        {
            List<Student> Students = new List<Student>(repository.GetAll());

            string[,] Out = new string[Students.Count, 4];

            for (int i = 0; i < Students.Count; i++)
            {
                Out[i, 0] = Students[i].Id.ToString();
                Out[i, 1] = Students[i].Name;
                Out[i, 2] = Students[i].Speciality;
                Out[i, 3] = Students[i].Group;
            }

            return Out;
        }
        public string[,] GetStat()
        {
            List<Student> Students = new List<Student>(repository.GetAll());

            List<string> sp = new List<string>();

            for (int i = 0; i < Students.Count; i++)
            {
                if (!sp.Contains(Students[i].Speciality)) sp.Add(Students[i].Speciality);
            }

            string[,] Out = new string[sp.Count, 2];

            for (int i = 0; i < sp.Count; i++)
            {
                Out[i, 0] = sp[i];
                Out[i, 1] = Students.FindAll(x => x.Speciality == sp[i]).Count.ToString();
            }

            return Out;
        }
        public string[] GetStudent(int id)
        {
            Student student = repository.Get(id);

            if (student != null) return new string[4] { student.Id.ToString(), student.Name, student.Speciality, student.Group };
            return new string[4];
        }
    }
}
