using eBin_1.ViewModel.Services;

namespace eBin_1.ViewModel
{
    public partial class ConfiguratorViewModel : BaseViewModel
    {
        // model
        Exports exports = new();

        // service
        ConfiguratorService configuratorService;

        public ConfiguratorViewModel()
        {
            //this.configuratorService = configuratorService;
        }

        [RelayCommand]
        private async Task SaveDataVM()
        {
            await ConfiguratorService.SaveData(exports);
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
                if (exports.City != value)
                {
                    exports.City = value;
                    OnPropertyChanged();
                }
            }
        }
    }
}
