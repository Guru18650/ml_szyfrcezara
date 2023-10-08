namespace ml_szyfrcezara;

public partial class Deszyfruj : ContentPage
{
	public Deszyfruj()
	{
		InitializeComponent();
	}
    private void gen_Clicked(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(dEntry.Text) || string.IsNullOrEmpty(pEntry.Text))
        {
            DisplayAlert("B≥πd", "Wprowadü poprawne dane", "OK");
            return;
        }
        string szyfr = dEntry.Text;
        string szyfrout = "";
        int p = int.Parse(pEntry.Text);
        if (p < 0)
            p *= -1;
        foreach (var item in szyfr)
        {
            int f = (((int)item - 126 - (p % 94)) % 94) + 126;
            szyfrout += (char)f;
        }
        Clipboard.SetTextAsync(szyfrout);
        DisplayAlert("Sukces, skopiowano", szyfrout, "OK");
    }
}