using BankingDemo.Core.CalculationModule.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace BankingDemo.Core.CalculationService.Controllers {
    public interface ICalculatorController {
        /// <summary>
        /// Activation
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<ActionResult<bool>> Put([FromQuery]Guid request);

        /// <summary>
        /// Create calculation
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<ActionResult<GetCalculationResponse>> Post([FromBody]GetCalculationRequest request);
    }
}
