using System;

namespace Complex
{
	class Program
	{
		static void Main(string[] args)
		{

		}

	}
		class ComplexNumber
	{
		public double Real { get; private set; }
		public double Imagine { get; private set; }

		public static  ComplexNumber Zero = new ComplexNumber(0.0, 0.0);
		public static  ComplexNumber One = new ComplexNumber(1.0, 0.0);


		public ComplexNumber() : this(0, 0)
		{
		}

		public ComplexNumber(double real, double imagin)
		{
			Real = real;
			Imagine = imagin;
		}

		public ComplexNumber Add(ComplexNumber complexNumber)
		{
			return new ComplexNumber(Real + complexNumber.Real, Imagine + complexNumber.Imagine);
		}

		public static ComplexNumber operator +(ComplexNumber complex1, ComplexNumber complex2)
		{
			return new ComplexNumber(complex1.Real + complex2.Real, complex1.Imagine + complex1.Imagine);
		}

		public void Add2(ComplexNumber complex)
		{
			Real += complex.Real;
			Imagine += complex.Imagine;
		}

		public ComplexNumber Sub(ComplexNumber complexNumber)
		{
			return new ComplexNumber(Real - complexNumber.Real, Imagine - complexNumber.Imagine);
		}

		public void Sub2(ComplexNumber complex)
		{
			Real -= complex.Real;
			Imagine -= complex.Imagine;
		}

		public static ComplexNumber operator -(ComplexNumber complex1, ComplexNumber complex2)
		{
			return new ComplexNumber(complex1.Real - complex2.Real, complex1.Imagine - complex1.Imagine);
		}

		public ComplexNumber Multiply(ComplexNumber complexNumber)
		{
			return new ComplexNumber(Real * complexNumber.Real - Imagine * complexNumber.Imagine,Imagine * complexNumber.Real + Real * complexNumber.Imagine);

		}

		public void Multiply2(ComplexNumber complex)
		{
			Real = Real * complex.Real - Imagine * complex.Imagine;
			Imagine = Imagine * complex.Real + Real * complex.Imagine;
		}

		public ComplexNumber Multiply(double number)
		{
			return new ComplexNumber(Real * number, Imagine * number);

		}

		public void Multiply2(double number)
		{
			Real *= number;
			Imagine *= Imagine * number;
		}

		public static ComplexNumber operator *(ComplexNumber complex1, double number)
		{
			return new ComplexNumber(complex1.Real * number, complex1.Imagine * number);
		}

		public ComplexNumber Divide(ComplexNumber complexNumber)
		{
			if (Math.Abs(complexNumber.Imagine) < Math.Abs(complexNumber.Real))
			{
				var num = complexNumber.Imagine / complexNumber.Real;
				return new ComplexNumber((Real + Imagine * num) / (complexNumber.Real + complexNumber.Imagine * num), (Imagine - Real * num) / (complexNumber.Real + complexNumber.Imagine * num));
			}
			var num1 = complexNumber.Real / complexNumber.Imagine;
			return new ComplexNumber((Imagine + Real * num1) / (complexNumber.Imagine + complexNumber.Real * num1), (-Real + Imagine * num1) / (complexNumber.Imagine + complexNumber.Real * num1));
		}

		public void Divide2(ComplexNumber complex)
		{
			if (Math.Abs(complex.Imagine) < Math.Abs(complex.Real))
			{
				var num = complex.Imagine / complex.Real;
				Real = (Real + Imagine * num) / (complex.Real + complex.Imagine * num);
				Imagine = (Imagine - Real * num) / (complex.Real + complex.Imagine * num);
				return;
			}
			var num1 = complex.Real / complex.Imagine;
			Real = (Imagine + Real * num1) / (complex.Imagine + complex.Real * num1);
			Imagine = (-Real + Imagine * num1) / (complex.Imagine + complex.Real * num1);
		}

		public double Length()
		{
			if (double.IsInfinity(Real) || double.IsInfinity(Imagine))
			{
				return double.PositiveInfinity;
			}

			var num1 = Math.Abs(Real);
			var num2 = Math.Abs(Imagine);
			if (num1 > num2)
			{
				var num3 = num2 / num1;
				return num1 * Math.Sqrt(1.0 + num3 * num3);
			}
			if (num2 == 0.0)
			{
				return num1;
			}

			var num4 = num1 / num2;
			return num2 * Math.Sqrt(1.0 + num4 * num4);
		}

		public override string ToString()
		{
			return $"{Imagine} * i {(Real > 0 ? "+" : "-")} {Math.Abs(Real)}";
		}

		public double Arg()
		{
			return Math.Atan2(Imagine, Real);
		}

		public ComplexNumber Pow(double powerNum)
		{
			var power = new ComplexNumber(powerNum, 0.0);

			if (power == Zero)
				return One;
			if (this == Zero)
				return Zero;
			var real1 = Real;
			var Imagine1 = Imagine;
			var real2 = power.Real;
			var Imagine2 = power.Imagine;
			var num1 = Length();
			var num2 = Math.Atan2(Imagine1, real1);
			var num3 = real2 * num2 + Imagine2 * Math.Log(num1);
			var num4 = Math.Pow(num1, real2) * Math.Pow(Math.E, -Imagine2 * num2);
			return new ComplexNumber(num4 * Math.Cos(num3), num4 * Math.Sin(num3));
		}

		public bool Equals(ComplexNumber complex)
		{
			return Real == complex.Real && Imagine == complex.Imagine;
		}
	}
}