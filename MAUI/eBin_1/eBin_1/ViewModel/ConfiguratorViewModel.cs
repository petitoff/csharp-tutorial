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

        public async void SaveDataVM()
        {
            await ConfiguratorService.SaveData(exports);
            ClearEntry();
        }

        public async void LoadDataVM()
        {
            var response = await ConfiguratorService.LoadData();
        }

        public void ClearEntry()
        {
            Street = "";
            City = "";
        }

        public string Street
        {
            get => exports.Street;
            set
            {
                if (exports.Street != value)
                {
                    exports.Street = value;
                    OnPropertyChanged();
                }
            }
        }

        public string City
        {
            get => exports.City;
            set
            {
                if(exports.City != value)
                {
                    exports.City = value;
                    OnPropertyChanged();
                }
            }
        }
    }
}
