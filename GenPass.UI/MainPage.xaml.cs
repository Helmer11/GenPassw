using GenPass.UI.ViewModels;

namespace GenPass.UI
{
    public partial class MainPage : ContentPage
    {
       
        public MainPage(CredencialViewModel vw)
        {
            InitializeComponent();
            BindingContext = vw;
            vw.LoadCommand.Execute(null);
        }

       
    }
}
