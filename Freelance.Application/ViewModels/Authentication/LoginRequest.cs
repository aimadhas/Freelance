namespace Freelance.Application.ViewModels.Authentication;

public record LoginRequest(
    string Email,
    string Password
);
