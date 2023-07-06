using System;
namespace PatronesEstructurales
{

	public interface ISubject {
		void Request();
	}

    public class RealSubject : ISubject
    {
        public void Request()
        {
            Console.WriteLine("RealSubject: Handling Request.");
        }
    }

    public class Proxy : ISubject
	{

        private RealSubject realSubject;

		public Proxy(RealSubject realSubject)
		{
            this.realSubject = realSubject;
		}

        public bool CheckAccess() {
            Console.WriteLine("Proxy: Checking access prior to firing a real request.");

            return true;
        }

        public void LogAccess() {

            Console.WriteLine("Proxy: Logging the time of request.");
        }

        public void Request()
        {
            if (this.CheckAccess() ){
                this.realSubject.Request();
                this.LogAccess();
            }
        }
    }
}

