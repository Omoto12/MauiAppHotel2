using MauiAppHotel.Models;

namespace MauiAppHotel.Views;

public partial class ContratacaoHospedagem : ContentPage
{
    App PropriedadesApp;

    public ContratacaoHospedagem()
    {
        InitializeComponent();

        PropriedadesApp = (App)Application.Current;

        pck_quarto.ItemsSource = PropriedadesApp.lista_quartos;

        dtpck_checkin.MinimumDate = DateTime.Today;
        dtpck_checkin.MaximumDate = new DateTime(DateTime.Today.Year, DateTime.Today.Month + 1, DateTime.Today.Day);

        dtpck_checkout.MinimumDate = dtpck_checkin.Date.AddDays(1);
        dtpck_checkout.MaximumDate = dtpck_checkin.Date.AddYears(1);

    }
    private async void BtnAvancar_Clicked(object sender, EventArgs e)
    {
        try
        {
            Hospedagem h = new Hospedagem
            {
                QuartoSelecionado = (Quarto)pck_quarto.SelectedItem,
                QntAdultos = Convert.ToInt32(stp_adultos.Value),
                QntCrianca = Convert.ToInt32(stp_criancas.Value),
                DataCheckIn = (DateTime)dtpck_checkin.Date,
                DataCheckOut = (DateTime)dtpck_checkout.Date,
            };

            await Navigation.PushAsync(new SobreHotel(h));
        }
        catch (Exception ex) 
        { 
            await DisplayAlertAsync("Ops", ex.Message, "OK");
        }
    }

    private void dtpck_checkin_DateSelected(object sender, DateChangedEventArgs e)
    {
        DatePicker elemento = sender as DatePicker;

        DateTime data_selecionada_checkin = (DateTime)elemento.Date;

        dtpck_checkout.MinimumDate = data_selecionada_checkin.AddDays(1);
        dtpck_checkout.MaximumDate = data_selecionada_checkin.AddYears(1);
    }
}