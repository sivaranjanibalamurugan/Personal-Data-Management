using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonalDataManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Personal Data Management!");
            List<Person> list = new List<Person>();
            AddingPersonDetails(list);
            RetrieveTopTwoLessThanSixty(list);
            Console.ReadLine();


        }
        //UC1 adding the details 
        public static void AddingPersonDetails(List<Person> list)
        {
            list.Add(new Person() { SSN = 1, Name = "siva",    Age = 72, Address = "Bangaluru",  });
            list.Add(new Person() { SSN = 2, Name = "Ranjani", Age = 14, Address = "kerela", });
            list.Add(new Person() { SSN = 3, Name = "bala",    Age = 18, Address = "madurai",  });
            list.Add(new Person() { SSN = 4, Name = "karthi",  Age = 65, Address = "chennai", });

            foreach (Person person in list)
            {
                Console.WriteLine("SSN = {0}\tName={1}\tAddress = {2}\tAge={3}", person.SSN, person.Name, person.Address, person.Age);
            }
        }

        //Uc2- retrieve top two less than age 0f 60
        public static void RetrieveTopTwoLessThanSixty(List<Person> list)
        {
            Console.WriteLine(" ");
            List<Person> result = list.FindAll(p=>p.Age<60).OrderBy(x =>x.Age).Take(2).ToList();

            foreach (Person person in result)
            {
                Console.WriteLine("SSN = {0}\tName={1}\tAddress = {2}\tAge={3}", person.SSN, person.Name, person.Address, person.Age);
            }
        }

    }
}


