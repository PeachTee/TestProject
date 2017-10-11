using Prism.Commands;
using Prism.Mvvm;

using WpfGuiTest.Model;

namespace WpfGuiTest.ViewModel
{
    public class TestViewModel : BindableBase
    {
        private TestModel testModel;

        public TestViewModel()
        {
            // Klasse erstellen
            testModel = new TestModel
            {
                Message = "Das ist ein test"
            };

            // Command festlegen
            TestCommand1 = new DelegateCommand( () => testModel.Message = "Test vorbei" );
            TestCommand2 = new DelegateCommand( () => testModel.Message = "Wieder ein test" );
        }

        public TestModel TestModel
        {
            get => testModel;
            set => SetProperty( ref testModel, value );
        }

        public DelegateCommand TestCommand1 { get; set; }
        public DelegateCommand TestCommand2 { get; set; }
    }
}