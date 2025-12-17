using GenPass.UI.Models;
using GenPass.UI.Services.Interfaces;
using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace GenPass.UI.ViewModels
{
    public class CredencialViewModel : BaseViewModel
    {

        private readonly ICredencialService _credencialService;

       public ObservableCollection<Credencial> credenciales { get; } = new();

        public ICommand LoadCommand { get; }

        public CredencialViewModel(ICredencialService credential)
        {
            _credencialService = credential;
            LoadCommand = new Command(async () => await LoadAsync());
        }

        private async Task LoadAsync()
        {
            if (IsBusy) return;

            try
            {
                IsBusy = true;
                credenciales.Clear();

                var data = await _credencialService.GetListCredential(1);
                if (data.Item1 != null)
                {

                    foreach (var item in data.Item1)
                        credenciales.Add(item);
                }
            }
            finally
            {
                IsBusy = false;
            }
        }

    }
}
