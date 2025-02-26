﻿// Ignore Spelling: apps, sampletypes, pidtypes, locationgroups, cultureinfo, pdf

namespace Skyware.Lis.AkitaModel;

/// <summary>
/// Akita constants.
/// </summary>
public class Constants
{

    /// <summary>
    /// Name of the HTTP header where api key is placed.
    /// </summary>
    public const string API_KEY_HEADER = "X-Api-Key";

    #region Core

#if LOCAL_TEST
    public const string URL_CORE_API_BASE = "";
#else
    public const string URL_CORE_API_BASE = "/apps/core";
#endif

    public const string URL_CORE_PART_PUBLIC_TESTS = "/api/public/tests";
    public const string URL_CORE_PUBLIC_TESTS = URL_CORE_API_BASE + URL_CORE_PART_PUBLIC_TESTS;
    public const string URL_CORE_PUBLIC_SINGLE_TEST = URL_CORE_API_BASE + URL_CORE_PART_PUBLIC_TESTS + "/{id}";

    public const string URL_CORE_PART_PUBLIC_SPECIES = "/api/public/species";
    public const string URL_CORE_PUBLIC_SPECIES = URL_CORE_API_BASE + URL_CORE_PART_PUBLIC_SPECIES;

    public const string URL_CORE_PART_PUBLIC_SAMPLE_TYPES = "/api/public/sampletypes";
    public const string URL_CORE_PUBLIC_SAMPLE_TYPES = URL_CORE_API_BASE + URL_CORE_PART_PUBLIC_SAMPLE_TYPES;

    public const string URL_CORE_PART_PUBLIC_PROFILES = "/api/public/profiles";
    public const string URL_CORE_PUBLIC_PROFILES = URL_CORE_API_BASE + URL_CORE_PART_PUBLIC_PROFILES;
    public const string URL_CORE_PUBLIC_SINGLE_PROFILE = URL_CORE_API_BASE + URL_CORE_PART_PUBLIC_PROFILES + "/{id}";

    public const string URL_CORE_PART_PUBLIC_PID_TYPES = "/api/public/pidtypes";
    public const string URL_CORE_PUBLIC_PID_TYPES = URL_CORE_API_BASE + URL_CORE_PART_PUBLIC_PID_TYPES;

    public const string URL_CORE_PART_PUBLIC_LOCATIONS = "/api/public/locations";
    public const string URL_CORE_PUBLIC_LOCATIONS = URL_CORE_API_BASE + URL_CORE_PART_PUBLIC_LOCATIONS;

    public const string URL_CORE_PART_PUBLIC_LOCATION_GROUPS = "/api/public/locationgroups";
    public const string URL_CORE_PUBLIC_LOCATION_GROUPS = URL_CORE_API_BASE + URL_CORE_PART_PUBLIC_LOCATION_GROUPS;

    public const string URL_CORE_PART_PUBLIC_FOOTNOTES = "/api/public/footnotes";
    public const string URL_CORE_PUBLIC_FOOTNOTES = URL_CORE_API_BASE + URL_CORE_PART_PUBLIC_LOCATION_GROUPS;

    public const string URL_CORE_PART_PUBLIC_DEPARTMENTS = "/api/public/departments";
    public const string URL_CORE_PUBLIC_DEPARTMENTS = URL_CORE_API_BASE + URL_CORE_PART_PUBLIC_DEPARTMENTS;

    public const string URL_CORE_PART_PUBLIC_CULTURE_INFO = "/api/public/cultureinfo";
    public const string URL_CORE_PUBLIC_CULTURE_INFO = URL_CORE_API_BASE + URL_CORE_PART_PUBLIC_CULTURE_INFO;

    public const string URL_CORE_PART_PUBLIC_PRICELIST = "/api/public/pricelist";
    public const string URL_CORE_PUBLIC_PRICELIST = URL_CORE_API_BASE + URL_CORE_PART_PUBLIC_PRICELIST;

    public const string URL_CORE_PART_SCHMEAS = "/api/schemas";
    public const string URL_CORE_SCHMEAS = URL_CORE_API_BASE + URL_CORE_PART_SCHMEAS;
    public const string URL_CORE_PUBLIC_SINGLE_SCHMEA = URL_CORE_API_BASE + URL_CORE_PART_SCHMEAS + "/{id}";

    public const string URL_CORE_PART_SALES = "/api/sales";
    public const string URL_CORE_SALES = URL_CORE_API_BASE + URL_CORE_PART_SALES;
    public const string URL_CORE_SINGLE_SALE = URL_CORE_SALES + "/{id}";
    public const string URL_CORE_SINGLE_SALE_ITEMS = URL_CORE_SINGLE_SALE + "/items";
    public const string URL_CORE_SINGLE_SALE_SAMPLES = URL_CORE_SINGLE_SALE + "/samples";
    public const string URL_CORE_SINGLE_SALE_ITEMS_RESULT = URL_CORE_SINGLE_SALE_ITEMS + "/{loincCode}/result";

    #endregion

    #region Robin


#if LOCAL_TEST
    public const string URL_ROBIN_API_BASE = "";
#else
    public const string URL_ROBIN_API_BASE = "/apps/robin";
#endif


    public const string URL_ROBIN_PART_DIRECT_REPORTS = "/api/direct-reports";
    public const string URL_ROBIN_DIRECT_REPORTS = URL_ROBIN_API_BASE + URL_ROBIN_PART_DIRECT_REPORTS;

    public const string URL_ROBIN_DIRECT_FULL_REPORT = URL_ROBIN_API_BASE + URL_ROBIN_PART_DIRECT_REPORTS + "/{id}/pdf";
    public const string URL_ROBIN_DIRECT_SIMPLE_REPORT = URL_ROBIN_API_BASE + URL_ROBIN_PART_DIRECT_REPORTS + "/{id}/simple-pdf";

    public const string ROBIN_REPORTS_HELLO_WORLD = "hello-world.jrxml";
    public const string ROBIN_REPORTS_BG_LAB_REFERRAL = "bg.nhif.referral.f4.jrxml";
    
    public const string ROBIN_REPORTS_LABORATORY_RESULTS = "laboratory-results.jrxml";
    
    public const string ROBIN_REPORTS_LAB_WORKLIST_BY_TEST = "lab-worklist-by-test.jrxml";
    public const string ROBIN_REPORTS_LAB_WORKLIST_FILTERS = "lab-worklist-filters.jrxml";
    public const string ROBIN_REPORTS_LAB_SAMPLES_TOTAL_BY_POINT = "lab-samples-total-by-point.jrxml";
    public const string ROBIN_REPORTS_LAB_SAMPLES_LIST = "lab-samples-list.jrxml";
    public const string ROBIN_REPORTS_LAB_SAMPLES_IN_LOCATION_BY_POINT = "lab-samples-in-location-by-point.jrxml";
    public const string ROBIN_REPORTS_LAB_PACKING_LIST = "lab-packing-list.jrxml";

    #endregion

    #region LIS Flagging

#if LOCAL_TEST
    public const string URL_FLAGGING_API_BASE = "";
#else
    public const string URL_FLAGGING_API_BASE = "/apps/flagging";
#endif

    public const string URL_FLAGGING_PART_TESTS = "/api/tests";
    public const string URL_FLAGGING_TESTS = URL_FLAGGING_API_BASE + URL_FLAGGING_PART_TESTS;
    public const string URL_FLAGGING_SINGLE_TEST = URL_FLAGGING_API_BASE + URL_FLAGGING_PART_TESTS + "/{id}";

    #endregion

    #region BgNhis

#if LOCAL_TEST
    public const string URL_BGNHIS_API_BASE = "";
#else
    public const string URL_BGNHIS_API_BASE = "/apps/bg-nhis";
#endif


    public const string URL_BASE_PART_REFERRALS = "/api/nhisreferrals";

    public const string URL_BASE_PART_CONTRACTS = "/api/contracts";

    public const string URL_BASE_PART_PRODUCTS_PACKAGES = "/api/products/packages";

    public const string URL_BASE_PART_PRODUCTS_EXAMINATIONS = "/api/products/examinations";

    public const string URL_BGNHIS_GET_PACKAGES = URL_BGNHIS_API_BASE + URL_BASE_PART_PRODUCTS_PACKAGES;

    public const string URL_BGNHIS_GET_EXAMINATIONS = URL_BGNHIS_API_BASE + URL_BASE_PART_PRODUCTS_EXAMINATIONS;

    public const string URL_BGNHIS_GET_REFERRAL = URL_BGNHIS_API_BASE + URL_BASE_PART_REFERRALS + "/{nrn}";

    public const string URL_BGNHIS_REFERRAL_ITEM = URL_BGNHIS_GET_REFERRAL + "/{code}";

    public const string URL_BGNHIS_SEARCH_REFERRALS = URL_BGNHIS_API_BASE + URL_BASE_PART_REFERRALS + "/search/{pid}";

    public const string URL_BGNHIS_GET_CONTRACTS = URL_BGNHIS_API_BASE + URL_BASE_PART_CONTRACTS;

    public const string URL_BGNHIS_POST_IMPORT = URL_BGNHIS_API_BASE + URL_BASE_PART_REFERRALS;


    #endregion

}
