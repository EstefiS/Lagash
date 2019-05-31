using System;
using System.Collections.Generic;
using System.Text;
using PersonRepository.Entities;
using PersonRepository.Interfaces;
using System.Linq;
using System.Text.RegularExpressions;
using System.ComponentModel.DataAnnotations;
using PersonValidator;
using PersonRepository;


namespace PersonValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new ValidatorTest();
            var people = new Ejer();
            test.Validate(people);
            //Person pe = new Person();
            //pe.Id = 21;
            //pe.Name = "pablo Garcia";
            //pe.Age = 22;
            //pe.Email = "pepeg@mail.com";
            //var people = new Ejer();

            //people.Add(pe);
            //Person pe2 = new Person();
            //pe2.Id = 3;
            //pe2.Name = "pablo sedes";
            //pe2.Age = 22;
            //pe2.Email = "pepg@mail.com";
            //people.Add(pe2);

            ////people.Delete(21);
            //people.GetPerson(21);
            //Person algo = new Person();
            //algo.Age = 22;
            //algo.Email = "asd@adf.com";
            //algo.Id = 11;
            //algo.Name = "Cuca Saue";
            //people.Add(algo);
            //people.GetPerson(21);
            //var prueba = people.GetFiltered(null, 0, ".com").Count;
            //var capital = people.GetNotCapitalizedIds();
            

            
            //Console.WriteLine(prueba);
            //Console.ReadKey();




        }
    }
}
