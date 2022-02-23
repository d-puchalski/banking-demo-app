import { CalculationOwnerAddressModel } from './CalculationOwnerAddressModel';
import { CalculationOwnerConsentsModel } from './CalculationOwnerConsentsModel';

export class CalculationOwnerModel {
  public ssn: number = 0;
  public firstName: string = '';
  public lastName: string = '';
  public birthDate: string = '';
  public address: CalculationOwnerAddressModel | null = null;
  public consents: CalculationOwnerConsentsModel | null = null;
}
