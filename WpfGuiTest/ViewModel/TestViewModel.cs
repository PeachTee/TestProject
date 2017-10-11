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
                Message = "This is a test"
            };

            // Command festlegen
            TestCommand = new DelegateCommand( () => testModel.Message = "Das war ein Test" );
        }

        public TestModel TestModel
        {
            get => testModel;
            set => SetProperty( ref testModel, value );
        }

        public DelegateCommand TestCommand { get; set; }
    }
}