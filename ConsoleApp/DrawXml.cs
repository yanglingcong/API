using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public abstract class DrawXml : IDrawXml
    {
        void IDrawXml.Create(string Name)
        {
            throw new NotImplementedException();
        }

        void IDrawXml.CreateGrap(int hight, int weight, string name, IAspect Aspect, string strokewidth)
        {
        }

        public enum Aspect
        {
            variable,
            fix,
        }


    }

}
