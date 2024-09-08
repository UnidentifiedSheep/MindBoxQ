using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalc.Exceptions
{
	public class ImpossibleSideException : Exception
	{
		public ImpossibleSideException() : base("One or more sides equal 0.")
		{ 
		
		}
	}
}
