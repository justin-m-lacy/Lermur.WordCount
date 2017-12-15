using System;
using System.Collections.Generic;
using System.Text;

namespace Lemur.Utils {

	public static class ArrayUtils {

		/// <summary>
		/// Unsafe index-of operation which can be used when an array is known
		/// to be non-empty.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="a"></param>
		/// <param name="v"></param>
		/// <returns>The index of the given value, or -1 if none is found.</returns>
		static public int UnsafeIndexOf<T>( T[] a, T v ) where T : struct {

			int len = a.Length;
			for( int i = 0; i < len; i++ ) {

				if( v.Equals( a[i] ) ) {
					return i;
				}

			}
			return -1;

		} //

		/// <summary>
		/// Unsafe Contains operation does not check that the array parameter
		/// is non-null.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="a"></param>
		/// <param name="v"></param>
		/// <returns></returns>
		static public bool UnsafeContains<T>( T[] a, T v ) where T : struct {

			int len = a.Length;
			for( int i = 0; i < len; i++ ) {

				if( v.Equals( a[i] ) ) {
					return true;
				}

			}
			return false;

		} //

	} // class

} // namespace
