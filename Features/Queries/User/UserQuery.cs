using MediatR;

namespace _2025_epita_mediatr.Features.Queries.User
{
    public record GetUserByIdQuery(int userId) : IRequest<UserProfile>;

    public  class GetUserByIdHandler : IRequestHandler<GetUserByIdQuery, UserProfile>
    {
        public Task<UserProfile> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(new UserProfile { Id = request.userId, Name = "User" });
        }
    }

}
