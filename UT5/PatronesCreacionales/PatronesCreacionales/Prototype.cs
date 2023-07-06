using System;
namespace PatronesCreacionales
{

    public class IdInfo
    {
        public int IdNumber;

        public IdInfo(int idNumber)
        {
            this.IdNumber = idNumber;
        }
    }

    public class Persona {
		public int Age;
		public DateTime BirthDate;
		public string Name;
		public IdInfo IdInfo;


		public Persona() {

		}
		public Persona ShallowCopy() {
			return (Persona)this.MemberwiseClone();
		}

		public Persona DeepCopy() {
			Persona clone = (Persona)this.MemberwiseClone();
			clone.IdInfo = new IdInfo(IdInfo.IdNumber);
			clone.Name = String.Copy(Name);
			return clone;
		}
	}
}

