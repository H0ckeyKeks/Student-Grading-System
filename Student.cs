using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Grading_System
{
    internal class Student
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private int _rollNo;
        public int RollNo
        {
            get { return _rollNo; }
            set { _rollNo = value; }
        }

        private List<double> _grades;

        public List<double> Grades
        {
            get { return _grades; }
            set { _grades = value; }
        }

        public Student(string name, int rollNo)
        {
            Name = name;
            RollNo = rollNo;
            Grades = new List<double>();
        }

        public void AddGrade(double grade)
        {
            Grades.Add(grade);
        }

        public double CalculateAverageGrade()
        {
            if (Grades.Count == 0)
            {
                return 0;
            }
            
            double sumGrades = 0;

            foreach (double item in Grades)
            {
                sumGrades += item;
            }

            double average = sumGrades / Grades.Count;

            return average;
        }

        public double GetHighestGrade()
        {
            if (Grades.Count == 0)
            {
                return 0;
            }
            
            double highest = 0;

            foreach (double item in Grades)
            {
                if (item > highest)
                {
                    highest = item;
                }
            }

            return highest;
        }

        public double GetLowestGrade()
        {
            if (Grades.Count == 0)
            {
                return 0;
            }
            
            double lowest = 0;

            foreach (double item in Grades)
            {
                if (item < lowest)
                {
                    lowest = item;
                }
            }

            return lowest;
        }

        public string PrintOutput()
        {
            return String.Format($"Name: {Name}, RollNo: {RollNo}, Average Grade: {CalculateAverageGrade()}");
        }
    }
}
