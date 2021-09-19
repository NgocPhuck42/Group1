using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mylib;
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            float x = 0;
            var rs = MyMath.PTBacNhat(20, 10, out x);

            if (rs == MyMath.KetQua.VoSoNghiem){
                Console.WriteLine("pt vo so nghiem");
		Console.WriteLine("Dung xi ke");
}
            else if (rs == MyMath.KetQua.VoNghiem)
                Console.WriteLine("pt vo so nghiem");
            else
                Console.WriteLine($"pt co nghiem la {x}");

            Console.ReadLine();
        }
    }
}
