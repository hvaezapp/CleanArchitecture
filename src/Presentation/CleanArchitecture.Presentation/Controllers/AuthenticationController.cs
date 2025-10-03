﻿namespace CleanArchitecture.Presentation.Controllers;

public class AuthenticationController : BaseController
{
    [HttpPost]
    public async Task<ActionResult<Guid>> Register([FromBody] UserRegisterCommand userRegisterCommand,
        CancellationToken cancellationToken = default)
       => await Mediator.Send(userRegisterCommand, cancellationToken);

    [HttpPost]
    public async Task<ActionResult<UserDto>> Login([FromBody] UserLoginQuery loginQuery,
        CancellationToken cancellationToken = default)
       => await Mediator.Send(loginQuery, cancellationToken);
}