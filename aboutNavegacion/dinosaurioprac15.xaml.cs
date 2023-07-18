namespace aboutNavegacion;

public partial class dinosaurioprac15 : ContentPage
{
	public dinosaurioprac15()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        double PesoDinosaurio = Convert.ToDouble(Peso.Text);


        double libras = 220462262 * (PesoDinosaurio);

        Pesado.Text = Convert.ToString(libras);
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        double AlturaDinosaurio = Convert.ToDouble(Altura.Text);


        double centimetros = 100 * (AlturaDinosaurio);

        AlturaMedida.Text = Convert.ToString(centimetros);
    }
}