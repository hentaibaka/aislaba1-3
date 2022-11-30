﻿namespace StudentLib
{
    public class Student : IDomainObject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Speciality { get; set; }
        public string Group { get; set; }
        public Student(string name, string speciality, string group)
        {
            Name = name;
            Speciality = speciality;
            Group = group;
        }
        public Student() { }
    }
}
