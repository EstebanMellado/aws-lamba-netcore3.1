using MediatR;

namespace B2B_Policy_Lambda.Dto.Commands.RemovePolicy
{
    public class RemovePolicyRequest : IRequest
    {
        public int PolicyId { get; set; }
        public RemovePolicyRequest(int id) => PolicyId = id;
    }
}
