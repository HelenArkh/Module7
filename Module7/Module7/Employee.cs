using System;
using System.Collections.Generic;
using System.Text;

namespace Module7
{
    class Employee
    {
        public string Name;
        public int Age;
        public int Salary;
    }

    class ProjectManager : Employee
    {
        public string ProjectName;


    }

    class Developer : Employee
    {
        public string ProgrammingLanguage;

    }
}
