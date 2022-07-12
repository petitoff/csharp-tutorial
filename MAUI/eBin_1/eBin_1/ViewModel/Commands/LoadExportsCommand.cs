using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace eBin_1.ViewModel.Commands
{
    public class LoadExportsCommand : ICommand
    {
        public LoadExportsCommand(ConfiguratorViewModel configuratorViewModel)
        {
            ConfiguratorViewModel = configuratorViewModel;
        }

        public event EventHandler CanExecuteChanged;
        public ConfiguratorViewModel ConfiguratorViewModel { get; set; }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            ConfiguratorViewModel.LoadDataVM();
        }
    }
}
