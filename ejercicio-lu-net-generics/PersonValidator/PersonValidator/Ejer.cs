using System;
using System.Collections.Generic;
using System.Text;
using PersonRepository.Entities;
using PersonRepository.Interfaces;
using System.Linq;
using System.Text.RegularExpressions;
using System.ComponentModel.DataAnnotations;


namespace PersonValidator
{
    class Ejer : IPersonRepositoryBasic, IPersonRepositoryAdvanced
    {
        
        //public bool IsValidEmail(string source)
        //{
        //    return new EmailAddressAttribute().IsValid(source);
        //}

        public List<Person> People { get; set; }
        public Ejer()
        {
            People = new List<Person>();
        }

        public void Add(Person person)
        {
            
            if ((People.Exists(x => x.Id == person.Id) == false) && (person.Age > 0) && person.Email.Contains('@') && person.Email.Contains('.'))
            {
                People.Add(person);


            }
            else
            {
                Console.WriteLine("no se puede agregar a la lista");
        
            }

        }

        public void Delete(int id)
        {

            People.Remove(People.Find(x => x.Id == id));
            Console.WriteLine("se ha removido la persona");
            
            
        }

        public int GetCountRangeAges(int min, int max)
        {
            int cont = 0;
            foreach(Person item in People)
            {
                if (min <= item.Age && item.Age <= max )
                {
                    cont++; 
                }
            }
            return cont;
        }

        public List<Person> GetFiltered(string name, int age, string email)
        {
           
            if (email != null)
            {
               
                List<Person> lista = People.Where(x => x.Email.Contains(email) == true).ToList();

                if (name != null)
                {
                    List<Person> lista2 = lista.Where(x => x.Name == name).ToList();
                    if (age != 0)
                    {
                        List<Person> lista3 = lista2.Where(x => x.Age == age).ToList();
                        return lista3;
                    }
                    else
                    {
                        return lista2;
                    }

                }else
                if (age > 0)
                {
                    List<Person> lista3 = lista.Where(x => x.Age == age).ToList();
                    return lista3;
                }
                else { return lista; }
                
            }
            else if (name != null )
            {
                List<Person> lista = People.Where(x => x.Name == name).ToList();
                if (age != 0)
                {
                    List<Person> lista2 = lista.Where(x => x.Age == age).ToList();
                    return lista2;
                }
                else
                {
                    return lista;
                }
            }
            else if (age != 0)
            {
                List<Person> lista = People.Where(x => x.Age == age).ToList();
                return lista;
            }
            else
            {
                Console.WriteLine("no ingresó ningún parametro");
                return null;
            }

            
        }
    

        public Person GetPerson(int Id)
        {
            var pe = new Person();

            pe = People.Find((x => x.Id == Id));
            //Console.WriteLine(pe.Age + pe.Email);
            return pe = People.Find((x => x.Id == Id));
        }


        public void Update(Person person)
        {
            if(People.Exists(x => x.Id == person.Id))
            {
                
                if (person.Age >= 0 && person.Email.Contains('@') && person.Email.Contains('.'))
                {
                    People.Find(x => x.Id == person.Id).Age = person.Age;
                    People.Find(x => x.Id == person.Id).Email = person.Email;
                    People.Find(x => x.Id == person.Id).Name = person.Name;

                }
                else
                {
                    Console.WriteLine("No se puede actualizar a la persona");
                }           
                
                
                      
                    
            }
        }

        public int[] GetNotCapitalizedIds()
        {
            int[] ids = new int[People.Count];
            int cantidad = 0;
            

            foreach (Person item in People)
            {
                string[] palabra = item.Name.Split(" ");
                var mayu = true;
                for(int i = 0; i<palabra.LongLength; i++)
                {
                
                    if (palabra[i].Substring(0,1) != palabra[i].Substring(0,1).ToUpper())
                    {
                        mayu = false;
                    }
                }
                if(mayu == false)
                {

                    ids[cantidad] = item.Id;
                    cantidad++; 

                }

            }
            //string[] palabra = People.
            //int[] array = People.Where(x => x.Name. )

            return ids;
        }

        public Dictionary<int, string[]> GroupEmailByNameCount()
        {
            throw new NotImplementedException();
        }
    }
}
