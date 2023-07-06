using System;
namespace PatronesEstructurales
{
    public class Subsystem1
    {
        public string operation1()
        {
            return "Subsystem1: Ready!\n";
        }

        public string operationN()
        {
            return "Subsystem1: Go!\n";
        }
    }

    // Some facades can work with multiple subsystems at the same time.
    public class Subsystem2
    {
        public string operation2()
        {
            return "Subsystem2: Get ready!\n";
        }

        public string operationZ()
        {
            return "Subsystem2: Fire!\n";
        }
    }

    public class Facade
	{

        Subsystem1 subsystem1 = new Subsystem1();
        Subsystem2 subsystem2 = new Subsystem2();


		public Facade()
		{
		}

        public void Operation12() {
            subsystem1.operation1();
            subsystem2.operation2();
        }

        public void Operation1Z()
        {
            subsystem1.operation1();
            subsystem2.operationZ();
        }

        public void Operation2N()
        {
            subsystem2.operation2();
            subsystem1.operationN();
            
        }
    }
}

