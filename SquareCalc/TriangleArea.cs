using AreaCalc.Enums;
using AreaCalc.Exceptions;
using AreaCalc.Models;

namespace AreaCalc
{
	public static class TriangleArea
	{
		public static double GetTriangleArea(double a, double b, double c)
		{
			double half = (a + b + c) / 2;
			return Math.Sqrt(half * (half - a) * (half - b) * (half - c));
		}
		public static TriangleModel GetTriangleAreaTyped(double a, double b, double c)
		{
			if (a + b <= c || a + c <= b || b + c <= a) throw new ImpossibleTriangleException($"{a},{b},{c}");
			return new TriangleModel(GetTriangleArea(a,b,c), GetTriangleType(a, b, c));
		}
		private static TriangleTypeEnum GetTriangleType(double a, double b, double c)
		{
			if (a == b && a == c)
				return TriangleTypeEnum.Equilateral;
			else if ((a == b && a != c) || (a == c && a != b) || (b == c && b != a))
				return TriangleTypeEnum.Isosceles;
			else if (a != b && a != c)
				return TriangleTypeEnum.Scalene;
			else if (Math.Pow(c, 2) > Math.Pow(a, 2) + Math.Pow(b, 2))
				return TriangleTypeEnum.BluntAngled;
			else if (Math.Pow(c, 2) == Math.Pow(a, 2) + Math.Pow(b, 2))
				return TriangleTypeEnum.Rectangular;
			else if (Math.Pow(c, 2) < Math.Pow(a, 2) + Math.Pow(b, 2))
				return TriangleTypeEnum.SharpAngled;

			return TriangleTypeEnum.Unknown;
		}
	}
}
