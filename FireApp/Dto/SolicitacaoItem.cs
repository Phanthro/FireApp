using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireApp.Dto
{
    public class SolicitacaoItem
    {
        public int SolicitacaiId { get; set; }
        public string Descricao { get; set; }
        public string Tipo { get; set; }
        public sbyte Status { get; set; }

    }
}
