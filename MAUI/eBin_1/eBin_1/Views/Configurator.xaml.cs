using eBin_1.ViewModel;

namespace eBin_1.Views;

public partial class Configurator : ContentPage
{
	public Configurator(ConfiguratorViewModel configuratorViewModel)
	{
		InitializeComponent();
		BindingContext = configuratorViewModel;
	}
}