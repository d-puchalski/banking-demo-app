import { ScoringResultEnum } from './ScoringResultEnum';

export class GetCalculationResponseModel {
  public uid: string = '';
  public instalment: number = 0;
  public rate : number = 0;
  public total: number = 0;
  public scoringResult : ScoringResultEnum = ScoringResultEnum.Negative;
}
