using AreaCalc.Enums;

namespace AreaCalc.Models
{
	public class TriangleModel : ShapeModel
	{
		public TriangleTypeEnum TriangleType { get; } = TriangleTypeEnum.Unknown;
		public TriangleModel(double area, TriangleTypeEnum type) 
		{ 
			Area = area;
			TriangleType = type;
			ShapeType = ShapeEnum.Triangle;
		}
	}
}
