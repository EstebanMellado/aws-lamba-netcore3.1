using AutoMapper;
using B2B_Policy_Lambda.Dto.Commands.AddPolicy;
using B2B_Policy_Lambda.Dto.Commands.RemovePolicy;
using B2B_Policy_Lambda.Dto.Queries.GetPolicies;
using B2B_Policy_Lambda.Models;

namespace B2B_Policy_Lambda.Mapper.Profiles
{
    public class PolicyProfile : Profile
    {
        public PolicyProfile()
        {
            CreateMap<PolicyModel, PolicyDto>();
            CreateMap<AddPolicyRequest, PolicyModel>();
            CreateMap<RemovePolicyRequest, PolicyModel>();
        }
    }
}
