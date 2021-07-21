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
            FindTenageRecord(list);
            FindingOutAverage(list);
            SearchSpecificName(list, "siva");
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

        //UC3 - return between 13 to 18 
        public static void FindTenageRecord(List<Person> list)
        {
            Console.WriteLine(" ");
            var result = list.FindAll(p => p.Age > 13 && p.Age < 18);
            foreach (Person person in result)
            {
                Console.WriteLine("SSN = {0}\tName={1}\tAddress = {2}\tAge={3}", person.SSN, person.Name, person.Address, person.Age);
            }

        }
        //UC4 finding the average of age
        public static void FindingOutAverage (List<Person> list)
        { 
             Console.WriteLine(" ");
            var result = list.Average(x => x.Age);
            Console.WriteLine("Average = {0}",result);
          
        }

        //UC5 check for specific name 
        public static void SearchSpecificName(List<Person> list,string name)
        {
            Console.WriteLine(" ");
            var person = list.Find(x => x.Name.Equals(name));
            if (person != null)
                Console.WriteLine("SSN = {0}\tName={1}\tAddress = {2}\tAge={3}", person.SSN, person.Name, person.Address, person.Age);
            else
                Console.WriteLine("{0} is not exists", name);

        }







    }
}


