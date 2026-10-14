using System;
namespace var3
{
    internal class Human
    {
        private Name name;
        private int height;

        public Human(Name name, int height)
        {
            this.name = name;
            if (height > 0)
            {
                this.height = height;
            }
            else 
            {
                Console.WriteLine("Ошибка. Рост должен быть полоожительным");
                this.height = 0;
            }
        }
        public Name Name
        {
            get
            {
                return this.name;
            }
            set
            { 
                this.name= value;
            }
        }
        public int Height
        {
            get 
            {
                return this.height;
            }
            set
            {
                if (value > 0)
                {
                    this.height = value;
                }
                else
                {
                    Console.WriteLine("Ошибка.Рост должен быть положительным");
                }
            }
        }
        public override string ToString()
        {
            return name + ", рост: " + height;
        }
    }
}
