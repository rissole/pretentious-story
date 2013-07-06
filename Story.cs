using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Story
{
	partial class Story
	{
		// replace ()<>_.; by a space for a story.
		public static void Main(string[] args)
		{
			( (The_Fox)asked<The_Pig>("How's it coming along?") ).
			In_came<The_Pig>().who(); said_to<The_Fox>("Great! I've finally done it!");
			( (The_Pig)presented<A_scroll_of_parchment>() ).that_read

			("a = πr²");

			while (The_Fox.was_impressed);
			((The_Scientists)behind_the_glass).were_amazed();
		}
	}
}
