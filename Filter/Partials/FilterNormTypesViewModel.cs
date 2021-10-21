using em.Commands;
using em.ViewModels.Base;
using System.Windows.Controls;
using System.Windows.Input;

namespace em.Filter.Partials
{
    internal class FilterNormTypesViewModel : ViewModelBase
    {
        private int _MainComboBoxSelectedIndex = 0;
        public int MainComboBoxSelectedIndex 
        { 
            get => _MainComboBoxSelectedIndex;
            set
            {
                Set(ref _MainComboBoxSelectedIndex, value);
            }
        }

        public ICommand ComboBoxClear_Command { get; }
        public override bool CanExecute(object? parameter) => true;
        public override void Execute(object? parameter) => ComboBoxClear(parameter as ComboBox);
        public ICommand OtherComboBoxClear_Command { get; }

        public void ComboBoxClear(ComboBox par)
        {
            par.SelectedIndex = -1;
        }

        public FilterNormTypesViewModel()
        {
            ComboBoxClear_Command = new LambdaCommand(Execute, CanExecute);
        }
    }
}
