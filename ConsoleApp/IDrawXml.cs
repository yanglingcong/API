using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
   public interface IDrawXml
    {
        #region 默认创建图形
        void Create(string Name);
        #endregion

        #region 开始创建图形的宽高 name：图形名称   aspect：缩放时是否保持宽高比   strokewidth:线条宽度
        void CreateGrap(int hight, int weight,string name, IAspect Aspect,string strokewidth);
        #endregion

        /// <summary>
        /// 添加图形连接点坐标
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        void AddConnection(double x,double y);




        /// <summary>
        /// 结束创建图形
        /// </summary>
        void EndGrap();



    }
    public enum Aspect
    {
        variable,
        fix,

    }


    public interface IAspect
    {
         string Fix { get; set; }

    }
}
