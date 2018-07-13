using System.Collections.Generic;

namespace WpfXaml
{
    public class PeopleSource
    {
        public List<Person> People { get; set; }

        public PeopleSource()
        {
            People = new List<Person>{ new Person { Name="m.0", Age=34},  new Person { Name="m.2",  Age=34.5},
            new Person{ Name="m.4", Age=35} };
        }
    }
}
