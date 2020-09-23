using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ConsoleApp
{
    class Program
    {
      public  static void Main(string[] args)
        {
            Draw drawXml = new Draw();
            drawXml.CreateGrap("x");
            drawXml.AddConnection(0, 0.75, 1);
            drawXml.AddConnection(1, 0.75, 1);
            drawXml.StartBuild();
            drawXml.Move(0, 20);
            drawXml.Line(0, 40);
            drawXml.Line(80, 20);
            drawXml.Line(80, 40);
            drawXml.CreatPoint();
            drawXml.Move(40, 30);
            drawXml.Line(40, 10);
            drawXml.Line(20, 10);
            drawXml.Line(60, 10);
            drawXml.Move(60, 10);
            drawXml.Arc(20, 10, 10, 5, 1, 0, 0);
            drawXml.EndGrap();


            drawXml.CreateGrap(60, 60, "c", "variable", "inherit");
            drawXml.AddConnection(0, 0.75, 1);
            drawXml.AddConnection(1, 0.75, 1);
            drawXml.StartBuild();
            drawXml.Move(0, 20);
            drawXml.Arc(40, 20, 20, 10, 1, 0, 0);
            drawXml.EndGrap();

            Console.ReadLine();
        }
    }
}
