using System;
using System.Collections.Generic;
using System.Text;

namespace AtataApp.UITests.Components.Controls
{
    public class Person<T>
    {
        public T Id { get; set; }

        public string Name { get; set; }

        public Person(T id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
