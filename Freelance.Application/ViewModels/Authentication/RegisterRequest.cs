namespace Freelance.Application.ViewModels.Authentication;

public record RegisterRequest(
        string Email,
        string Password
    );

