using System;

namespace MathLib
{
	class ComplexNumber
	{
		public double Real { get; private set; }
		public double Imaginary { get; private set; }

		public static readonly ComplexNumber Zero = new ComplexNumber(0.0, 0.0);
		public static readonly ComplexNumber One = new ComplexNumber(1.0, 0.0);



		public ComplexNumber(double real, double imaginary)
		{
			Real = real;
			Imaginary = imaginary;
		}

		public ComplexNumber() : this(0, 0)
		{
		}

		public ComplexNumber Add(ComplexNumber complexNumber)
		{
			return new ComplexNumber(Real + complexNumber.Real, Imaginary + complexNumber.Imaginary);
		}

		public static ComplexNumber operator +(ComplexNumber complex1, ComplexNumber complex2)
		{
			return new ComplexNumber(complex1.Real + complex2.Real, complex1.Imaginary + complex1.Imaginary);
		}

		public static ComplexNumber operator -(ComplexNumber complex1, ComplexNumber complex2)
		{
			return new ComplexNumber(complex1.Real - complex2.Real, complex1.Imaginary - complex1.Imaginary);
		}

		public static ComplexNumber operator *(ComplexNumber complex1, double number)
		{
			return new ComplexNumber(complex1.Real * number, complex1.Imaginary * number);
		}


		public void Add2(ComplexNumber complex)
		{
			Real += complex.Real;
			Imaginary += complex.Imaginary;
		}

		public ComplexNumber Sub(ComplexNumber complexNumber)
		{
			return new ComplexNumber(Real - complexNumber.Real, Imaginary - complexNumber.Imaginary);
		}

		public void Sub2(ComplexNumber complex)
		{
			Real -= complex.Real;
			Imaginary -= complex.Imaginary;
		}

		public ComplexNumber Multiply(ComplexNumber complexNumber)
		{
			return new ComplexNumber(Real * complexNumber.Real - Imaginary * complexNumber.Imaginary,
						Imaginary * complexNumber.Real + Real * complexNumber.Imaginary);

		}

		public void Multiply2(ComplexNumber complex)
		{
			Real = Real * complex.Real - Imaginary * complex.Imaginary;
			Imaginary = Imaginary * complex.Real + Real * complex.Imaginary;
		}

		public ComplexNumber Multiply(double number)
		{
			return new ComplexNumber(Real * number, Imaginary * number);

		}

		public void Multiply2(double number)
		{
			Real *= number;
			Imaginary *= Imaginary * number;
		}

		public ComplexNumber Divide(ComplexNumber complexNumber)
		{
			if (Math.Abs(complexNumber.Imaginary) < Math.Abs(complexNumber.Real))
			{
				var num = complexNumber.Imaginary / complexNumber.Real;
				return new ComplexNumber((Real + Imaginary * num) / (complexNumber.Real + complexNumber.Imaginary * num), (Imaginary - Real * num) / (complexNumber.Real + complexNumber.Imaginary * num));
			}
			var num1 = complexNumber.Real / complexNumber.Imaginary;
			return new ComplexNumber((Imaginary + Real * num1) / (complexNumber.Imaginary + complexNumber.Real * num1), (-Real + Imaginary * num1) / (complexNumber.Imaginary + complexNumber.Real * num1));
		}

		public void Divide2(ComplexNumber complex)
		{
			if (Math.Abs(complex.Imaginary) < Math.Abs(complex.Real))
			{
				var num = complex.Imaginary / complex.Real;
				Real = (Real + Imaginary * num) / (complex.Real + complex.Imaginary * num);
				Imaginary = (Imaginary - Real * num) / (complex.Real + complex.Imaginary * num);
				return;
			}
			var num1 = complex.Real / complex.Imaginary;
			Real = (Imaginary + Real * num1) / (complex.Imaginary + complex.Real * num1);
			Imaginary = (-Real + Imaginary * num1) / (complex.Imaginary + complex.Real * num1);
		}

		public double Length()
		{
			if (double.IsInfinity(Real) || double.IsInfinity(Imaginary))
			{
				return double.PositiveInfinity;
			}

			var num1 = Math.Abs(Real);
			var num2 = Math.Abs(Imaginary);
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
			return $"{Imaginary} * i {(Real > 0 ? "+" : "-")} {Math.Abs(Real)}";
		}

		public double Arg()
		{
			return Math.Atan2(Imaginary, Real);
		}

		public ComplexNumber Pow(double powerNum)
		{
			var power = new ComplexNumber(powerNum, 0.0);

			if (power == Zero)
				return One;
			if (this == Zero)
				return Zero;
			var real1 = Real;
			var imaginary1 = Imaginary;
			var real2 = power.Real;
			var imaginary2 = power.Imaginary;
			var num1 = Length();
			var num2 = Math.Atan2(imaginary1, real1);
			var num3 = real2 * num2 + imaginary2 * Math.Log(num1);
			var num4 = Math.Pow(num1, real2) * Math.Pow(Math.E, -imaginary2 * num2);
			return new ComplexNumber(num4 * Math.Cos(num3), num4 * Math.Sin(num3));
		}

		public bool Equals(ComplexNumber complex)
		{
			return Real == complex.Real && Imaginary == complex.Imaginary;
		}
	}
}
