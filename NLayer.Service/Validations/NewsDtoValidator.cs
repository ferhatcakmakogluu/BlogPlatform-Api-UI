using FluentValidation;
using NLayer.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Service.Validations
{
    public class NewsDtoValidator : AbstractValidator<NewsDto>
    {
        public NewsDtoValidator()
        {
            RuleFor(x => x.Title)
               .NotEmpty().WithMessage("{PropertyName} is not null!")
               .NotEmpty().WithMessage("{PropertyName} is not empty!")
               .MaximumLength(350).WithMessage("{PropertyName} length must be max 350 char");

            RuleFor(x => x.Description)
               .NotEmpty().WithMessage("{PropertyName} is not null!")
               .NotEmpty().WithMessage("{PropertyName} is not empty!");

        }
    }
}
