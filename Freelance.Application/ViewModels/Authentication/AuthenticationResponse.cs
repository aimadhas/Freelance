namespace Freelance.Application.ViewModels.Authentication;

public record AuthenticationResponse(
        string Email,
        string Token,
        string Message
    );
