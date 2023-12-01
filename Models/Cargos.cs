using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_NET_MVC.Models
{
    [Table("Cargos")]
    public class Cargos
    {
        [Column("cargo_id")]
        [Key]
        public int CargoId { get; set; }

        [Column("departamento_id")]
        public int DepartamentoId { get; set; }

        [Column("nome")]
        public string Nome { get; set; }

        [Column("salario")]
        public int Salario { get; set; }

        // Propriedade de navegação para o relacionamento com Departamentos
        public Departamentos Departamento { get; set; }
    }
}