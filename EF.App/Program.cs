using System;
using EF.DB_Lib;
using EF.Model;

namespace EF.App
{
    internal static class Program
    {
        private static void Main()
        {
            var db = new PersonsDb();

            foreach (var person in db.TablePersons)
            {
                Console.WriteLine($"#{person.Id}: {person.LastName} {person.FirstName}, {person.Age}");
            }

            db.TablePersons.Add(new Person
            {
                FirstName = "Anonim",
                LastName = "Anonimus",
                Age = 0
            });
            db.SaveChanges();
            
            foreach (var person in db.TablePersons)
            {
                Console.WriteLine($"#{person.Id}: {person.LastName} {person.FirstName}, {person.Age}");
            }
        }
    }
}