using Lemur.Utils;
using System;

namespace Lemur.WordCount {

	/// <summary>
	/// Base utility class for counting words.
	/// </summary>
    public class WordCount {

		static public int CountSentences( string source ) {

			if( string.IsNullOrEmpty( source ) ) {
				return 0;
			}

			char[] terminators = { '.', '!', '?' };

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

			} //

			return count;

		} //

		/// <summary>
		/// Count the number of words in a source string.
		/// </summary>
		/// <param name="source"></param>
		/// <returns></returns>
		static public int CountWords( string source ) {

			if( string.IsNullOrEmpty( source ) ) {
				return 0;
			}

			//int count = 0;
			char[] whitespace = { ' ', '\t', '\n' };
			return source.Split( whitespace, StringSplitOptions.RemoveEmptyEntries ).Length;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="source"></param>
		/// <param name="wordSeparators">Characters which count as separating words.</param>
		/// <returns></returns>
		static public int CountWords( string source, char[] wordSeparators ) {

			if( string.IsNullOrEmpty( source ) ) {
				return 0;
			}

			return source.Split( wordSeparators, StringSplitOptions.RemoveEmptyEntries ).Length;

		} //

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
