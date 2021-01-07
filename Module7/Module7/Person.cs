using System;
using System.Collections.Generic;
using System.Text;

namespace Module7
{
    abstract class Person
    {
        public string Name;

        public Person(string name)
        {
            Name = name;
        }

        public void DisplayName()
        {
            Console.WriteLine(Name);
        }
    }

    class Employee1 : Person
    {
        // Булевый флаг, сообщающий, находится ли сотрудник на смене
        public bool IsOnShift;

        public Employee1(string name, bool isOnShift) : base(name)
        {
            IsOnShift = isOnShift;
        }
    }

    class Guest : Person
    {
        // Дата и время прибытия гостя
        public DateTime ArrivalDate;

        public Guest(string name, DateTime arrivalDate) : base(name)
        {
            ArrivalDate = arrivalDate;
        }
    }
}
