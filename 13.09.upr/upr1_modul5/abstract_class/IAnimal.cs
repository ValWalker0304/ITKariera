using System;
using System.Collections.Generic;
using System.Text;

namespace abstract_class
{
    public interface IAnimal
    {
        string Habitat { get; set; }
        int Age { get; set; }
        void Introduce();
    }
}
