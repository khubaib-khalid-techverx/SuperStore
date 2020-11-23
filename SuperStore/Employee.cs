using System;
namespace ObjectAndClasses
{
	public class Employee
	{
		private int id;
		private string name;
		private int age;
		public Employee(int id, string name, int age)
		{
			this.id = id;
			this.name = name;
			this.age = age;

		}
		public void show()
		{
			Console.WriteLine(id + " " + name + " " + age);
		}

	}
}