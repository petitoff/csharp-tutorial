using System.Windows.Input;

namespace eBin_1.ViewModel.Commands
{
    public class SaveExportsCommand : ICommand
    {
        public SaveExportsCommand(ConfiguratorViewModel configuratorViewModel)
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
            ConfiguratorViewModel.SaveDataVM();
        }
    }
}
