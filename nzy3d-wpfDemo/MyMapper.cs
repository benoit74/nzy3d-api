using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nzy3d_wpfDemo
{
    class MyMapper : nzy3D.Plot3D.Builder.Mapper
    {

        public override double f(double x, double y)
        {
            return 10 * Math.Sin(x / 10) * Math.Cos(y / 20) * x;
        }

    }
}
