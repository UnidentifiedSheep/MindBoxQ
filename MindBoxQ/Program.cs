using AreaCalc;

namespace MindBoxQ
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var ls = new List<double>();
			ls.Add(12);
			ls.Add(12);
			ls.Add(12);
			ls.Add(12);
			ls.Add(12);
			var shape = NSideArea.GetNSideArea(ls);
		}
	}
}
