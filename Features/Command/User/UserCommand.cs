using MediatR;

namespace _2025_epita_mediatr.Features.Command.User
{
    public record CreateUserCommand(string Name) : IRequest<UserProfile>;

    public class CreateUserHandler : IRequestHandler<CreateUserCommand, UserProfile>
    {
        public Task<UserProfile> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(new UserProfile { Id = 1, Name = request.Name });
        }
    }
}
