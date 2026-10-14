using System;
namespace var3
{
    internal class HumanWithFather
    {
        private Name name;
        private int height;
        private HumanWithFather father;
        public HumanWithFather(Name name, int height, HumanWithFather father)
        {
            this.name = name;
            if (height > 0)
            {
                this.height = height;
            }
            else
            {
                Console.WriteLine("Ошибка.Рост должен быть положительным");
                this.height = 0;
            }
            this.father = father;

            if (father != null)
            {
                if (this.name.Surname == null)
                {
                    if (father.Name.Surname != null)
                    {
                        this.name.Surname = father.Name.Surname;
                    }
                }
                if (this.name.Patronymic == null)
                {
                    if (father.Name.FirstName != null)
                    {
                        this.name.Patronymic = father.Name.FirstName + "ович";
                    }
                }
            }
        }
        public HumanWithFather(string nameString, int height)
            : this(new Name(nameString), height, null)
        {
        }

        public HumanWithFather(string nameString, int height, HumanWithFather father)
            : this(new Name(nameString), height, father)
        {
        }
        public HumanWithFather(Name name, int height)
            : this(name, height, null)
        {
        }
        public Name Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public int Height
        {
            get { return this.height; }
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
        public HumanWithFather Father
        {
            get { return this.father; }
            set { this.father = value; }
        }
        public override string ToString()
        {
            return name.FirstName + ", " + height;
        }
    }
}