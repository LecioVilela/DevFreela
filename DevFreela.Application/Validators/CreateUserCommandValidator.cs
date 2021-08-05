using DevFreela.Application.Commands.CreateUser;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DevFreela.Application.Validators
{
    public class CreateUserCommandValidator : AbstractValidator<CreateUserCommand>
    {
        public CreateUserCommandValidator()
        {
            RuleFor(p => p.Email)
                .EmailAddress()
                .WithMessage("E-mail não válido!");

            RuleFor(p => p.Password)
                .Must(ValidPassword)
                .WithMessage("Senha deve conter pelo menos 8 caracteres, um número, uma letra maíscula, uma letra minúscula e um caracter especial!");

            RuleFor(p => p.FullName)
                .NotEmpty()
                .NotNull()
                .WithMessage("Nome é obrigatório!");
        }

        public bool ValidPassword(string password)
        {
            var regex = new Regex(@"^.*(?=.{8,})(?=.*[a-z])(?=.*[A-Z])(?=.*[!*@#$%^&+=]).*$");

            return regex.IsMatch(password);
        }
    }
}
