using System;
using System.Collections.Generic;

namespace PersonalDataManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Personal Data Management!");
            List<Person> list = new List<Person>();
            AddingPersonDetails(list);


        }
        public static void AddingPersonDetails(List<Person> list)
        {
            list.Add(new Person() { SSN = 1, Name = "siva",    Age = 12, Address = "Bangaluru",  });
            list.Add(new Person() { SSN = 2, Name = "Ranjani", Age = 14, Address = "kerela", });
            list.Add(new Person() { SSN = 3, Name = "bala",    Age = 18, Address = "madurai",  });
            list.Add(new Person() { SSN = 4, Name = "karthi",  Age = 65, Address = "chennai", });

            foreach (Person person in list)
            {
                Console.WriteLine("SSn = {0}\tName={1}\tAddress = {2}\tAge={3}", person.SSN, person.Name, person.Address, person.Age);
            }
        }

    }
}


