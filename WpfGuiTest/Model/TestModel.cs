using Prism.Mvvm;

namespace WpfGuiTest.Model
{
    public class TestModel : BindableBase
    {
        private string _message;
        public string Message
        {
            get => _message;
            set => SetProperty( ref _message, value );
        }
    }
}