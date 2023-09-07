using BetterConverters.ViewModels;

namespace BetterConverters.Pages;

public partial class ConverterPage : ContentPage
{
	public ConverterPage(ConverterViewModel viewModel)
	{
		BindingContext = viewModel;

		InitializeComponent();
	}
}