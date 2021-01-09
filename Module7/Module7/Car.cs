using System;
using System.Collections.Generic;
using System.Text;

namespace Module7
{
    class Car<TEngine> where TEngine : TypeEngine
    {
        public TEngine Engine;

        public virtual void ChangePart<TPart>(TPart newPart) where TPart : TypePart
            {

            }
    }

    class ElectricCar: Car<ElectricEngine>
    {
        public override void ChangePart<TPart>(TPart newPart)
        {

        }
    }

    class GasCar:Car<GasEngine>
    {
        public override void ChangePart<TPart>(TPart newPart)
        {

        }
    }

    abstract class TypeEngine
    {

    }
	
	class ElectricEngine: TypeEngine
    {

    }

	class GasEngine: TypeEngine
    {

    }

    abstract class TypePart
    {

    }

    class Battery: TypePart
    {

    }

    class Differential: TypePart
    {

    }

    class Wheel: TypePart
    {

    }
}
