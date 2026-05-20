namespace MauiAppHotel.Views;

public partial class SobreHotel : ContentPage
{
	public SobreHotel()
	{
		InitializeComponent();
	}
    private async void BtnAvancar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new HospedagemContratada());
    }

}