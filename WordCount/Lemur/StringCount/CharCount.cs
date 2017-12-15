using System;
using System.Collections.Generic;
using System.Text;

namespace Lemur.WordCount {

	/// <summary>
	/// Methods for counting the characters in strings.
	/// </summary>
	public static class CharCount {

		/// <summary>
		/// Counts the number of letter characters in source string using char.IsLetter()
		/// Null strings return 0 characters.
		/// </summary>
		/// <param name="source">The string being searched.</param>
		/// <returns>The number of letter characters in a source string, or 0 if string is null.</returns>
		static public int Digits( string source ) {

			if( string.IsNullOrEmpty( source ) ) {
				return 0;
			}

			int count = 0;

			int len = source.Length;
			for( int i = 0; i < len; i++ ) {

				char c = source[i];
				if( char.IsDigit( c ) ) {
					count++;
				}

			} // for-loop.

			return count;

		} // CountLetters()

		  /// <summary>
		  /// Counts the number of letter characters in source string using char.IsLetter()
		  /// Null strings return 0 characters.
		  /// </summary>
		  /// <param name="source">The string being searched.</param>
		  /// <returns>The number of letter characters in a source string, or 0 if string is null.</returns>
		static public int Letters( string source ) {

			if( string.IsNullOrEmpty( source ) ) {
				return 0;
			}

			int count = 0;

			int len = source.Length;
			for( int i = 0; i < len; i++ ) {

				char c = source[i];
				if( char.IsLetter( c ) ) {
					count++;
				}

			} // for-loop.

			return count;

		} // CountLetters()

		/// <summary>
		/// Counts the number of letter or digit characters in a source string.
		/// </summary>
		/// <param name="source">A string whose characters are being counted.</param>
		/// <returns></returns>
		static public int Lexical( string source ) {

			if( string.IsNullOrEmpty( source ) ) {
				return 0;
			}

			int count = 0;

			int len = source.Length;
			for( int i = 0; i < len; i++ ) {

				char c = source[i];
				if( char.IsLetterOrDigit( c ) ) {
					count++;
				}

			} // for-loop.

			return count;

		}

		/// <summary>
		/// Counts every character in a source string, regardless of type.
		/// </summary>
		/// <param name="source"></param>
		/// <returns>The number of characters in a source string, or 0 if the string is null.</returns>
		static public int All( string source ) {

			if( source == null ) { return 0; }
			return source.Length;

		}

		/// <summary>
		/// Counts the number of non-whitespace characters in a source string.
		/// </summary>
		/// <param name="source"></param>
		/// <returns></returns>
		static public int Nonwhite( string source ) {

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
