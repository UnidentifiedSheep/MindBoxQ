using AreaCalc.Enums;
using AreaCalc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalc
{
	public static class RoundArea
	{
		public static ShapeModel GetRoundArea(double r)
		{
			return new ShapeModel { ShapeType = ShapeEnum.Circle, Area = Math.PI * Math.Pow(r, 2) };
		}
	}
}
