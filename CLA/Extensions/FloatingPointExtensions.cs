using System;
using System.Collections.Generic;
using System.Linq;


namespace OpenHTM.CLA.Extensions
{
	public static class FloatExtensions
	{
		/// <summary>
		/// Clamp value to an inclusive range.
		/// </summary>
		/// <param name="value"></param>
		/// <param name="min"></param>
		/// <param name="max"></param>
		/// <returns></returns>
		public static T Clamp<T> ( this T value, T min, T max )
		{
			T output = value;
			if (((IComparable)value).CompareTo ( max ) > 0)
			{
				return max;
			}
			if (((IComparable)value).CompareTo ( min ) < 0)
			{
				return min;
			}
			return output;
		} 


	}
}