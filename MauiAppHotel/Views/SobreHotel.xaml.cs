using MauiAppHotel.Models;

namespace MauiAppHotel.Views;

public partial class SobreHotel : ContentPage
{

    private Hospedagem hospedagemRecebida;

    public SobreHotel(Hospedagem hospedagem)
    {
        InitializeComponent();
        hospedagemRecebida = hospedagem;
    }

    private async void BtnAvancar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new HospedagemContratada()
        {
            BindingContext = hospedagemRecebida
        });
    }

    private async void BtnAvancarCadastro_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CadastroEvento());
    }
}
