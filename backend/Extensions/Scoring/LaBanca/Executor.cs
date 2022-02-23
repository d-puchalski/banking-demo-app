using BankingDemo.Core.Extensions.Scoring.Interface;
using BankingDemo.Core.Extensions.Scoring.Interface.Models;

namespace LaBanca {
    public class Executor : IScoring {

        private readonly int PositiveScore = 80;
        private readonly int ControlScore = 50;

        public override void Init(ConfigurationRequest conf) {
            //nothing to do here :)
        }

        public override async Task<ScoringResult> Score(ScoringRequest request) {
            //no real scoring here, just a mockup
            ScoringResult response = new ScoringResult();
            var score = new Random().Next(0, 100);
            if (score < ControlScore) response.Score = ScoringResultEnum.Negative;
            else if(score > ControlScore && score < PositiveScore) response.Score = ScoringResultEnum.Control;
            else if(score > PositiveScore) response.Score = ScoringResultEnum.Positive;

            //super special case :)
            if (request.SSN == "123") response.Score = ScoringResultEnum.Positive;
            return await Task.FromResult(response);
        }
    }
}