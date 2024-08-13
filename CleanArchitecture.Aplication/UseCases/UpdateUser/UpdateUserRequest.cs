using MediatR;

namespace CleanArchitecture.Aplication.UseCases.UpdateUser;

public sealed record UpdateUserRequest(Guid id, string Email, string Name) : IRequest<UpdateUserResponse>;
