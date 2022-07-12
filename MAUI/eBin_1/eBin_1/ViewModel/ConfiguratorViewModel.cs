using eBin_1.ViewModel.Services;
using eBin_1.ViewModel.Commands;

namespace eBin_1.ViewModel
{
    public partial class ConfiguratorViewModel : BaseViewModel
    {
        public SaveExportsCommand SaveExportsCommand { get; set; }
        public LoadExportsCommand LoadExportsCommand { get; set; }

        public ConfiguratorViewModel()
        {
            SaveExportsCommand = new SaveExportsCommand(this);
            LoadExportsCommand = new LoadExportsCommand(this);
        }

        Exports exports = new();
        {
        }

        private string street;
        public string Street
        {
            get => street;
            set
            {
                if (street != value)
                {
                    street = value;
                    OnPropertyChanged();
                }
            }

        }
    }
}
