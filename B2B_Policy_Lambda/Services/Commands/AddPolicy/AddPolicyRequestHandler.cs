using AutoMapper;
using B2B_Policy_Lambda.Dto.Commands.AddPolicy;
using B2B_Policy_Lambda.Models;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace B2B_Policy_Lambda.Services.Commands.AddPolicy
{
    public class AddPolicyRequestHandler : IRequestHandler<AddPolicyRequest>
    {
        private readonly IPolicyService _policyService;
        private readonly IMapper _mapper;

        public AddPolicyRequestHandler(IPolicyService policyService, IMapper mapper)
        {
            _policyService = policyService ?? throw new ArgumentNullException(nameof(policyService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public Task<Unit> Handle(AddPolicyRequest request, CancellationToken cancellationToken)
        {
            PolicyModel policy = _mapper.Map<PolicyModel>(request);
            _policyService.AddPolicy(policy);
            return Task.FromResult(Unit.Value);
        }
    }
}
