using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIAppsistencia.Models
{
    public class UsuarioModel
    {
        public string nombre { get; set; }
        public string genero { get; set; }
        public string email { get; set; }
        public string password { get; set; }
    }
}