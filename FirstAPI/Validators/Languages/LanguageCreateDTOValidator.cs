using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FirstAPI.DTOs.Languages;

namespace FirstAPI.Validators.Languages
{
    [Route("api/[controller]")]
    [ApiController]
    public class LanguageCreateDTOValidator : AbstractValidator<LanguageCreateDTO>
    {
        public LanguageCreateDTOValidator()
        {

            RuleFor(x => x.Code)
                .NotNull()
                .NotEmpty()
                .WithMessage("Bos ola bilmez")
                .MaximumLength(2)
                .WithMessage("2-den cox olmamalidir");

            RuleFor(x => x.Name)
                .NotNull()
                .NotEmpty()
                .WithMessage("Bos ola bilmez")
                .MaximumLength(32)
                .WithMessage("32den cox ola bilmez");

            RuleFor(x => x.IconUrl)
                .NotNull()
                .NotEmpty()
                .WithMessage("Bos ola bilmez")
                .Matches("http(s)?://([\\w-]+\\.)+[\\w-]+(/[\\w- ./?%&=]*)?")
                .MaximumLength(128)
                .WithMessage("128den cox ola bilmez");


        }
    }
}
