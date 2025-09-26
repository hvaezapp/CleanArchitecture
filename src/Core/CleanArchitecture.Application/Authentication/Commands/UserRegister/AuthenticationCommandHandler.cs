using CleanArchitecture.Application.Common.Interfaces;

namespace CleanArchitecture.Application.Authentication.Commands.UserRegister;

public class AuthenticationCommandHandler(IApplicationUnitOfWork unitOfWork , ISmsAdapter smsAdapter)
    : IRequestHandler<UserRegisterCommand, Guid>
{
    private readonly IApplicationUnitOfWork _uow = unitOfWork;
    private readonly ISmsAdapter _smsAdapter = smsAdapter;

    public async Task<Guid> Handle(UserRegisterCommand request, CancellationToken cancellationToken = default)
    {
        var user = new User(request.FirstName, request.LastName, 
                            request.Mobile, request.Email, request.UserName, 
                            request.Password, request.Address,
                            request.Gender);

        _uow.Users.Add(user);
        await _uow.SaveChangesAsync(cancellationToken);

        // send registration sms to user
         await _smsAdapter.SendAsync(user.Mobile, $"Welcome {user},Your Registation Successfull");

        return user.Id;
    }
}