using System;
using System.Collections.Generic;
using System.Text;

namespace Module7
{
    class Car
    {
		public int Mileage;

		public Car()
		{
			Mileage = 0;
		}

		public virtual void Move()
		{
			Console.WriteLine("Вызван метод Move класса Car");
			Mileage++;
		}
	}
	enum FuelType
	{
		Gas = 0,
		Electricity
	}

	class HybridCar : Car
	{
		public FuelType FuelType;

		public double Gas;

		public double Electricity;

		public HybridCar()
		{
			Electricity = 50;
			Gas = 50;
		}

		public override void Move()
		{
			base.Move();
			Console.WriteLine("Вызван метод Move класса HybridCar");

			switch (FuelType)
			{
				case FuelType.Gas:
					Gas -= 0.5;
					break;
				case FuelType.Electricity:
					Electricity -= 0.5;
					break;
			}
		}

		public void ChangeFuelType(FuelType type)
		{
			FuelType = type;
		}
	}
}
