namespace MauiAppHotel.Views;

public partial class Sobre : ContentPage
{
	public Sobre()
	{
		InitializeComponent();
	}

    private void btn_voltar_Clicked(object sender, EventArgs e)
    {
		Navigation.PopAsync();
    }
}