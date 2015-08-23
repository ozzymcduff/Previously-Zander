using System;
using Microsoft.FSharp.Core;
using FSharpx;
namespace Zander
{
	public static class Extensions
	{
		public static void Match<T>(this FSharpOption<T> option, Action<T> some, Action none)
		{
			Match<T,Unit> (option, some.ToFunc(), none.ToFunc());
		}
		public static TRet Match<T,TRet>(this FSharpOption<T> option, Func<T,TRet> some, Func<TRet> none)
		{
			return null != option
				? some (option.Value)
				: none();
		}
	}
}

