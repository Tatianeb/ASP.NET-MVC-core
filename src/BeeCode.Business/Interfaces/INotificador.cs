using System.Collections.Generic;
using BeeCode.Business.Notificacoes;

namespace BeeCode.Business.Interfaces
{
    public interface INotificador
    {
        bool TemNotificacao();
        List<Notificacao> ObterNotificacoes();
        void Handle(Notificacao notificacao);

    }
}