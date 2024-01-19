using FireApp.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireApp.ViewModels
{
    public class SolicitacoesViewModel :INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged( string propertyName )
        {
            PropertyChanged?.Invoke( this, new PropertyChangedEventArgs( propertyName ) );
        }


        private List<SolicitacaoItem> _solicitacoes;

        public List<SolicitacaoItem> Solicitacoes
        { get => _solicitacoes; set { if (_solicitacoes != value) { _solicitacoes = value; OnPropertyChanged( nameof( Solicitacoes ) ); } } }


        public SolicitacoesViewModel() { }

        public void CarrgarSolicitacoes()
        {
            Solicitacoes = new List<SolicitacaoItem>
            {
                new SolicitacaoItem { Descricao = "Descrição xxxx", SolicitacaiId = 1, Status = 1, Tipo = "xxxxxx" },
                new SolicitacaoItem { Descricao = "Descrição xxxx", SolicitacaiId = 2, Status = 1, Tipo = "xxxxxx" },
                new SolicitacaoItem { Descricao = "Descrição xxxx", SolicitacaiId = 3, Status = 1, Tipo = "xxxxxx" },
                new SolicitacaoItem { Descricao = "Descrição xxxx", SolicitacaiId = 4, Status = 2, Tipo = "xxxxxx" },
                new SolicitacaoItem { Descricao = "Descrição xxxx", SolicitacaiId = 5, Status = 3, Tipo = "xxxxxx" },
            };
        }
    }
}
