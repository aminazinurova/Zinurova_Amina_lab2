using System;
namespace var3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Задача 1.3");
            Console.WriteLine();
            Name name1;
            Name name2;
            Name name3;
            Console.WriteLine("Имя 1:");
            string s1 = Checked.ReadStringOrNull("Фамилия (Enter — нет): ");
            string n1 = Checked.ReadStringOrNull("Имя (Enter — нет): ");
            string p1 = Checked.ReadStringOrNull("Отчество (Enter — нет): ");
            name1 = new Name(s1, n1, p1);
            Console.WriteLine();
            Console.WriteLine("Имя 2:");
            string s2 = Checked.ReadStringOrNull("Фамилия (Enter — нет): ");
            string n2 = Checked.ReadStringOrNull("Имя (Enter — нет): ");
            string p2 = Checked.ReadStringOrNull("Отчество (Enter — нет): ");
            name2 = new Name(s2, n2, p2);
            Console.WriteLine();
            Console.WriteLine("Имя 3:");
            string s3 = Checked.ReadStringOrNull("Фамилия (Enter — нет): ");
            string n3 = Checked.ReadStringOrNull("Имя (Enter — нет): ");
            string p3 = Checked.ReadStringOrNull("Отчество (Enter — нет): ");
            name3 = new Name(s3, n3, p3);
            Console.WriteLine();
            Console.WriteLine("Результаты:");
            Console.WriteLine(name1);
            Console.WriteLine(name2);
            Console.WriteLine(name3);
            Console.WriteLine();

            Console.WriteLine("Задача 2.2");
            Console.WriteLine();
            int h1 = Checked.ReadPositiveInt("Рост человека №1: ");
            Human human1 = new Human(name1, h1);
            int h2 = Checked.ReadPositiveInt("Рост человека №2: ");
            Human human2 = new Human(name2, h2);
            int h3 = Checked.ReadPositiveInt("Рост человека №3: ");
            Human human3 = new Human(name3, h3);
            Console.WriteLine();
            Console.WriteLine("Результаты:");
            Console.WriteLine(human1);
            Console.WriteLine(human2);
            Console.WriteLine(human3);
            Console.WriteLine();

            //Console.WriteLine("Задача 2.3");
            //Console.WriteLine();
            //Name ivanName = new Name("Чудов", "Иван", null);
            //Name petrName = new Name("Чудов", "Пётр", null);
            //Name borisName = new Name(null, "Борис", null);
            //HumanWithFather ivan = new HumanWithFather(ivanName, 180, null);
            //HumanWithFather petr = new HumanWithFather(petrName, 170, ivan);
            //HumanWithFather boris = new HumanWithFather(borisName, 160, petr);
            //Console.WriteLine(ivan);
            //Console.WriteLine(petr);
            //Console.WriteLine(boris);
            //Console.WriteLine();

            Console.WriteLine("Задача 3.3");
            Console.WriteLine();
            City a = new City("A", new Path[0]);
            City b = new City("B", new Path[0]);
            City c = new City("C", new Path[0]);
            City d = new City("D", new Path[0]);
            City e = new City("E", new Path[0]);
            City f = new City("F", new Path[0]);
            a.Paths = new Path[]
            {
                new Path(b, 5),
                new Path(d, 6),
                new Path(f, 1)
            };

            b.Paths = new Path[]
            {
                new Path(c, 3),
                new Path(f, 5)
            };

            c.Paths = new Path[]
            {
                new Path(d, 4)
            };

            d.Paths = new Path[]
            {
                new Path(e, 2)
            };

            e.Paths = new Path[]
            {
                new Path(f, 2)
            };

            f.Paths = new Path[]
            {
                new Path(b, 1)
            };
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine();

            Console.WriteLine("Задача 4.5");
            Console.WriteLine();
            string n1_45 = Checked.ReadString("Имя (только имя): ");
            Name name45_1 = new Name(n1_45);
            string n2_45 = Checked.ReadString("Имя: ");
            string s2_45 = Checked.ReadString("Фамилия: ");
            string p2_45 = Checked.ReadStringOrNull("Отчество (Enter — нет): ");
            Name name45_2 = new Name(s2_45, n2_45, p2_45);
            string n3_45 = Checked.ReadString("Имя: ");
            string s3_45 = Checked.ReadString("Фамилия: ");
            Name name45_3 = new Name(n3_45, s3_45);
            string n4_45 = Checked.ReadString("Имя: ");
            string s4_45 = Checked.ReadString("Фамилия: ");
            Name name45_4 = new Name(n4_45, s4_45);
            Console.WriteLine();
            Console.WriteLine("Результаты:");
            Console.WriteLine(name45_1);
            Console.WriteLine(name45_2);
            Console.WriteLine(name45_3);
            Console.WriteLine(name45_4);
            Console.WriteLine();


            Console.WriteLine("Задача 4.6");
            Console.WriteLine();
            string fname = Checked.ReadString("Имя первого человека: ");
            int fheight = Checked.ReadPositiveInt("Рост первого человека: ");
            HumanWithFather first = new HumanWithFather(fname, fheight);
            string sname = Checked.ReadString("Имя второго человека: ");
            string ssurname = Checked.ReadString("Фамилия второго человека: ");
            int sheight = Checked.ReadPositiveInt("Рост второго человека: ");
            Name secondName = new Name(sname, ssurname);
            HumanWithFather second = new HumanWithFather(secondName, sheight, first);
            string tname = Checked.ReadString("Имя третьего человека: ");
            int theight = Checked.ReadPositiveInt("Рост третьего человека: ");
            HumanWithFather third = new HumanWithFather(tname, theight, second);
            Console.WriteLine();
            Console.WriteLine("Результаты:");
            Console.WriteLine(first);
            Console.WriteLine(second);
            Console.WriteLine(third);
            Console.WriteLine();

            Console.WriteLine("Задача 5.2");
            Console.WriteLine();
            string catName = Checked.ReadString("Имя кота: ");
            Cat cat = new Cat(catName);
            Console.WriteLine(cat);
            Console.WriteLine();
            Console.WriteLine("Мяукаем 1 раз:");
            cat.Meow();
            Console.WriteLine();
            int n = Checked.ReadPositiveInt("Сколько раз мяукать? ");
            Console.WriteLine("Мяукаем " + n + " раз:");
            cat.Meow(n);
            Console.WriteLine();
        }
    }
}