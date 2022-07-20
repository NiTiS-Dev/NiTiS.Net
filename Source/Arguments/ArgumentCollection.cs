using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NiTiS.Net.Arguments;
public class ArgumentCollection : IEnumerable<IArgument>
{
	private readonly List<IArgument> arguments;
	public ArgumentCollection() : this(8) { }
	public ArgumentCollection(int size )
	{
		arguments = new List<IArgument>(size);
	}
	public ArgumentCollection(IEnumerable<IArgument> arguments)
	{
		this.arguments = arguments.ToList();
	}
	public override string ToString()
	{
		StringBuilder builder = new();

		uint i = 0;
		foreach(IArgument arg in arguments)
		{
			if (i == 0) builder.Append('?');
			else builder.Append('&');
			builder.Append(arg.Create(i));
			i++;
		}

		return builder.ToString();
	}
	public IEnumerator<IArgument> GetEnumerator()
		=> arguments.GetEnumerator();
	IEnumerator IEnumerable.GetEnumerator()
		=> (this as IEnumerable<IArgument>).GetEnumerator();
}
