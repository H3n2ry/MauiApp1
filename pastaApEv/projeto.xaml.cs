using MauiApp1.models;

namespace MauiApp1.pastaApEv;

public partial class projeto : ContentPage
{
    App PropriedadesApp;

	public projeto()
	{
		InitializeComponent();

        PropriedadesApp = (App)Application.Current;

        pck_lugares.ItemsSource = PropriedadesApp.Lista_lugares;

        dtpck_inicio.MinimumDate = DateTime.Now;
        dtpck_inicio.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, DateTime.Now.Day);

        dtpck_termino.MinimumDate = dtpck_inicio.Date.AddDays(1);
        dtpck_termino.MaximumDate = dtpck_inicio.Date.AddMonths(6);

    }

    

    private async void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            custo C = new custo
            {
                lugarSelecionado = (lugares)pck_lugares.SelectedItem,
                QuantidadedePessoas = Convert.ToInt32(stp_Participantes.Value),

                DatadeInicio = dtpck_inicio.Date,
                datadeTermino = dtpck_termino.Date,

                
                
            };


            await Navigation.PushAsync(new PainelPrincipal()
            {
                  BindingContext = C

            });
               
        }
        catch (Exception ex)
        {
           await DisplayAlert("Ops", ex.Message, "OK");
        }
    }

    private void dtpck_inicio_DateSelected(object sender, DateChangedEventArgs e)
    {
        DatePicker elemento = sender as DatePicker;

        DateTime date_selecionada_inicio = elemento.Date;

        dtpck_termino.MinimumDate = date_selecionada_inicio.AddDays(1);
        dtpck_termino.MaximumDate = date_selecionada_inicio.AddMonths(6);
    }
}