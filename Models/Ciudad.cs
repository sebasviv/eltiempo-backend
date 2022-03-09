

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace pruebasvmvc.Models
{
    [Table("Ciudad")]
    public class Ciudad
    {
        [Key]
        public int Id { get; set; }
        public string Descripcion { get; set; }
    }
}
