
using Freelance.Domain.Models;

namespace Freelance.Application.Authentication.Common.Interfaces;

public interface IJwtTokenGenerator
{
    string GenerateToken(User user);
}
