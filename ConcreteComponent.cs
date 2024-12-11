

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
