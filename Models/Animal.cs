using System;
using SearchAnimal.Models;

namespace SearchAnimal
{
    public class Animal : IAnimal
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Age { get; set; }

        public int GetAge()
        {
            throw new NotImplementedException();
        }

        public string GetName()
        {
            throw new NotImplementedException();
        }

        string IAnimal.GetType()
        {
            throw new NotImplementedException();
        }
    }
}
