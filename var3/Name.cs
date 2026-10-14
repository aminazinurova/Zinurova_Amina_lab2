using System;
namespace var3
{
    internal class Name
    {
        private string surname;
        private string name;
        private string patronymic;
        public Name(string surname, string name, string patronymic)
        {
            this.surname = surname;
            this.name = name;
            this.patronymic = patronymic;
        }
        public Name(string name)
        {
            this.name = name;
            this.surname = null;
            this.patronymic = null;
        }

        public Name(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
            this.patronymic = null;
        }
        public string Surname
        {
            get 
            {
                return this.surname;
            }
            set 
            {
                this.surname = value;
            }
        }

        public string FirstName
        {
            get
            { 
                return this.name;
            }
            set
            { 
                this.name = value;
            }
        }

        public string Patronymic
        {
            get 
            { 
                return this.patronymic; 
            }
            set 
            { 
                this.patronymic = value;
            }
        }
        public override string ToString()
        {
            string result = "";

            if (surname != null)
            {
                result = result + surname;
            }

            if (name != null)
            {
                if (result != "")
                {
                    result = result + " ";
                }
                result = result + name;
            }

            if (patronymic != null)
            {
                if (result != "")
                {
                    result = result + " ";
                }
                result = result + patronymic;
            }
            return result;
        }
    }
}