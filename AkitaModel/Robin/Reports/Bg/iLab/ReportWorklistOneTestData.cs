using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Skyware.Lis.AkitaModel.Robin.Reports.Bg.iLab
{
    /// <summary>
    /// Модел за генериране на справка "Неготови по тест: ".
    /// </summary>
    public class ReportWorklistOneTestData : IReportDataObject
    {
        private static JsonSerializerOptions _Opts;

        private static JsonSerializerOptions Opts
        {
            get
            {
                if (_Opts is null)
                {
                    _Opts = new()
                    {
                        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
                        PropertyNameCaseInsensitive = true,
                        PropertyNamingPolicy = JsonNamingPolicy.CamelCase
                    };
                    _Opts.Converters.Add(new CustomDateTimeConverter("yyyy-MM-dd"));
                };
                return _Opts;
            }
        }

        /// <summary>
        /// Баркод/Визита
        /// </summary>
        public string SampleVisitId { get; private set; } =string.Empty;

        /// <summary>
        /// Инфотмация за пациента
        /// </summary>
        public string PatientInfo { get; private set; } =string.Empty;

        /// <summary>
        /// Пациентът е мъж
        /// </summary>
        public bool? IsMale {  get; set; }  =null;

        /// <summary>
        /// Serialize to JSON and converts it to Base64 string.
        /// </summary>
        /// <returns></returns>
        public string GetBase64Data()
        {
            return Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(JsonSerializer.Serialize(this, Opts)));
        }
    }
}
