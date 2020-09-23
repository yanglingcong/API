using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
   public interface IDrawXml
    {
        #region 默认创建图形 不保持宽高比  宽高100
        void CreateGrap(string Name);
        #endregion

        /// <summary>
        /// 开始创建图形
        /// </summary>
        /// <param name="hight"></param>
        /// <param name="weight"></param>
        /// <param name="name">图形名称</param>
        /// <param name="Aspect">缩放时是否保持宽高比</param>
        /// <param name="strokewidth">线条宽度</param>
        /// <returns></returns>
        string CreateGrap(int hight, int weight,string name, string Aspect,string strokewidth);

        /// <summary>
        /// 添加图形连接点坐标
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        void AddConnection(double x,double y, int Number);




        /// <summary>
        /// 结束创建图形
        /// </summary>
        void EndGrap();

        /// <summary>
        /// 添加起始点
        /// </summary>
        void Move(double x,double y);

        /// <summary>
        /// 开始构建
        /// </summary>
        void StartBuild();

        /// <summary>
        /// 添加新点
        /// </summary>
        void Line(double x, double y);

        /// <summary>
        /// 创建弧线路径
        /// </summary>
        /// <param name="x">弧线终点x坐标</param>
        /// <param name="y">弧线终点y坐标</param>
        /// <param name="rx">x轴半径</param>
        /// <param name="ry">y轴半径</param>
        /// <param name="rotation">x轴旋转角度</param>
        /// <param name="Angle">角度大小</param>
        /// <param name="sweep">弧线方向 起点到终点顺时针：0   逆时针：1</param>
        void Arc(double x,double y,double rx ,double ry,int rotation,int Angle,int sweep);

        /// <summary>
        /// 创建从当前点回到起始点的路径
        /// </summary>
        void CreatPoint();

        /// <summary>
        /// 画完图形
        /// </summary>
        void Close();

    }
    public enum Aspect
    {
        variable,
        fix,

    }


}
