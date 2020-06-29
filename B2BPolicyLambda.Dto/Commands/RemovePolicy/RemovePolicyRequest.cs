using MediatR;

namespace B2BPolicyLambda.Dto.Commands.RemovePolicy
{
    public class RemovePolicyRequest : IRequest
    {
        public int PolicyId { get; set; }
        public RemovePolicyRequest(int id) => PolicyId = id;
    }
}
