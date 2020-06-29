using MediatR;

namespace B2BPolicyLambda.Dto.Commands.AddPolicy
{
    public class AddPolicyRequest : IRequest
    {
        public int Id { get; set; }
        public string Description { get; set; }
    }
}
