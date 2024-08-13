using FluentValidation;

namespace CleanArchitecture.Aplication.UseCases.GetAllUser;

public sealed class GetAllUserValidator : AbstractValidator<GetAllUserRequest>
{
	public GetAllUserValidator()
	{
		// sem validação
	}
}
