/**
 * Skyware.Lis.AkitaModel
 */

import { ProfileItem } from './ProfileItem';

/**
 * Represents Set of tests in LIS db
 */
export class Profile {
  /**
   * PK is LIS Database
   */
  id!: number;

  /**
   * Name of the profile
   */
  name?: string;

  longName?: string;

  departmentId!: number;

  rank!: number;

  rankGlobal!: number;

  loincCode?: string;

  isActive!: boolean;

  lastModified!: Date;

  items?: ProfileItem[];
}
