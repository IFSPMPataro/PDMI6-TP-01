namespace TP01
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnOkClicked(object sender, EventArgs e)
        {
            if (idEntry.Text == "admin" && passwordEntry.Text == "senha@dmin")
            {
                DisplayAlert("OK", "logou!", "OK");
            }
            else
            {
                DisplayAlert("Erro", "credenciais erradas...", "OK");
            }
        }

        private void OnClearClicked(object sender, EventArgs e)
        {
            idEntry.Text = "";
            passwordEntry.Text = "";
            idEntry.Focus();
        }

        private void OnCreditsClicked(object sender, EventArgs e)
        {
            DisplayAlert("Créditos", "Lucas Vieira Dos Santos Martins CB3020223", "OK");
            DisplayAlert("Créditos", "Miguel da Silva Patato CB3021564", "OK");
        }
    }
}
// Lucas Vieira Dos Santos Martins CB3020223
// Miguel da Silva Patato CB3021564