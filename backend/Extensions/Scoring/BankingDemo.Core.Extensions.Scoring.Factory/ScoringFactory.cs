using BankingDemo.Core.Extensions.Scoring.Interface.Models;
using LaBanca;

namespace BankingDemo.Core.Extensions.Scoring.Factory {
    public class ScoringFactory {
        private readonly ScoringValidationModelsEnum model;
        public ScoringFactory(ScoringValidationModelsEnum _model) {
            model = _model;
        }

        public virtual async Task<ScoringResult> Score(ScoringRequest request) {
            ScoringResult response = new ScoringResult();
            if (model == ScoringValidationModelsEnum.LA_BANCA_EXECUTOR) {
                Executor x = new Executor();
                x.Init(new ConfigurationRequest());
                response = await x.Score(request);
            }
            return response;
        }
    }
}