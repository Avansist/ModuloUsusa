using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ModuloUsuarios.Models.Entities
{
    public class Usuario
    {
        // DataAnnotations
        public int UsuarioId { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public int Telefono { get; set; }
        public string Contraseña { get; set; }
        public string ConfirmarContraseña { get; set; }
        public string Estado { get; set; }

        [ForeignKey("rolId")]
        public int RolId { get; set; }
        public virtual Rol Rol { get; set; }
    }
}
