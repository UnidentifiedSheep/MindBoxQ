using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalc.Exceptions
{
	public class ImpossibleTriangleException : Exception
	{
		public ImpossibleTriangleException(string? ms) : base(ms) 
		{ }
	}
}
