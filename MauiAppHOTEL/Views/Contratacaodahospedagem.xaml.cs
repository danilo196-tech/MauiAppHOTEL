namespace MauiAppHOTEL.Views;

public partial class Contratacaodahospedagem : ContentPage
{
	App PropriedadesApp;
	public Contratacaodahospedagem()
	{
		InitializeComponent();

		PropriedadesApp = (App)Application.Current;
		pck_quarto.ItemsSource = PropriedadesApp.lista_quartos;
		dtpck_check_in.MinimumDate = DateTime.Now;
		dtpck_check_in.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, DateTime.Now.Day);
        dtpck_check_out.MinimumDate = dtpck_check_in.Date.AddDays(1);
		dtpck_check_out.MaximumDate = dtpck_check_in.Date.AddMonths(6);

    }

  
    private void Button_Clicked_1(object sender, EventArgs e)
    {
		try
		{
			Navigation.PushAsync(new hospedagemcontratada());

		}catch (Exception ex)
		{
			DisplayAlert("Ops", ex.Message, "ok");
		}
    }

    private void dtpck_check_in_DateSelected(object sender, DateChangedEventArgs e)
    {
		DatePicker elemento = sender as DatePicker;
		DateTime data_selecionada_chechin = elemento.Date;

		dtpck_check_out.MinimumDate = data_selecionada_chechin.AddDays(1);
		dtpck_check_out.MaximumDate = data_selecionada_chechin.AddMonths(6);	
    }
}