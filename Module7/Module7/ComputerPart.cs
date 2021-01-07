using System;
using System.Collections.Generic;
using System.Text;

namespace Module7
{
    abstract class ComputerPart
    {
        public abstract void Work();
    }

    class Processor : ComputerPart
    {
        public override void Work() { }
    }

    class MotherBoard : ComputerPart
    {
        public override void Work() { }
    }

    class GraphicCard : ComputerPart
    {
        public override void Work() { }
    }
}
