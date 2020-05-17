using System.Collections.Generic;
using System.Text;
using AppMvcBeeCode.Models;
using BeeCode.Business.Interfaces;
using BeeCode.Business.Notificacoes;
using FluentValidation;
using FluentValidation.Results;

namespace BeeCode.Business.Services
{
    public abstract class BaseService
    {
        private INotificador _notificador;

        protected BaseService(INotificador notificador)
        {
            _notificador = notificador;
        }

        protected void Notificar(ValidationResult validationResult)
        {
            foreach (var error in validationResult.Errors)
            {
                Notificar(error.ErrorMessage);
            }
        }

        protected void Notificar(string menssagem)
        {
            _notificador.Handle(new Notificacao(menssagem));
        }

        protected bool ExecutarValidacao<TV, TE>(TV validacao, TE entidade)
            where TV : AbstractValidator<TE> where TE : Entity
        {
            var validator = validacao.Validate(entidade);
            if (validator.IsValid) return true;
            Notificar(validator);
            return false;
        }
    }
}
