namespace MauiApp1.pastaApEv;

public partial class PainelPrincipal : ContentPage
{
	public PainelPrincipal()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new projeto());
        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }
    }
}