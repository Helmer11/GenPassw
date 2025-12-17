using GenPass.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenPass.UI.Services.Interfaces
{
    public interface ICredencialService
    {

        Task<(List<Credencial>?, string MessageError)> GetListCredential(int userId);
        Task<(bool isSuccess, string MessageError)>  AddCredentialAsync(Credencial credential);
        Task<(bool isSucces, string MessageError)> DeleteCredentialAsync(int id);



    }
}
