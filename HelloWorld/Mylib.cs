using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mylib
{
    public class MyMath
    {

        /// <summary>
        /// Giải Phương trình bậc nhất
        /// </summary>
        /// <param name="a">Tham số a</param>
        /// <param name="b">Tham số b</param>
        /// <param name="x">Nghiệm pt nếu có</param>
        /// <returns>
        /// -1: Phương trình vô nghiệm
        /// 0: Phương trình vô số nghiệm
        /// 1: Phương trình có 1 nghiệm
        /// </returns>
        public static KetQua PTBacNhat(int a, int b, out float x)
        {
            x = 0;
            if (a == 0)
                if (b == 0)
                    return KetQua.VoSoNghiem;
                else return KetQua.VoNghiem;
            else
            {
                x = (float)-b / a;
                return KetQua.Co1Nghiem;
            }
        }

        public static long TongNSo(int n)
        {
            long rs = 0;
            for (int i = 0; i <= n; i++)
                rs += i;
            return rs;
        }

        public static long TongNSoVesion2(int n)
        {
            long rs = 0;
            int i = 0;
            while(i<=n)
            {
                rs += (long)i;
                i++;
        
            }
            return rs;
        }
        public static long TongNSoDeQuy(int n)
        {
            if (n == 0)
                return 0;
            else
                return n + TongNSoDeQuy(n - 1);
        }

        public enum KetQua {
            VoNghiem,
            VoSoNghiem,
            Co1Nghiem
        }

}

    public class Point
    {
        public int x
        {
            get;
            set;
        }
        public int y
        {
            get;
            set;
        }
        public Point()
        {
            x = 0; y = 0;
        }
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public Point(Point p)
        {
            this.x = p.x;
            this.y = p.y;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public double Distance()
        {
            double d = Math.Sqrt(x*x+y*y);

            return d;
        }
        /// <summary>
        /// Tính  khoảng cách đến điểm p
        /// Hàm Overloading của hàm Distance
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public double Distance(Point p)
        {
            double d = Math.Sqrt((x - p.x) * (x - p.x) + (y - p.y) * (y - p.y));

            return d;
        }
        /// <summary>
        /// Tính khoảng cách từ điểm a --> b
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static double Distance(Point a, Point b)
        {
            double d = Math.Sqrt(Math.Pow(a.x - b.x, 2) + Math.Pow(a.y - b.y, 2));

            return d;
        }
        public override string ToString()
        {
            return $"Toa do cua diem la ({x},{y})";
        }
    }
}
