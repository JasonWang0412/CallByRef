using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallByRef
{
	internal class Program
	{
		static void Main( string[] args )
		{
			Foo foo = new Foo { data = "77" };
			Bar bar = new Bar();
			bar.savedata( out foo );

			Console.WriteLine( foo.data );
			Console.ReadKey();
		}
	}

	internal class Foo
	{
		internal string data
		{
			get; set;
		}
	}

	internal class Bar
	{
		internal Bar()
		{
			m_foo = new Foo { data = "66" };
		}

		internal void savedata( out Foo foo )
		{
			//foo.data = "66";
			foo = m_foo;
		}

		Foo m_foo;
	}
}
