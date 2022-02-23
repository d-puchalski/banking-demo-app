import { CalculationOwnerModel } from './CalculationOwnerModel';

export class CalculationModel {
  public seq: string = '00000000-0000-0000-0000-000000000000';
  public amount: number = 0;
  public periods: number = 0;
  public instalment: number = 0;
  public rate: number = 0;
  public totalCost: number = 0;
  public owner: CalculationOwnerModel | null = null;
}
