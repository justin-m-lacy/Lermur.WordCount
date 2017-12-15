using Lemur.Utils;
using System;

namespace Lemur.StringCount {

	/// <summary>
	/// Methods for counting the words in strings.
	/// </summary>
    public class WordCount {

		/// <summary>
		/// Count the number of words in a source string.
		/// </summary>
		/// <param name="source"></param>
		/// <returns></returns>
		static public int Count( string source ) {

			if( source == null ) {
				return 0;
			}

			//int count = 0;
			char[] whitespace = { ' ', '\t', '\n' };
			return source.Split( whitespace, StringSplitOptions.RemoveEmptyEntries ).Length;

		}

		/// <summary>
		/// Counts the number of words in a source string.
		/// </summary>
		/// <param name="source"></param>
		/// <param name="wordSeparators">Characters which can indicate a word boundary.</param>
		/// <returns></returns>
		static public int Count( string source, char[] wordSeparators ) {

			if( source == null ) {
				return 0;
			}

			return source.Split( wordSeparators, StringSplitOptions.RemoveEmptyEntries ).Length;

		} //

    } // class

} // namespace
