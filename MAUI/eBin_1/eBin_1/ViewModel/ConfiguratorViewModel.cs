﻿using eBin_1.ViewModel.Services;
using eBin_1.ViewModel.Commands;

namespace eBin_1.ViewModel
{
    public partial class ConfiguratorViewModel : BaseViewModel
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
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
