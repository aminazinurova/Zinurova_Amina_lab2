using System;
namespace var3
{
    internal class Cat
    {
        private string name;
        public Cat(string name)
        {
            if (name != null && name != "")
            {
                this.name = name;
            }
            else 
            {
                Console.WriteLine("Ошибка.Имя не может быть пустым.");
                this.name = "Безымянный";
            }
        }
        public string Name
        {
            get 
            {
                return this.name;
            }
            set
            {
                if (value != null && value != "")
                {
                    this.name = value;
                }
                else 
                {
                    Console.WriteLine("Ошибка.Имя не может быть пустым.");
                }
            }
        }
        public override string ToString()
        {
            return "кот: " + name;
        }
        public void Meow()
        {
            Console.WriteLine(name + ": мяу!");
        }
        public void Meow(int n)
        {
            string result = name + ": ";

            for (int i = 0; i < n; i++)
            {
                result = result + "мяу";

                if (i < n - 1)
                {
                    result = result + "-";
                }
            }
            result = result + "!";
            Console.WriteLine(result);
        }
    }
}
