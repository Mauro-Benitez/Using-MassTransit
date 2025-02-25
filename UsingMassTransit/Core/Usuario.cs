using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Usuario
    {
        public int ID { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public Usuario(int iD, string nome, string email)
        {
            ID = iD;
            Nome = nome;
            Email = email;
        }
    }
}
