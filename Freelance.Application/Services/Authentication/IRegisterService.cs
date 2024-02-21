using Freelance.Application.Authentication.Commands.Register;
using Freelance.Application.ViewModels.Authentication;

namespace Freelance.Application.Services.Authentication;

public interface IRegisterService
{
    Task<AuthenticationResponse> Register(RegisterCommand command);
}
