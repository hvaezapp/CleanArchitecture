namespace CleanArchitecture.Application.Authentication.Commands.UserRegister;

public class AuthenticationCommandHandler(IApplicationUnitOfWork unitOfWork)
    : IRequestHandler<UserRegisterCommand, Guid>
{
    private readonly IApplicationUnitOfWork _uow = unitOfWork;

    public async Task<Guid> Handle(UserRegisterCommand request, CancellationToken cancellationToken = default)
    {
        var user = new User(request.FirstName, request.LastName, 
                            request.Email, request.UserName, 
                            request.Password, request.Gender);

        _uow.Users.Add(user);
        await _uow.SaveChangesAsync(cancellationToken);

        return user.Id;
    }
}