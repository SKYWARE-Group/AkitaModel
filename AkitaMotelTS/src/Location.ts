/**
 * Skyware.Lis.AkitaModel
 */

import { LocationGroup } from './LocationGroup';

/**
 * Laboratory location, e.g. "Central lab", "Reception North", etc.
 * @remarks
 * Location is a physical place where laboratory performs activities.
 * It could be central laboratory, satellite laboratory or sample collection point.
 * Location is the base concept in sample logistics, analytics, KPI, etc. It also
 * define reports identity, operation limitations, etc.
 */
export class Location {
  /**
   * PK in LIS iLab.
   */
  id!: number;

  /**
   * Name of the location, e.g. "Central lab", etc.
   */
  name?: string;

  /**
   * Description of the location, e.g. "Sample collection point in Medical Center North.", etc.
   */
  description?: string;

  /**
   * Soft delete field.
   * @remarks
   * If this field is **false**, it mustn't be used as shipment destination,
   * as a location in new visit registrations, etc.
   */
  isActive: boolean = true;

  code?: string;

  //isMicrobiology?: boolean;

  documentProfileId!: number;

  //documentProfile?: DocumentProfile;

  typeId!: number;

  //locationType?: LocationType;

  city?: string;

  postalCode?: string;

  address?: string;

  phone1?: string;

  phone2?: string;

  email?: string;

  latitude?: number;

  longitude?: number;

  webVisible: boolean = true;

  acceptCards: boolean = true;

  disabilitiesAccess: boolean = true;

  publicNote?: string;

  publicNoteMarkup: boolean = false;

  //internalNote?: string;

  groupId!: number;

  /**
   * The LocationGroup this location belongs to.
   */
  locationGroup?: LocationGroup;

  canReceiveSamples: boolean = true;

  globalId?: string;

  created?: Date;

  createdBy?: string;

  modified?: Date;

  modifiedBy?: string;

  //processingPoints?: ProcessingPoint[];
}
