using System;
namespace var3
{ 
    internal class City
    {
            private string name;
            private Path[] paths;
            public City(string name, Path[] paths)
            {
                this.name = name;
                this.paths = paths;
            }
            public string Name
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
            public Path[] Paths
            {
                get 
                { 
                    return this.paths;
                }
                set
                { 
                    this.paths = value;
                }
            }
            public override string ToString()
            {
                string result = name + ": ";

                for (int i = 0; i < paths.Length; i++)
                {
                    result = result + paths[i].ToString();

                    if (i < paths.Length - 1)
                    {
                        result = result + ", ";
                    }
                }
                return result;
            }
    }
    
}
