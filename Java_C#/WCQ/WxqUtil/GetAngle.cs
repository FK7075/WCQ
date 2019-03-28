using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WxqUtil
{
    public class GetAngle
    {
        public Double Ang_A { get; set; }
        public Double Ang_B { get; set; }
        public Double Ang_C { get; set; }
        public Double L_a { get; set; }
        public Double L_b { get; set; }
        public Double L_c { get; set; }
        public GetAngle(Coordinates a, Coordinates b, Coordinates c)
        {
            this.L_a = Length(b, c);
            this.L_b = Length(a, c);
            this.L_c = Length(a, b);
            this.Ang_A = GetAng(L_b, L_c, L_a) * 180 / Math.PI;
            this.Ang_B = GetAng(L_a, L_c, L_b) * 180 / Math.PI;
            this.Ang_C = GetAng(L_b, L_a, L_c) * 180/ Math.PI;
        }

        private Double Length(Coordinates x, Coordinates y)
        {
            Double a = x.X - y.X;
            Double b = x.Y - y.Y;
            Double c = x.Z - y.Z;
            return Math.Sqrt(Math.Pow(a, 2.0) + Math.Pow(b, 2.0) + Math.Pow(c, 2.0));
        }
        /// <summary>
        /// 求c边对应角的角度
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        private Double GetAng(Double a, Double b, Double c)
        {
            return Math.Acos((a * a + b * b - c * c) / (2.0 * a * b));
        }
    }
}
