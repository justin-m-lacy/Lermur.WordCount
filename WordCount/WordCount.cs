using System;

namespace Lemur.WordCount {

    public class WordCount {

		/// <summary>
		/// Counts the number of characters in a source string.
		/// </summary>
		/// <param name="source"></param>
		/// <returns></returns>
		static public int CountChars( string source ) {

			if( string.IsNullOrEmpty( source ) ) {
				return 0;
			}

			int count = 0;

			int len = source.Length;
			for( int i = 0; i < len; i++ ) {

				char c = source[i];
				if( !char.IsWhiteSpace( c ) ) {
					count++;
				}

			} // for-loop.

			return count;

		}

    } // class

} // namespace
