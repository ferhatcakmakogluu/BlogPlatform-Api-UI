using FluentValidation;
using NLayer.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Service.Validations
{
    public class PicturesDtoValidator : AbstractValidator<PicturesDto>
    {
        public PicturesDtoValidator()
        {
            RuleFor(x => x.PictureUrl)
              .NotEmpty().WithMessage("{PropertyName} is not null!")
              .NotEmpty().WithMessage("{PropertyName} is not empty!");
        }
    }
}
