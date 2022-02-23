using BankingDemo.Core.Extensions.Scoring.Interface.Models;

namespace BankingDemo.Core.Extensions.Scoring.Interface {
    public abstract class IScoring {

        public IScoring() {
            
        }

        public abstract Task<ScoringResult> Score(ScoringRequest request);

        public abstract void Init(ConfigurationRequest conf);

    }
}