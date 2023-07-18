namespace aboutNavegacion;

public partial class Cambiopract15 : ContentPage
{
	public Cambiopract15()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(Costo.Text) && !string.IsNullOrEmpty(Cantidad.Text))
        {
            double articulo, dinero, vuelto;
            articulo = Convert.ToDouble(Costo.Text);
            dinero = Convert.ToDouble(Cantidad.Text);
            vuelto = dinero - articulo;
            Cambio.Text = Convert.ToString(vuelto);
        }
        else
        {
            DisplayAlert("Error", "Introduzca los datos solicitados", "Ok");
            Cambio.Text = "";
        }
    }

}