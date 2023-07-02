using EasyCashIdentityProject.DtoLayer.Dtos.AppUserDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.BusinessLayer.ValidationRules.AppUserValidationRules
{
    public class AppUserRegisterValidator : AbstractValidator<AppUserRegisterDtos>
    {
        public AppUserRegisterValidator()
        {
            //Name
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad alanı boş geçilemez");
            RuleFor(x => x.Name).MaximumLength(30).WithMessage("Lütfen 30 karakterden fazla girmeyiniz");
            RuleFor(x => x.Name).MinimumLength(2).WithMessage("Lütfen 2 karakterden az girmeyiniz");

            //Surname
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyad alanı boş geçilemez");

            //Username
            RuleFor(x => x.Username).NotEmpty().WithMessage("Kullanıcı adı alanı boş geçilemez");

            //Email
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email alanı boş geçilemez");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Geçerli bir email adresi giriniz");

            //Password
            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre alanı boş geçilemez");

            //ConfirmPassword
            RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("Şifre doğrulama alanı boş geçilemez");
            RuleFor(x => x.ConfirmPassword).Equal(y => y.Password).WithMessage("Şifreler uyuşmuyor.");


        }
    }
}
