using AreaCalc.Exceptions;
using AreaCalc.Models;
using System;

namespace AreaCalc
{
	public static class NSideArea
	{
		private static bool IsRightPolygon(IEnumerable<double> sides) => sides.All(s => s == sides.First());
		private static bool IsCirce(IEnumerable<double> sides) => sides.Count() == 1;
		private static bool IsTriangle(IEnumerable<double> sides) => sides.ToList().Count == 3;

		public static ShapeModel? GetNSideArea(IEnumerable<double> sides)
		{
			if (sides.Any(x => x <= 0)) throw new ImpossibleSideException();

			var sidesL = new List<double>(sides);
			var _isCircl = IsCirce(sidesL);
			var _isRight = IsRightPolygon(sidesL);
			var _isTriangle = IsTriangle(sidesL);

			if (sidesL.Count == 0) throw new ArgumentNullException(nameof(sidesL));
			if (sidesL.Count == 2) throw new IsNotShapeException(nameof(sidesL));

			if (_isTriangle) return TriangleArea.GetTriangleAreaTyped(sidesL[0], sidesL[1], sidesL[2]);

			if (_isCircl) return RoundArea.GetRoundArea(sidesL[0]);

			if (_isRight) return GetNRightSideArea(sides);


			return new ShapeModel { Area = double.NaN, ShapeType = Enums.ShapeEnum.Unknown };
		}
		private static ShapeModel GetNRightSideArea(IEnumerable<double> sides)
		{
			var sidesL = new List<double>(sides);
			var sideZero = sidesL[0];
			var ctg = 1 / Math.Tan(Math.PI / sidesL.Count);
			double area = (sidesL.Count/4.0*Math.Pow(sideZero, 2)) * ctg;
			return new ShapeModel { Area = area, ShapeType = Enums.ShapeEnum.NSide };
		}
	}
}
