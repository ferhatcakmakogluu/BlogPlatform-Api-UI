using FluentValidation;
using NLayer.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Service.Validations
{
    public class NewsCommentsDtoValidator : AbstractValidator<NewsCommentsDto>
    {
        public NewsCommentsDtoValidator()
        {
            RuleFor(x=> x.Comment)
                .NotEmpty().WithMessage("{PropertyName} is not null!")
                .NotEmpty().WithMessage("{PropertName} is not empty!")
                .MaximumLength(500).WithMessage("{PropertyName} length must be max 500 char");

            RuleFor(x => x.CommentedBy)
                .NotEmpty().WithMessage("{PropertyName} is not null!")
                .NotEmpty().WithMessage("{PropertName} is not empty!")
                .MaximumLength(250).WithMessage("{PropertyName} length must be max 250 char");
        }
    }
}
