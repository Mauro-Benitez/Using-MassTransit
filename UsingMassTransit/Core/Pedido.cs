using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Pedido
    {
        public int ID { get; set; }

        public Usuario Usuario { get; set; }
        public DateTime DataDeCriacao { get; set; }

        public Pedido(int iD, Usuario usuario, DateTime datetime)
        {
            ID = iD;
            Usuario = usuario;
            DataDeCriacao = datetime;
        }

        public override string ToString()
        {
            return $"Pedido Id {ID}, Usuário {Usuario.Nome}, Data de Criação {DataDeCriacao:dd/MM/yyyy}";
        }
    }
}
