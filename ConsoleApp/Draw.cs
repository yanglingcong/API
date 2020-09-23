using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApp
{
    public class Draw : DrawXml
    {
        public string StringXMl { get; set; }


        public override void CreateGrap(string Name)
        {
            StringXMl = "<shape name='X' h='100' w='100' aspect='variable' strokewidth='inherit'>";
        }

        public override string CreateGrap(int hight, int weight, string name, string Aspect, string strokewidth)
        {
            return StringXMl = $"<shape name='{name}' h='{hight}' w='{weight}' aspect='{Aspect}' strokewidth='{strokewidth}'>";
        }

        public override void AddConnection(double x, double y, int Number)
        {
            if(StringXMl.Contains("constraint"))
            {
                string Connection = $"<constraint x='{x}' y='{y}' perimeter='{Number}' name='!'/>";
                int length = StringXMl.LastIndexOf('!')+4;
                StringXMl = StringXMl.Insert(length, Connection);
            }
            else
            {
                StringXMl += $"<connections><constraint x='{x}' y='{y}' perimeter='{Number}' name='!'/></connections>";
            }
             
        }

        public override void EndGrap()
        {
            StringXMl += "</path></background><foreground><fillstroke/></foreground></shape>";
            StringXMl = StringXMl.Replace("\'", "\"");
            XmlDocument  document = ConvertStringToXmlDocument(StringXMl);
            document.Save("pathsave.xml");

        }

        public XmlDocument ConvertStringToXmlDocument(string xmlString)
        {
            XmlDocument document = new XmlDocument();
            document.LoadXml(xmlString);
            return document;
        }

        public override void CreatPoint()
        {
            StringXMl += "<close/>";
        }

        public override void Line(double x, double y)
        {
            StringXMl += $"<line x='{x}' y='{y}'/>";
        }

        public override void Move(double x, double y)
        {
            StringXMl += $"<move x='{x}' y='{y}'/>";
        }

        public override void Arc(double x, double y, double rx, double ry, int rotation, int Angle, int sweep)
        {
            StringXMl+= $"<arc rx='{rx}' ry='{ry}' x-axis-rotation='{rotation}' large-arc-flag='{Angle}' sweep-flag='{sweep}' x='{x}' y='{y}'/>";
        }

        public override void Close()
        {
            StringXMl += "</path></background><foreground><fillstroke/></foreground>";
        }

        public override void StartBuild()
        {
            StringXMl += "<background><path>";
        }
    }
}
