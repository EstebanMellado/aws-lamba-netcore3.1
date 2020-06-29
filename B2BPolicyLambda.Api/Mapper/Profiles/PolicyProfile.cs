using AutoMapper;
using B2BPolicyLambda.Dto.Commands.AddPolicy;
using B2BPolicyLambda.Dto.Commands.RemovePolicy;
using B2BPolicyLambda.Dto.Queries.GetPolicies;
using B2BPolicyLambda.Api.Models;

namespace B2BPolicyLambda.Api.Mapper.Profiles
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
