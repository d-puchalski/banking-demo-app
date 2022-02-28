using BankingDemo.Core.CalculationModule.Models;
using BankingDemo.Core.Extensions.Scoring.Interface.Models;
using Microsoft.Extensions.Logging;
using NUnit.Framework;
using System.Threading.Tasks;

namespace BankingDemo.Core.CalculationModule.Test {
    public class CalculationModuleTests {
        private ICalculatorService _service;
        private ILogger<ICalculatorService> _logger;


        [SetUp]
        public void Setup() {
            _logger = new LoggerFactory().CreateLogger<ICalculatorService>();
            _service = new CalculatorService(_logger);
        }

        [Test]
        public async Task checkClientValues_Test_True() {
            var request = new GetCalculationRequest();
            request.Amount = 40000M;
            request.Periods = 12;
            request.TotalCost = 42199.63M;
            request.Instalment = 3516.64M;

            var result = await _service.CheckClientValues(request);

            Assert.IsNotNull(result);
            Assert.AreEqual(result.Item1, true);
            Assert.Multiple(() => {
                Assert.AreEqual(result.Item2.Total, request.TotalCost);
                Assert.AreEqual(result.Item2.Instalment, request.Instalment);
            });
        }

        [Test]
        public async Task checkClientValues_Test_False() {
            var request = new GetCalculationRequest();
            request.Amount = 40000M;
            request.Periods = 12;

            var result = await _service.CheckClientValues(request);

            Assert.IsNotNull(result);
            Assert.AreEqual(result.Item1, false);
            Assert.Multiple(() => {
                Assert.AreEqual(result.Item2.Total, 42199.63M);
                Assert.AreEqual(result.Item2.Instalment, 3516.64M);
            });
        }

        [Test]
        public async Task score_Test_True() {
            var request = new GetCalculationRequest();
            request.Owner = new Extensions.EF.Models.CalculationOwner();
            request.Owner.SSN = "123";

            var result = await _service.Score(request);

            Assert.IsNotNull(result);
            Assert.AreEqual(result.Score, ScoringResultEnum.Positive);
        }

        [Test]
        public async Task score_Test_False() {
            var request = new GetCalculationRequest();
            request.Owner = new Extensions.EF.Models.CalculationOwner();
            request.Owner.SSN = "123123";

            var result = await _service.Score(request);

            Assert.IsNotNull(result);
            Assert.AreNotEqual(result.Score, ScoringResultEnum.Positive);
        }

    }
}