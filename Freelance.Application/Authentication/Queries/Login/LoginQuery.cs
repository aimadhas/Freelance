using Freelance.Application.ViewModels.Authentication;
using MediatR;

namespace Freelance.Application.Authentication.Queries.Login;

public record LoginQuery(
    string Email,
    string Password
    ) : IRequest<AuthenticationResponse>;
