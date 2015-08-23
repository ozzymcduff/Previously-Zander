using System;
using Microsoft.FSharp.Core;
namespace Zander
{
	public static class Extensions
	{
		public static void Match<T>(this FSharpOption<T> option, Action<T> some, Action none)
		{
			Match<T,Unit> (option, ReturnsVoid.ToFunc<T,Unit> (some), ReturnsVoid.ToFunc<Unit>(none));
		}
		public static TRet Match<T,TRet>(this FSharpOption<T> option, Func<T,TRet> some, Func<TRet> none)
		{
			return null != option
				? some (option.Value)
				: none();
		}
	}
}

