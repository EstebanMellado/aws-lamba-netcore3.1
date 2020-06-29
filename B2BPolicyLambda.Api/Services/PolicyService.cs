using B2BPolicyLambda.Api.Models;
using System.Collections.Generic;

namespace B2BPolicyLambda.Api.Services
{
    public class PolicyService : IPolicyService
    {
        private readonly List<PolicyModel> _policyStorage = new List<PolicyModel>();

        public void AddPolicy(PolicyModel policy)
        {
            _policyStorage.Add(policy);
        }

        public List<PolicyModel> GetPolicies()
        {
            return _policyStorage;
        }

        public void RemovePolicy(PolicyModel policy)
        {
            _policyStorage.Remove(policy);
        }
    }
}
