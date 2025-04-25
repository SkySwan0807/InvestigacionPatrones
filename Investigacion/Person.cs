using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Investigacion
{
	public class Person
{
    private string name;
    private int age;

	public void PrintData()
	{
		Console.WriteLine($"Nombre: {name}");
		Console.WriteLine($"Edad: {age}");
	}

		private Person() { }

    public static PersonBuilder Builder()
    {
        return new PersonBuilder();
    }

    public class PersonBuilder
    {
        private Person person = new Person();

        public PersonBuilder Name(string name)
        {
            person.name = name;
            return this;
        }

        public PersonBuilder Age(int age)
        {
            person.age = age;
            return this;
        }

        public Person Build()
        {
            return person;
        }
    }
}

}
