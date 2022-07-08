using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Model;

namespace WpfApp1.VewModel
{
    public class ViewModelMPAM : INotifyPropertyChanged
    {
        private ModelMPAP modelMpap = new ModelMPAP();

        public double Value
        {
            get { return modelMpap.Value; }
            set
            {
                modelMpap.Value = value;
                OnPropertyChanged(nameof(Value));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
