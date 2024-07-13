// Ignore Spelling: apps, sampletypes, pidtypes, locationgroups, cultureinfo, pdf

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

    public const string URL_CORE_API_BASE = "/apps/core";

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

    #endregion

    #region Robin

    public const string URL_ROBIN_API_BASE = "/apps/robin";

    public const string URL_ROBIN_PART_DIRECT_REPORTS = "/api/direct-reports";
    public const string URL_ROBIN_DIRECT_REPORTS = URL_ROBIN_API_BASE + URL_ROBIN_PART_DIRECT_REPORTS;

    public const string URL_ROBIN_DIRECT_FULL_REPORT = URL_ROBIN_API_BASE + URL_ROBIN_PART_DIRECT_REPORTS + "/{id}/pdf";
    public const string URL_ROBIN_DIRECT_SIMPLE_REPORT = URL_ROBIN_API_BASE + URL_ROBIN_PART_DIRECT_REPORTS + "/{id}/simple-pdf";

    public const string ROBIN_REPORTS_HELLO_WORLD = "hello-world.jrxml";
    public const string ROBIN_REPORTS_BG_LAB_REFERRAL = "bg.nhif.referral.f4.jrxml";

    #endregion

    #region LIS Flagging

    public const string URL_FLAGGING_API_BASE = "/apps/flagging";

    public const string URL_FLAGGING_PART_TESTS = "/api/tests";
    public const string URL_FLAGGING_TESTS = URL_FLAGGING_API_BASE + URL_FLAGGING_PART_TESTS;
    public const string URL_FLAGGING_SINGLE_TEST = URL_FLAGGING_API_BASE + URL_FLAGGING_PART_TESTS + "/{id}";

    #endregion

    #region BgNhis

    public const string URL_BGNHIS_API_BASE = "/apps/bg-nhis";

    public const string URL_BASE_PART_REFERRALS = "/api/nhisreferrals";

    public const string URL_BASE_PART_CONTRACTS = "/api/contracts";

    public const string URL_BGNHIS_GET_REFERRAL = URL_BGNHIS_API_BASE + URL_BASE_PART_REFERRALS + "/{nrn}";

    public const string URL_BGNHIS_SEARCH_REFERRALS = URL_BGNHIS_API_BASE + URL_BASE_PART_REFERRALS + "/search/{pid}";

    public const string URL_BGNHIS_GET_CONTRACTS = URL_BGNHIS_API_BASE + URL_BASE_PART_CONTRACTS;

    #endregion

}
