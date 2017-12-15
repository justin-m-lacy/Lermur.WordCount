using Lemur.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lemur.StringCount {

	/// <summary>
	/// Methods for counting the sentences in strings.
	/// </summary>
	public static class SentenceCount {

		/// <summary>
		/// Counts the number of sentences in a source string.
		/// </summary>
		/// <param name="source"></param>
		/// <returns></returns>
		static public int Count( string source ) {

			if( source == null ) {
				return 0;
			}

			char[] terminators = { '.', '!', '?' };

			int len = source.Length;
			int index = 0, count = 0;

			while( index < len ) {

				char c = source[index++];

				if( ArrayUtils.UnsafeContains( terminators, c ) ) {

					count++;
					// advance until a non-terminator is found.
					while( index < len && ArrayUtils.UnsafeContains( terminators, source[index] ) ) {
						index++;
					}

				}

			} // while-loop

			return count;

		} //

		/// <summary>
		/// Counts the number of sentences in a source string.
		/// </summary>
		/// <param name="source"></param>
		/// <param name="terminators">Characters which indicate an end-of-sentence.</param>
		/// <returns>The number of sentences in the source string.
		/// If the source string is null, the terminator array is null, or the terminator array
		/// has no elements, 0 is returned.</returns>
		static public int Count( string source, char[] terminators ) {

			if( source == null || terminators == null || terminators.Length == 0 ) {
				return 0;
			}

			int len = source.Length;
			int index = 0;
			int count = 0;

			while( index < len ) {

				char c = source[index++];

				if( ArrayUtils.UnsafeContains( terminators, c ) ) {

					count++;
					// advance until a non-terminator is found.
					while( index < len && ArrayUtils.UnsafeContains( terminators, source[index] ) ) {
						index++;
					}

				}

			} // while-loop

			return count;

		} //

	} // class

} // namespace
