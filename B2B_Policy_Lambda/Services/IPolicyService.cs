using B2B_Policy_Lambda.Models;
using System.Collections.Generic;

namespace B2B_Policy_Lambda.Services
{
    public interface IPolicyService
    {
        List<PolicyModel> GetPolicies();
        void AddPolicy(PolicyModel policy);
        void RemovePolicy(PolicyModel policy);
    }
}
