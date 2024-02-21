using Freelance.Application.ViewModels.Authentication;
using MediatR;

namespace Freelance.Application.Authentication.Commands.Register;

public record RegisterCommand(
    string Email,
    string Password,
    string Role) : IRequest<AuthenticationResponse>;
