using FluentValidation;
using NLayer.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Service.Validations
{
    public class AlbumeDtoValidator : AbstractValidator<AlbumeDto>
    {
        public AlbumeDtoValidator()
        {
            RuleFor(x=> x.AlbumeName)
                .NotEmpty().WithMessage("{PropertyName} is not null!")
                .NotEmpty().WithMessage("{PropertyName} is not empty!")
                .MaximumLength(250).WithMessage("{PropertyName} length must be max 250 char");
        }
    }
}
