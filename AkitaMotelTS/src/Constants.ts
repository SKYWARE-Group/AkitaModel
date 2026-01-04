/**
 * Skyware.Lis.AkitaModel
 */

// Ignore Spelling: apps, sampletypes, pidtypes, locationgroups, cultureinfo, pdf

/**
 * Akita constants.
 */
export class Constants {
  /**
   * Name of the HTTP header where api key is placed.
   */
  static readonly API_KEY_HEADER = 'X-Api-Key';

  // #region Core

  static readonly URL_CORE_API_BASE = '/apps/core';

  static readonly URL_CORE_PART_PUBLIC_TESTS = '/api/public/tests';
  static readonly URL_CORE_PUBLIC_TESTS = Constants.URL_CORE_API_BASE + Constants.URL_CORE_PART_PUBLIC_TESTS;
  static readonly URL_CORE_PUBLIC_SINGLE_TEST = Constants.URL_CORE_API_BASE + Constants.URL_CORE_PART_PUBLIC_TESTS + '/{id}';

  static readonly URL_CORE_PART_PUBLIC_SPECIES = '/api/public/species';
  static readonly URL_CORE_PUBLIC_SPECIES = Constants.URL_CORE_API_BASE + Constants.URL_CORE_PART_PUBLIC_SPECIES;

  static readonly URL_CORE_PART_PUBLIC_SAMPLE_TYPES = '/api/public/sampletypes';
  static readonly URL_CORE_PUBLIC_SAMPLE_TYPES = Constants.URL_CORE_API_BASE + Constants.URL_CORE_PART_PUBLIC_SAMPLE_TYPES;

  static readonly URL_CORE_PART_PUBLIC_PROFILES = '/api/public/profiles';
  static readonly URL_CORE_PUBLIC_PROFILES = Constants.URL_CORE_API_BASE + Constants.URL_CORE_PART_PUBLIC_PROFILES;
  static readonly URL_CORE_PUBLIC_SINGLE_PROFILE = Constants.URL_CORE_API_BASE + Constants.URL_CORE_PART_PUBLIC_PROFILES + '/{id}';

  static readonly URL_CORE_PART_PUBLIC_PID_TYPES = '/api/public/pidtypes';
  static readonly URL_CORE_PUBLIC_PID_TYPES = Constants.URL_CORE_API_BASE + Constants.URL_CORE_PART_PUBLIC_PID_TYPES;

  static readonly URL_CORE_PART_PUBLIC_LOCATIONS = '/api/public/locations';
  static readonly URL_CORE_PUBLIC_LOCATIONS = Constants.URL_CORE_API_BASE + Constants.URL_CORE_PART_PUBLIC_LOCATIONS;

  static readonly URL_CORE_PART_PUBLIC_LOCATION_GROUPS = '/api/public/locationgroups';
  static readonly URL_CORE_PUBLIC_LOCATION_GROUPS = Constants.URL_CORE_API_BASE + Constants.URL_CORE_PART_PUBLIC_LOCATION_GROUPS;

  static readonly URL_CORE_PART_PUBLIC_FOOTNOTES = '/api/public/footnotes';
  static readonly URL_CORE_PUBLIC_FOOTNOTES = Constants.URL_CORE_API_BASE + Constants.URL_CORE_PART_PUBLIC_LOCATION_GROUPS;

  static readonly URL_CORE_PART_PUBLIC_DEPARTMENTS = '/api/public/departments';
  static readonly URL_CORE_PUBLIC_DEPARTMENTS = Constants.URL_CORE_API_BASE + Constants.URL_CORE_PART_PUBLIC_DEPARTMENTS;

  static readonly URL_CORE_PART_PUBLIC_CULTURE_INFO = '/api/public/cultureinfo';
  static readonly URL_CORE_PUBLIC_CULTURE_INFO = Constants.URL_CORE_API_BASE + Constants.URL_CORE_PART_PUBLIC_CULTURE_INFO;

  static readonly URL_CORE_PART_PUBLIC_PRICELIST = '/api/public/pricelist';
  static readonly URL_CORE_PUBLIC_PRICELIST = Constants.URL_CORE_API_BASE + Constants.URL_CORE_PART_PUBLIC_PRICELIST;

  static readonly URL_CORE_PART_SCHMEAS = '/api/schemas';
  static readonly URL_CORE_SCHMEAS = Constants.URL_CORE_API_BASE + Constants.URL_CORE_PART_SCHMEAS;
  static readonly URL_CORE_PUBLIC_SINGLE_SCHMEA = Constants.URL_CORE_API_BASE + Constants.URL_CORE_PART_SCHMEAS + '/{id}';

  static readonly URL_CORE_PART_SALES = '/api/sales';
  static readonly URL_CORE_SALES = Constants.URL_CORE_API_BASE + Constants.URL_CORE_PART_SALES;
  static readonly URL_CORE_SINGLE_SALE = Constants.URL_CORE_SALES + '/{id}';
  static readonly URL_CORE_SINGLE_SALE_ITEMS = Constants.URL_CORE_SINGLE_SALE + '/items';
  static readonly URL_CORE_SINGLE_SALE_SAMPLES = Constants.URL_CORE_SINGLE_SALE + '/samples';
  static readonly URL_CORE_SINGLE_SALE_ITEMS_RESULT = Constants.URL_CORE_SINGLE_SALE_ITEMS + '/{loincCode}/result';

  // #endregion

  // #region Robin

  static readonly URL_ROBIN_API_BASE = '/apps/robin';

  static readonly URL_ROBIN_PART_DIRECT_REPORTS = '/api/direct-reports';
  static readonly URL_ROBIN_DIRECT_REPORTS = Constants.URL_ROBIN_API_BASE + Constants.URL_ROBIN_PART_DIRECT_REPORTS;

  static readonly URL_ROBIN_DIRECT_FULL_REPORT = Constants.URL_ROBIN_API_BASE + Constants.URL_ROBIN_PART_DIRECT_REPORTS + '/{id}/pdf';
  static readonly URL_ROBIN_DIRECT_SIMPLE_REPORT = Constants.URL_ROBIN_API_BASE + Constants.URL_ROBIN_PART_DIRECT_REPORTS + '/{id}/simple-pdf';

  static readonly ROBIN_REPORTS_HELLO_WORLD = 'hello-world.jrxml';
  static readonly ROBIN_REPORTS_BG_LAB_REFERRAL = 'bg.nhif.referral.f4.jrxml';

  static readonly ROBIN_REPORTS_LABORATORY_RESULTS = 'laboratory-results.jrxml';

  static readonly ROBIN_REPORTS_LAB_WORKLIST_BY_TEST = 'lab-worklist-by-test.jrxml';
  static readonly ROBIN_REPORTS_LAB_WORKLIST_FILTERS = 'lab-worklist-filters.jrxml';
  static readonly ROBIN_REPORTS_LAB_SAMPLES_TOTAL_BY_POINT = 'lab-samples-total-by-point.jrxml';
  static readonly ROBIN_REPORTS_LAB_SAMPLES_LIST = 'lab-samples-list.jrxml';
  static readonly ROBIN_REPORTS_LAB_SAMPLES_IN_LOCATION_BY_POINT = 'lab-samples-in-location-by-point.jrxml';
  static readonly ROBIN_REPORTS_LAB_PACKING_LIST = 'lab-packing-list.jrxml';

  // #endregion

  // #region LIS Flagging

  static readonly URL_FLAGGING_API_BASE = '/apps/flagging';

  static readonly URL_FLAGGING_PART_TESTS = '/api/tests';
  static readonly URL_FLAGGING_TESTS = Constants.URL_FLAGGING_API_BASE + Constants.URL_FLAGGING_PART_TESTS;
  static readonly URL_FLAGGING_SINGLE_TEST = Constants.URL_FLAGGING_API_BASE + Constants.URL_FLAGGING_PART_TESTS + '/{id}';

  // #endregion

  // #region BgNhis

  static readonly URL_BGNHIS_API_BASE = '/apps/bg-nhis';

  static readonly URL_BASE_PART_REFERRALS = '/api/nhisreferrals';

  static readonly URL_BASE_PART_CONTRACTS = '/api/contracts';

  static readonly URL_BASE_PART_PRODUCTS_PACKAGES = '/api/products/packages';

  static readonly URL_BASE_PART_PRODUCTS_EXAMINATIONS = '/api/products/examinations';

  static readonly URL_BGNHIS_GET_PACKAGES = Constants.URL_BGNHIS_API_BASE + Constants.URL_BASE_PART_PRODUCTS_PACKAGES;

  static readonly URL_BGNHIS_GET_EXAMINATIONS = Constants.URL_BGNHIS_API_BASE + Constants.URL_BASE_PART_PRODUCTS_EXAMINATIONS;

  static readonly URL_BGNHIS_GET_REFERRAL = Constants.URL_BGNHIS_API_BASE + Constants.URL_BASE_PART_REFERRALS + '/{nrn}';

  static readonly URL_BGNHIS_REFERRAL_ITEM = Constants.URL_BGNHIS_GET_REFERRAL + '/{code}';

  static readonly URL_BGNHIS_SEARCH_REFERRALS = Constants.URL_BGNHIS_API_BASE + Constants.URL_BASE_PART_REFERRALS + '/search/{pid}';

  static readonly URL_BGNHIS_GET_CONTRACTS = Constants.URL_BGNHIS_API_BASE + Constants.URL_BASE_PART_CONTRACTS;

  static readonly URL_BGNHIS_POST_IMPORT = Constants.URL_BGNHIS_API_BASE + Constants.URL_BASE_PART_REFERRALS;

  // #endregion
}
