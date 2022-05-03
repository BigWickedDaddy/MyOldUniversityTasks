using System;

namespace n_gon
{
    class Program
    {
        static void Main(string[] args)
        {
            Ngon ngon1 = new Ngon(10,10,10,5);
            Console.WriteLine(ngon1);
            //ngon1.GetInfo();
            Console.ReadLine();
        }
    }
    class Ngon
    {
        public double s;
        public double p;
        public double angle;
        public double angles;


        public void GetInfo()
        {
            Console.WriteLine("Ваш периметр = " + s + "\nВаша площадь = " + p +"\nВаша сумма углов = "+angles + "\nВаш угол : "+ angle);
        }
        public Ngon()
        {
            s = 0;
            p = 0;
            angles = 0;
            angle = 0;
            Console.WriteLine("Ваш периметр = " + p + "\nВаша площадь = " + s + "\nВаша сумма углов = " + angles + "\nВаш угол : " + angle);
        }
        public Ngon(int n)
        {
            s = 0;
            p = 0;
            angles = (n - 2) * 180;
            angle = angles/n;
            Console.WriteLine("Ваш периметр = " + s + "\nВаша площадь = " + p + "\nВаша сумма углов = " + angles + "\nВаш угол : " + angle);
        }
        public Ngon(double a1,double a2,double a3)
        {
            double pp = (a1 + a2 + a3) / 2;
            s =Math.Sqrt(pp*(pp-a1)*(pp-a2)*(pp-a3));
            p = a1 + a2 + a3;
            double angle1 = Math.Acos((a2 * a2 + a3 * a3 - a1 * a1) / (2 * a2 * a3)) * 180 / Math.PI;
            double angle2 = Math.Acos((a1 * a1 + a3 * a3 - a2 * a2) / (2 * a1 * a3)) * 180 / Math.PI;
            double angle3 = 180-angle1-angle2;
            Console.WriteLine("Ваш периметр = " + p + "\nВаша площадь = " + s + "\nВаша сумма углов = 180 " + "\nВаши углы : " + angle1+"\n"+angle2+"\n"+angle3);
        }
        public Ngon(double a1,double a2,double a3,double a4)
        {
            s = a1 * a3;
            p = a1 + a2 + a3 + a4;
            angles = 360;
            Console.WriteLine("Ваш периметр = " + p + "\nВаша площадь = " + s + "\nВаша сумма углов = " + angles);
        }
    }
}
