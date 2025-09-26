namespace CleanArchitecture.Application.Authentication.Queries.UserLogin;

public class UserLoginQueryHandler(IApplicationUnitOfWork unitOfWork)
    : IRequestHandler<UserLoginQuery, UserDto>
{
    private readonly IApplicationUnitOfWork _uow = unitOfWork;

    public async Task<UserDto> Handle(UserLoginQuery request,
                                      CancellationToken cancellationToken = default)
    {
        var user = await _uow.Users.Where(x => x.UserName == request.Username && x.Password == request.Password)
                                   .Select(x => new UserDto(x.FirstName, x.LastName , x.Mobile , x.Email))
                                   .FirstOrDefaultAsync(cancellationToken);
        return user ?? null;
    }
}
