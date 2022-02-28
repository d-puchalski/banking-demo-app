using BankingDemo.Core.CalculationModule.Mappings;
using BankingDemo.Core.CalculationModule.Models;
using BankingDemo.Core.Extensions.EF.Connections;
using BankingDemo.Core.Extensions.EF.Models;
using BankingDemo.Core.Extensions.Scoring.Factory;
using BankingDemo.Core.Extensions.Scoring.Interface.Models;
using BankingDemo.Core.Extensions.Shared;
using Microsoft.Extensions.Logging;

namespace BankingDemo.Core.CalculationModule {
    public class CalculatorService : CustomServiceBase<ICalculatorService>, ICalculatorService {
        public CalculatorService(ILogger<ICalculatorService> logger) : base(logger) {

        }
        public async Task<bool> Activation(Guid request) {
            using (CosmosDB db = new CosmosDB()) {
                var item = db.Calculations.FirstOrDefault(q => q.Seq == request);
                //TODO: Extend model to set activation after document scoring
                db.Update(item);
                return await db.SaveChangesAsync() > 0;
            }
        }

        public async Task<GetCalculationResponse> Create(GetCalculationRequest request) {
            var (valid, response) = await CheckClientValues(request);
            if (valid) {
                var scoreResult = await Score(request);
                response.ScoringResult = (Enums.ScoringResultEnum)Enum.Parse(typeof(Enums.ScoringResultEnum), scoreResult.Score.ToString());
                if (scoreResult != null && scoreResult.Score == ScoringResultEnum.Positive) {
                    //we are not storing score results
                    var mapper = MapperMaps.CalculationMapper().CreateMapper();
                    var calculationEF = mapper.Map<Calculation>(request);
                    using (CosmosDB db = new CosmosDB()) {
                        calculationEF.Seq = Guid.NewGuid();
                        await db.AddAsync(calculationEF);
                        await db.SaveChangesAsync();
                        response.UID = calculationEF.Seq;
                    }
                }
            }

            return response;
        }

        public async Task<ScoringResult> Score(GetCalculationRequest request) {
            return await new ScoringFactory(ScoringValidationModelsEnum.LA_BANCA_EXECUTOR).Score(new ScoringRequest {
                TotalAmount = request.Amount,
                PeriodicAmount = request.Instalment,
                SSN = request.Owner.SSN
            });
        }

        public async Task<(bool, GetCalculationResponse)> CheckClientValues(GetCalculationRequest request) {
            var response = new GetCalculationResponse();
            response.Rate = 10;
            double q = 1 + (Convert.ToDouble(response.Rate) / 100 / 12);
            double s = Math.Pow(q, request.Periods);
            double f = Convert.ToDouble(request.Amount) * s * (q - 1);
            double r = f / (s - 1);
            response.Instalment = Convert.ToDecimal(r);
            response.Total = response.Instalment * request.Periods;

            response.Instalment = Math.Round(response.Instalment, 2);
            response.Total = Math.Round(response.Total, 2);

            if (request.TotalCost == response.Total && request.Instalment == response.Instalment) {
                return await Task.FromResult((true, response));
            }
            return await Task.FromResult((false, response));
        }

        private bool validateLoanValues(GetCalculationRequest request, GetCalculationResponse response) {
            if(request.TotalCost == response.Total && request.Instalment == response.Instalment)
                return true;
            throw new InvalidOperationException("Calculation compared values are invalid");
        }

        private GetCalculationResponse calculateLoanValues(GetCalculationRequest request) {
            //we repeating the calculation, to check values from client
            GetCalculationResponse response = new GetCalculationResponse();
            response.Total = request.TotalCost;
            response.Rate = request.Rate;
            response.ScoringResult = Enums.ScoringResultEnum.Control;
            return response;
        }
    }
}
