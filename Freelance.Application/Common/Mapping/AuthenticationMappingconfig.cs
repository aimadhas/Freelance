using Freelance.Application.Authentication.Commands.Register;
using Freelance.Application.ViewModels.Authentication;
using Mapster;

namespace Freelance.Application.Common.Mapping;

public class AuthenticationMappingconfig : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<(RegisterRequest Request, string Role), RegisterCommand>()
            .Map(dest => dest.Role, src => src.Role)
            .Map(dest => dest, src => src.Request);

    }
}
