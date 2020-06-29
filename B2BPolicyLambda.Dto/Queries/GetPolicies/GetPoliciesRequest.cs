using MediatR;

namespace B2BPolicyLambda.Dto.Queries.GetPolicies
{
    public class GetPoliciesRequest : IRequest<GetPoliciesResponse>
    {
    }
}
