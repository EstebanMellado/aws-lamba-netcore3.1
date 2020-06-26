using AutoMapper;
using B2B_Policy_Lambda.Dto.Commands.RemovePolicy;
using B2B_Policy_Lambda.Models;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace B2B_Policy_Lambda.Services.Commands.RemovePolicy
{
    public class RemovePolicyRequestHandler : IRequestHandler<RemovePolicyRequest>
    {
        private readonly IPolicyService _policyService;
        private readonly IMapper _mapper;

        public RemovePolicyRequestHandler(IPolicyService policyService, IMapper mapper)
        {
            _policyService = policyService ?? throw new ArgumentNullException(nameof(policyService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public Task<Unit> Handle(RemovePolicyRequest request, CancellationToken cancellationToken)
        {
            PolicyModel policy = _mapper.Map<PolicyModel>(request);
            _policyService.RemovePolicy(policy);
            throw new NotImplementedException();
        }
    }
}
