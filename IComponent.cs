using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesign
{
    public interface IComponent<T>
    {
        T GetText();
    }
}
