using MauiAppHotel.Models;

namespace MauiAppHotel.Views;

public partial class CadastroEvento : ContentPage
{
	public CadastroEvento()
	{
		InitializeComponent();

        dtpck_inicio.MinimumDate = DateTime.Today;
        dtpck_termino.MinimumDate = DateTime.Today.AddDays(1);
    }

    private void Dtpck_inicio_DateSelected(object sender, DateChangedEventArgs e)
    {
        dtpck_termino.MinimumDate = e.NewDate.AddDays(1);
    }

    private async void BtnCadastrar_Clicked(object sender, EventArgs e)
    {
        try
        {
            var novoEvento = new Evento
            {
                Nome = txt_nome.Text,
                Local = txt_local.Text,
                NumeroParticipantes = Convert.ToInt32(txt_participantes.Text),
                CustoPorParticipante = Convert.ToDecimal(txt_custo.Text),
                DataInicio = dtpck_inicio.Date,
                DataTermino = dtpck_termino.Date,
            };

            var paginaResumo = new EventoResumo();

            paginaResumo.BindingContext = novoEvento;

            await Navigation.PushAsync(paginaResumo);
        }
    }