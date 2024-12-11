using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesign
{
    public class ConcreteComponent : IComponent<string>
    {
        public string GetText()
        {
            return "Hi, my name is hrishav";
        }
    }

}
