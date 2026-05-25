namespace MauiAppHotel.Views;

public partial class HospedagemContratada : ContentPage
{
	public HospedagemContratada()
	{
		InitializeComponent();
	}

    private void btn_voltar_Clicked(object sender, EventArgs e)
    {
		try
		{
			Navigation.PopAsync();
		} catch (Exception ex)
		{
			DisplayAlertAsync("Ops...", ex.Message, "Fechar");
		}
    }
}