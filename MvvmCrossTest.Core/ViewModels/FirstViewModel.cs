using System.Windows.Input;
using MvvmCross.Core.ViewModels;

namespace MvvmCrossTest.Core.ViewModels
{
    public class FirstViewModel 
        : MvxViewModel
    {
        private string _hello = "Hello MvvmCross";
        public string Hello
        { 
            get { return _hello; }
            set { SetProperty (ref _hello, value);  }
        }


		private MvxCommand _resetCommand;
		public ICommand ResetCommand
		{
			get
			{
				_resetCommand = _resetCommand ?? new MvxCommand(() => Reset());
				return _resetCommand;
			}
		}

		public void Reset()
		{
			this.Hello = string.Empty;
		}

    }
}
