using System.Collections.Generic;

namespace B2BPolicyLambda.Dto.Queries.GetPolicies
{
    public class GetPoliciesResponse
    {
        public IList<PolicyDto> Policies { get; set; }
    }

    public class PolicyDto
    {
        public int Id { get; set; }
        public string Description { get; set; }
    }
}
