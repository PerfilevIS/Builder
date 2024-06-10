using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stroitel
{
    public class Dog
    {
        private string _name;
        private string _breed;
        private int _age;
        private List<string> _toys;
        // Класс-строитель
        public class DogBuilder
        {
            private Dog _dog;
            public DogBuilder()
            {
                _dog = new Dog();
            }
            public DogBuilder WithName(string name)
            {
                _dog._name = name;
                return this;
            }
            public DogBuilder WithBreed(string breed)
            {
                _dog._breed = breed;

                return this;
            }
            public DogBuilder WithAge(int age)
           {
                _dog._age = age;

                return this;
            }
            public DogBuilder WithToys(List<string> toys)
            {
                _dog._toys = new List<string>(toys);
                return this;
            }
            public Dog Build()
            {
                return _dog;
            }
        }
        // Методы-аксессоры
        public string Name
        {
            get { return _name; }
        }
        public string Breed
        {
            get { return _breed; }
        }
        public int Age
        {
            get { return _age; }
        }
        public List<string> Toys
        {
            get { return new List<string>(_toys); }
        }
        // Методы-мутаторы
        public void ChangeName(string newName)
        {
            _name = newName;
        }
        public void ChangeBreed(string newBreed)
        {
            _breed = newBreed;
        }
        public void ChangeAge(int newAge)
        {
            _age = newAge;
        }
        public void AddToy(string toy)

        {
            _toys.Add(toy);
        }
        public void RemoveToy(string toy)
        {
            _toys.Remove(toy);
        }

    }
}
