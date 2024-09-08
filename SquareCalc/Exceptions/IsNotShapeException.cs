using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalc.Exceptions
{
	public class IsNotShapeException : Exception
	{
		public IsNotShapeException(string? ms) : base(ms) 
		{ 
	
		}
	}
}
