

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace pruebasvmvc.Models
{
    [Table("Vendedor")]
    public class Vendedor
    {
        [Key]
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public int Numero_identificacion { get; set; }

        public Ciudad Ciudad { get; set; }

    }
}
