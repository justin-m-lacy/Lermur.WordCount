using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace Lemur.StringCount.Model {

	/// <summary>
	/// Model for updating string counts.
	/// </summary>
	public class StringCountModel : INotifyPropertyChanged {

		public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
		/// Source string being monitored for count changes.
		/// </summary>
		private string _source;

		/// <summary>
		/// Source string being monitored for count changes.
		/// </summary>
		public string Source {
			get {
				return this._source;
			}
			set {
				if( value != this._source ) {
					this._source = value;
					this.NotifyPropertyChanged();
					this.UpdateCount();
				}
			}

		}

		/// <summary>
		/// Delegate which performs counting.
		/// </summary>
		private Func<string, uint> _counter;

		/// <summary>
		/// Delegate which performs counting.
		/// </summary>
		public Func<string, uint> Counter {

			get { return this._counter; }
			set {
				if( value != this._counter ) {
					this._counter = value;
					this.NotifyPropertyChanged();
					this.UpdateCount();
				}
			}

		}

		/// <summary>
		/// Used to store the last counted value so changes aren't
		/// dispatched when the count does not change.
		/// </summary>
		private uint _count;
		public uint Count {
			get { return this._count; }
			protected set {
				if( this._count != value ) {
					this._count = value;
					this.NotifyPropertyChanged();
				}
			}

		}

		/// <summary>
		/// Recount the source with the current counting function.
		/// </summary>
		protected void UpdateCount() {

			if( this._counter == null ) {
				this.Count = 0;
			}
			this.Count = this._counter( this._source );

		} //

		protected void NotifyPropertyChanged( [CallerMemberName] string propName = null ) {
			this.PropertyChanged?.Invoke( this, new PropertyChangedEventArgs( propName ) );
		} //


	} // class

} // namespace
