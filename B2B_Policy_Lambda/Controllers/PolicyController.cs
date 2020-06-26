using B2B_Policy_Lambda.Dto.Commands.AddPolicy;
using B2B_Policy_Lambda.Dto.Commands.RemovePolicy;
using B2B_Policy_Lambda.Dto.Queries.GetPolicies;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;

namespace B2B_Policy_Lambda.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PolicyController : ControllerBase
    {
        protected readonly IMediator _mediator;

        public PolicyController(IMediator mediator)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }

        [HttpGet]
        public IActionResult GetPolicies()
        {
            var result = _mediator.Send(new GetPoliciesRequest());
            return Ok(result.Result);
        }

        [HttpPost]
        public IActionResult AddPolicy([FromBody] AddPolicyRequest request)
        {
            _mediator.Send(request);
            return Ok();
        }

        [HttpDelete]
        public IActionResult RemovePolicy([FromBody] RemovePolicyRequest request)
        {
            _mediator.Send(request);
            return Ok();
        }
    }
}
