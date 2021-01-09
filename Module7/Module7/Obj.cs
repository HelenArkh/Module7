using System;
using System.Collections.Generic;
using System.Text;

namespace Module7
{
    class Obj
    {
		public string Name;
		public string Description;

		public static string Parent;
		public static int DaysInWeek;
		public static int MaxValue;

		static Obj()
		{
			Parent = "System.Object";
			DaysInWeek = 7;
			MaxValue = 2000;
		}


	}

	class BaseClass
	{
		protected string Name;

		public BaseClass(string name)
		{
			Name = name;
		}

		public virtual int Counter
		{
			get;
			set;
		}

		public virtual void Display()
		{
			Console.WriteLine("Метод класса BaseClass");
		}
	}

	class DerivedClass : BaseClass
	{
		public string Description;

		private int counter;

		public override int Counter 
		{
			get
			{
				return counter;
			}
			set
			{
				if (value < 0)
				{
					Console.WriteLine("Нельзя заносить числа меньше 0");
				}
				else
				{
					counter = value;
				}
			}
		}

		public DerivedClass(string name, string description) : base(name)
		{
			Description = description;
		}

		public DerivedClass(string name, string description, int counter) : this(name, description)
		{
			Counter = counter;
		}

		public override void Display()
		{
			base.Display();
			Console.WriteLine("Метод класса DerivedClass");
		}

	}
}
