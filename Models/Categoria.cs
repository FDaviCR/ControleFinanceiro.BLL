using System;
using System.Collections.Generic;
using System.Text;

namespace ControleFinanceiro.BLL.Models
{
    internal class Categoria
    {
        public int CategoriaId { get; set; }
        public string Nome { get; set; }
        public string Icone { get; set; }
        public int TipoId { get; set; }
        public Tipo Tipo { get; set; }
        public virtual ICollection<Despesa> Despesas { get; set; }
        public virtual ICollection<Receita> Receitas { get; set; }
    }
}
