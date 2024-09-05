using Cadastro_Modelo.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_Aluno.Modelos
{
    internal class Modelo
    {
        public int id_modelo { get; set; }

        public string descricao { get; set; }

        public string eixo {  get; set; }

        public string peso { get; set; }

        public string passageiro { get; set; }

        public string cavalo { get; set; }

        public string cilindrada { get; set; }

        public Marca fk_marca_id { get; set; }
    }
}
