using MediatR;

namespace B2B_Policy_Lambda.Dto.Commands.AddPolicy
{
    public class AddPolicyRequest : IRequest
    {
        public int Id { get; set; }
        public string Description { get; set; }
    }
}
