using MauiWeather.MVVM.ViewModel;

namespace MauiWeather.MVVM.View;

public partial class WeatherView : ContentPage
{
	public WeatherView()
	{
		InitializeComponent();
		BindingContext = new WeatherViewModel();
	}
}