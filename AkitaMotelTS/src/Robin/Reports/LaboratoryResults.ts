/**
 * Skyware.Lis.AkitaModel.Robin.Reports
 */

import { Sale } from '../../Sale';
import { Patient } from '../../Patient';
import { Doctor } from '../../Doctor';
import { SaleItem } from '../../SaleItem';
import { Footnote } from '../../Footnote';

/**
 * Data model for report "Laboratory results".
 * @deprecated Use Results.VisitResults instead.
 */
export class LaboratoryResults {
  /**
   * Sale/Visit data.
   */
  visit?: Sale;

  /**
   * Patient data
   */
  patient?: Patient;

  /**
   * Doctors data
   */
  referringDoctors: Doctor[] = [];

  /**
   * List of results
   */
  results: SaleItem[] = [];

  /**
   * Footnotes list.
   */
  footnotes: Footnote[] = [];
}
