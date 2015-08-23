using System;

namespace Zander
{
	public static class ReturnsVoid
	{
		public static Action ToAction<TRet>(this Func<TRet> func){
			return () => {
				func ();
			};
		}
		public static Action<T1> ToAction<T1,TRet>(this Func<T1,TRet> func){
			return (t1) => {
				func (t1);
			};
		}
		public static Action<T1,T2> ToAction<T1,T2,TRet>(this Func<T1,T2,TRet> func){
			return (t1,t2) => {
				func (t1,t2);
			};
		}
		public static Action<T1,T2,T3> ToAction<T1,T2,T3,TRet>(this Func<T1,T2,T3,TRet> func){
			return (t1,t2,t3) => {
				func (t1,t2,t3);
			};
		}



		public static Func<TRet> ToFunc<TRet>(this Action action, TRet value=default(TRet)){
			return () => {
				action ();
				return value;
			};
		}
		public static Func<T1,TRet> ToFunc<T1,TRet>(this Action<T1> action, TRet value=default(TRet)){
			return (t1) => {
				action (t1);
				return value;
			};
		}
		public static Func<T1,T2,TRet> ToFunc<T1,T2,TRet>(this Action<T1,T2> action, TRet value=default(TRet)){
			return (t1,t2) => {
				action (t1,t2);
				return value;
			};
		}
		public static Func<T1,T2,T3,TRet> ToFunc<T1,T2,T3,TRet>(this Action<T1,T2,T3> action, TRet value=default(TRet)){
			return (t1,t2,t3) => {
				action (t1,t2,t3);
				return value;
			};
		}

	}
}

