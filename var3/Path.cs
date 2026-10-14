using System;
namespace var3
{
    internal class Path
    {
        private City city;
        private int cost;
        public Path(City city, int cost)
        {
            this.city = city;
            if (cost >= 0)
            {
                this.cost = cost;
            }
            else
            {
                Console.WriteLine
                       ("Ошибка.Стоимость не может быть отрицательной");
                this.cost = 0;
            }
        }
        public City City
        {
            get { return this.city; }
            set { this.city = value; }
        }
        public int Cost
        {
            get { return this.cost; }
            set
            {
                if (value >= 0)
                {
                    this.cost = value;
                }
                else
                {
                    Console.WriteLine
                        ("Ошибка.Стоимость не может быть отрицательной.");
                }
            }
        }
        public override string ToString()
        {
            return city.Name + ":" + cost;
        }
    }
}

