using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeTest1
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
	internal class ColorAttribute : Attribute
	{
		public ConsoleColor Color;

		public ColorAttribute(ConsoleColor color)
		{
			Color = color;
		}
	}
}