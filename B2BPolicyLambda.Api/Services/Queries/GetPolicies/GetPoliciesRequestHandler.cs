﻿using AutoMapper;
using B2BPolicyLambda.Dto.Queries.GetPolicies;
using B2BPolicyLambda.Api.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace B2BPolicyLambda.Api.Services.Queries.GetPolicies
{
    public class GetPoliciesRequestHandler : IRequestHandler<GetPoliciesRequest, GetPoliciesResponse>
    {
        private readonly IPolicyService _policyService;
        private readonly IMapper _mapper;

        public GetPoliciesRequestHandler(IPolicyService policyService, IMapper mapper)
        {
            _policyService = policyService ?? throw new ArgumentNullException(nameof(policyService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        public Task<GetPoliciesResponse> Handle(GetPoliciesRequest request, CancellationToken cancellationToken)
        {
            List<PolicyModel> result = _policyService.GetPolicies();
            GetPoliciesResponse response = new GetPoliciesResponse()
            {
                Policies = _mapper.Map<List<PolicyModel>, IList<PolicyDto>>(result)
            };
            return Task.FromResult(response);
        }
    }
}
