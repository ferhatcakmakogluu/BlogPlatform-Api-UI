using FluentValidation;
using Microsoft.EntityFrameworkCore;
using NLayer.Core.DTOs;
using NLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Service.Validations
{
    public class AdminDtoValidator : AbstractValidator<AdminsDto>
    {
        private readonly AppDbContext _appDbContext;
        public AdminDtoValidator(AppDbContext context)
        {
            _appDbContext = context;

            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("{PropertyName} is not null!")
                .NotEmpty().WithMessage("{PropertyName} is not empty!")
                .MaximumLength(100).WithMessage("{PropertyName} length must be max 100 char");

            RuleFor(x => x.LastName)
               .NotEmpty().WithMessage("{PropertyName} is not null!")
               .NotEmpty().WithMessage("{PropertName} is not empty!")
               .MaximumLength(50).WithMessage("{PropertyName} length must be max 50 char");

            RuleFor(x => x.Role)
               .NotEmpty().WithMessage("{PropertyName} is not null!")
               .NotEmpty().WithMessage("{PropertName} is not empty!")
               .MaximumLength(50).WithMessage("{PropertyName} length must be max 50 char");


            //Check username and pass

            RuleFor(x => x.UserName)
               .NotEmpty().WithMessage("{PropertyName} is not null!")
               .NotEmpty().WithMessage("{PropertName} is not empty!")
               .MaximumLength(50).WithMessage("{PropertyName} length must be max 50 char");
            
            RuleFor(x => x.Password)
               .NotEmpty().WithMessage("{PropertyName} is not null!")
               .NotEmpty().WithMessage("{PropertName} is not empty!")
               .MaximumLength(50).WithMessage("{PropertyName} length must be max 50 char");

        }

        private Task<string> CheckUsername(string userName)
        {
            var response = _appDbContext.Admins
                                .AsNoTracking()
                                .FirstOrDefault(admin => admin.UserName == userName);
            if (response != null)
            {
                return Task.FromResult(userName);
            }
            return Task.FromResult("");
        }

        private Task<string> CheckPassword(string password)
        {
            var response = _appDbContext.Admins
                                .AsNoTracking()
                                .FirstOrDefault(admin => admin.Password == password);
            if (response != null)
            {
                return Task.FromResult(password);
            }
            return Task.FromResult("");
        }
    }
}
