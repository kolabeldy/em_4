using em.Commands;
using em.Commands.Base;
using em.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace em.FilterPartials
{
    internal class FilterEnergyResourcesViewModel: ViewModelBase
    {
        private int _MainComboBoxSelectedIndex = 0;
        public int MainComboBoxSelectedIndex 
        { 
            get => _MainComboBoxSelectedIndex;
            set
            {
                Set(ref _MainComboBoxSelectedIndex, value);
                if (value > 0) OtherComboBoxSelectedIndex = -1;
            }
        }
        private int _OtherComboBoxSelectedIndex = 0;
        public int OtherComboBoxSelectedIndex
        {
            get => _OtherComboBoxSelectedIndex;
            set
            {
                Set(ref _OtherComboBoxSelectedIndex, value);
                if(value > 0) MainComboBoxSelectedIndex = -1;
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

        public FilterEnergyResourcesViewModel()
        {
            ComboBoxClear_Command = new LambdaCommand(Execute, CanExecute);
        }
    }
}
