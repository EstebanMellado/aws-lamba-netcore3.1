using B2B_Policy_Lambda.Models;
using B2B_Policy_Lambda.Services;
using Microsoft.AspNetCore.Mvc;
using System;

namespace B2B_Policy_Lambda.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PolicyController : ControllerBase
    {
        private readonly IPolicyService _policyService;
        public PolicyController(IPolicyService policyService)
        {
            _policyService = policyService ?? throw new ArgumentNullException(nameof(policyService));
        }
        [HttpGet]
        public IActionResult GetPolicies()
        {
            var result = _policyService.GetPolicies();
            return Ok(result);
        }

        [HttpPost]
        public IActionResult AddPolicy([FromBody] PolicyModel policy)
        {
            _policyService.AddPolicy(policy);
            return Ok();
        }

        [HttpDelete]
        public IActionResult RemovePolicy([FromBody] PolicyModel policy)
        {
            _policyService.RemovePolicy(policy);
            return Ok();
        }
    }
}
