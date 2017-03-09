using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;

namespace MvvmCrossTest.Tst.Views
{
    public partial class FirstView : MvxViewController
    {
        public FirstView() : base("FirstView", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var set = this.CreateBindingSet<FirstView, Core.ViewModels.FirstViewModel>();
            set.Bind(Label).To(vm => vm.Hello);
            set.Bind(TextField).To(vm => vm.Hello);
			set.Bind(clickButton).To(vm => vm.ResetCommand);
            set.Apply();
        }
    }
}
