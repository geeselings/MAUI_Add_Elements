namespace MauiAddElement
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }
        
        private void OnDisplayClicked(object sender, EventArgs e)
        {
            lblOutput.Text = textInput.Text;
        }

        private void OnResetClicked(object sender, EventArgs e)
        {
            textInput.Text = string.Empty;
            lblOutput.Text = string.Empty;
        }
    }
}
