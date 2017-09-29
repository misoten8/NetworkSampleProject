using System;
using System.Collections.Generic;
using System.Linq;

namespace Misoten8Util
{
	/// <summary>
	/// IEnumerableExtension クラス
	/// 製作者：実川
	/// </summary>
	public static class IEnumerableExtension
	{
		/// <summary>
		/// 最小値を持つ要素を返します
		/// </summary>
		public static TSource FindMin<TSource, TResult>(this IEnumerable<TSource> self, Func<TSource, TResult> selector)
		{
			return self.First(c => selector(c).Equals(self.Min(selector)));
		}

		/// <summary>
		/// 最大値を持つ要素を返します
		/// </summary>
		public static TSource FindMax<TSource, TResult>(this IEnumerable<TSource> self,Func<TSource, TResult> selector)
		{
			return self.First(c => selector(c).Equals(self.Max(selector)));
		}
	}
}