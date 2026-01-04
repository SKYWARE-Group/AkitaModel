/**
 * Skyware.Lis.AkitaModel
 */

import { Patient } from './Patient';
import { Doctor } from './Doctor';
import { SaleItem } from './SaleItem';
import { Sample } from './Sample';

/**
 * Sale, laboratory order.
 */
export class Sale {
  /**
   * PK in LIS iLab.
   */
  id?: number;

  /**
   * Reference to an external system.
   */
  externalId: string = '';

  /**
   * Date and time the sale was created.
   */
  registered?: Date;

  /**
   * Patient.
   */
  patient?: Patient;

  /**
   * FK to sale schema.
   */
  schemaId?: number;

  /**
   *  Sale schema name.
   */
  schemaName: string = '';

  /**
   * FK to location where registration was made.
   */
  locationId?: number;

  /**
   * Custom field #1.
   */
  field1: string = '';

  /**
   * Custom field #2.
   */
  field2: string = '';

  /**
   * Custom field #3.
   */
  field3: string = '';

  /**
   * Priority
   */
  isStat?: boolean;

  /**
   * Referring doctor.
   */
  doctor?: Doctor;

  /**
   * Visit's examinations.
   */
  items?: SaleItem[];

  /**
   * Samples to the visit.
   */
  samples?: Sample[];

  /**
   * Name of first fund
   */
  fund1Name?: string;

  /**
   * Name of second fund
   */
  fund2Name?: string;

  // public List<Note>? Notes { get; set; }
}
