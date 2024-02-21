using Freelance.Application.Authentication.Commands.Register;
using Freelance.Application.Authentication.Queries.Login;
using Freelance.Application.ViewModels;
using Freelance.Application.ViewModels.Authentication;
using MapsterMapper;
using MediatR;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Mvc;

namespace Freelance.Application.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthenticationController : ControllerBase
{
    private readonly ISender _mediator;
    private readonly IMapper _mapper;

    public AuthenticationController(ISender mediator, IMapper mapper)
    {
        _mediator = mediator;
        _mapper = mapper;
    }

    [HttpPost("register")]
    public async Task<ActionResult> Register(RegisterRequest request, string role)
    {
        //mapping error to be fixed ...!
        //var command = _mapper.Map<RegisterCommand>((request, role));
        var command = new RegisterCommand(
            request.Email,
            request.Password,
            role
            );

        var response = await _mediator.Send(command);

        return Ok(response);
    }

    [HttpPost("login")]
    public async Task<ActionResult> Login(LoginQuery request)
    {

        var response = await _mediator.Send(request);

        return Ok(response);
    }
}
