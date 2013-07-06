using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Story
{
	class The_Fox
	{
		public static bool was_impressed = false;
		public T In_came<T>() where T : new()
		{
			return new T();
		}
		public static explicit operator The_Fox(int i)
		{
			return new The_Fox();
		}
	}

	class The_Pig
	{
		public void and()
		{
		}
		public void who()
		{
		}
		public static explicit operator The_Pig(int i)
		{
			return new The_Pig();
		}
		public void that_read(string q = "")
		{
		}
	}

	class A_scroll_of_parchment { }

	class The_Scientists 
	{
		public void were_amazed()
		{
		}
		public static explicit operator The_Scientists(int i)
		{
			return new The_Scientists();
		}
	}

	partial class Story
	{
		public static int behind_the_glass = -1;
		public static int asked<T>(string q = "")
		{
			return 1;
		}

		public static int said_to<T>(string q = "")
		{
			return 2;
		}

		public static int presented<T>(string q = "")
		{
			return 3;
		}
	}
}