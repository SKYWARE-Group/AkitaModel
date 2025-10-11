/**
 * Skyware.Lis.AkitaModel
 */

import { Product } from './Product';

export class Schema {
  id!: number;
  name?: string;
  hasDoctor!: boolean;
  hasFund1!: boolean;
  fund1Id?: number;
  //fund1?: Fund;
  hasFund2!: boolean;
  fund2Id?: number;
  //fund2?: Fund;
  field1?: string;
  field2?: string;
  field3?: string;
  isActive!: boolean;
  saleTypeId?: number;
  items?: Product[];
  //enabledFunds?: Fund[];
  //enabledPidTypes?: PatientIdType[];
}
