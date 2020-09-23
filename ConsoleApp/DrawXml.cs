using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public abstract class DrawXml : IDrawXml
    {
        public abstract void AddConnection(double x, double y, int Number);
        public abstract void Arc(double x, double y, double rx, double ry, int rotation, int Angle, int sweep);
        public abstract void Close();
        public abstract void CreatPoint();
        public abstract void CreateGrap(string Name);
        public abstract string CreateGrap(int hight, int weight, string name, string Aspect, string strokewidth);
        public abstract void EndGrap();
        public abstract void Line(double x, double y);
        public abstract void Move(double x, double y);
        public abstract void StartBuild();
    }

}
