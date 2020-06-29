using B2BPolicyLambda.Api.Models;
using System.Collections.Generic;

namespace B2BPolicyLambda.Api.Services
{
    public interface IPolicyService
    {
        List<PolicyModel> GetPolicies();
        void AddPolicy(PolicyModel policy);
        void RemovePolicy(PolicyModel policy);
    }
}
