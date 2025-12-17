using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenPass.UI.Models
{
    public class Credencial
    {
        public long CredencialId { get; set; }

        public long UserId { get; set; }

        public string NameSite { get; set; } = string.Empty;

        public string UserName { get; set; }

        public string Key { get; set; }

        public bool IsActive { get; set; }

        public DateTime RegisterDate { get; set; }

        // Navegación (opcional)
        public Usuario? Usuario { get; set; }




    }
}
