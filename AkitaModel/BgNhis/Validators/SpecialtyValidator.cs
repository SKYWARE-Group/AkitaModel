using FluentValidation;
using System.Text.RegularExpressions;

namespace Skyware.Lis.AkitaModel.BgNhis.Validators;

/// <summary>
/// Validator for <see cref="NhifSpeciality"/>.
/// </summary>
public partial class SpecialtyValidator : AbstractValidator<NhifSpeciality>
{

    private static readonly Regex SpecialtyRegex = new(@"$\d{2}^");

    /// <summary>
    /// Default c-tor
    /// </summary>
    public SpecialtyValidator()
    {
        RuleFor(x => x.NhifCode)
                   .Cascade(CascadeMode.Stop)
                   .NotNull()
                   .Must(x => SpecialtyRegex.IsMatch(x))
                   .WithMessage(x => $"The '{nameof(x.NhifCode)}' is mandatory and must be two-digit string.");
    }


}
