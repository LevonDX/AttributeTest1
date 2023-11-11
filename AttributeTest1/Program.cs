namespace AttributeTest1
{
	[Color(ConsoleColor.Blue)]
	public class ColorClass
	{
		override public string ToString()
		{
			return "ColorClass";
		}
	}

	internal class Program
	{
		static void ShowColorClass(ColorClass colorClass)
		{
			// 1. Read the attribute of colorClass instance
			// 2. Based on value, change the color of console

			ColorAttribute? colorAtrb = Attribute.GetCustomAttribute(colorClass.GetType(), typeof(ColorAttribute)) as
				ColorAttribute;

			if (colorAtrb != null)
			{
				ConsoleColor consoleColor = colorAtrb.Color;
				Console.ForegroundColor = consoleColor;
			}

			Console.WriteLine(colorClass);
			Console.ResetColor();
		}

		static void Main(string[] args)
		{
			ShowColorClass(new ColorClass());
		}
	}
}