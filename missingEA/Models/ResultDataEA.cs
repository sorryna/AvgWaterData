using Newtonsoft.Json;
using System.Collections.Generic;

namespace missingEA.Models
{
    public class ResultDataEA
    {
        public string _id { get; set; }
        /// <summary>
        /// index1
        /// </summary>
        /// <value></value>
        public int? IsAgriculture { get; set; }
        /// <summary>
        /// index2
        /// </summary>
        /// <value></value>
        public int? IsHouseHold { get; set; }
        /// <summary>
        /// index3
        /// </summary>
        /// <value></value>
        public int? IsHouseHoldGoodPlumbing { get; set; }
        /// <summary>
        /// index4
        /// </summary>
        /// <value></value>
        public int? IsAgricultureHasIrrigationField { get; set; }
        /// <summary>
        /// index5
        /// </summary>
        /// <value></value>
        public int? IsHouseHoldHasPlumbingDistrict { get; set; }
        /// <summary>
        /// index6
        /// </summary>
        /// <value></value>
        public int? IsHouseHoldHasPlumbingCountryside { get; set; }
        /// <summary>
        /// index7
        /// </summary>
        /// <value></value>
        public int? IsFactorialWaterQuality { get; set; }
        /// <summary>
        /// index8
        /// </summary>
        /// <value></value>
        public int? IsCommercialWaterQuality { get; set; }
        /// <summary>
        /// index10
        /// </summary>
        /// <value></value>
        public int? CountPopulation { get; set; }
        /// <summary>
        /// index11
        /// </summary>
        /// <value></value>
        public int? CountWorkingAge { get; set; }
        /// <summary>
        /// index12
        /// </summary>
        /// <value></value>
        public int? IsFactorial { get; set; }
        /// <summary>
        /// index13
        /// </summary>
        /// <value></value>
        public int? IsFactorialWaterTreatment { get; set; }
        /// <summary>
        /// index14
        /// </summary>
        /// <value></value>
        public int? IsCommunityWaterManagementHasWaterTreatment { get; set; }
        /// <summary>
        /// index15
        /// </summary>
        /// <value></value>
        public double? FieldCommunity { get; set; }
        /// <summary>
        /// indeex16
        /// </summary>
        /// <value></value>
        public double? AvgWaterHeightCm { get; set; }
        /// <summary>
        /// index17
        /// </summary>
        /// <value></value>
        public double? TimeWaterHeightCm { get; set; }
        /// <summary>
        /// index18
        /// </summary>
        /// <value></value>
        public double? HasntPlumbing { get; set; }
        /// <summary>
        /// index19
        /// </summary>
        /// <value></value>
        public int? IsGovernment { get; set; }
        /// <summary>
        /// index20
        /// </summary>
        /// <value></value>
        public int? IsGovernmentUsage { get; set; }
        /// <summary>
        /// index21
        /// </summary>
        /// <value></value>
        public int? IsGovernmentWaterQuality { get; set; }
        /// <summary>
        /// index22
        /// </summary>
        /// <value></value>
        public int? CommunityNatureDisaster { get; set; }
        /// <summary>
        /// index24
        /// </summary>
        /// <value></value>
        public int? IndustryHasWasteWaterTreatment { get; set; }
        /// <summary>
        /// index25
        /// </summary>
        /// <value></value>
        public int? PeopleInFloodedArea { get; set; }
        /// <summary>
        /// index39
        /// </summary>
        /// <value></value>
        public int? CountCommunity { get; set; }
        /// <summary>
        /// index40
        /// </summary>
        /// <value></value>
        public int? CountCommunityHasDisaster { get; set; }
        /// <summary>
        /// index41
        /// </summary>
        /// <value></value>
        public int? IsAllHouseHoldCountryside { get; set; }
        /// <summary>
        /// index42
        /// </summary>
        /// <value></value>
        public int? IsAllHouseHoldDistrict { get; set; }
        /// <summary>
        /// index43
        /// </summary>
        /// <value></value>
        public int? IsAllFactorial { get; set; }
        /// <summary>
        /// index44
        /// </summary>
        /// <value></value>
        public int? IsAllCommercial { get; set; }
        /// <summary>
        /// index9.1EA
        /// </summary>
        /// <value></value>
        public double? CountGroundWaterUnit { get; set; }
        /// <summary>
        /// index9.2EA
        /// </summary>
        /// <value></value>
        public double? CountGroundWaterCom { get; set; }
        /// <summary>
        /// index23.1EA
        /// </summary>
        /// <value></value>
        public double? WaterSourcesUnit { get; set; }
        /// <summary>
        /// index23.2EA
        /// </summary>
        /// <value></value>
        public double? WaterSourcesCom { get; set; }
        public string AMP { get; set; }
        public string AMP_NAME { get; set; }
        public string Area_Code { get; set; }
        public string CWT { get; set; }
        public string CWT_NAME { get; set; }
        public string REG { get; set; }
        public string REG_NAME { get; set; }
        public string TAM { get; set; }
        public string TAM_NAME { get; set; }
        public string EA { get; set; }
        public string MUN { get; set; }
        public string MUN_NAME { get; set; }
        public string TAO { get; set; }
        public string TAO_NAME { get; set; }
        public string VIL { get; set; }
        public string VIL_NAME { get; set; }
        public int? DISTRICT { get; set; }
        public int? MAP_STATUS { get; set; }
        public int? Building { get; set; }
        public int? Household { get; set; }
        public int? population { get; set; }
        public int? Agricultural_HH { get; set; }
        public string ES_BUSI { get; set; }
        public string ES_INDUS { get; set; }
        public string ES_HOTEL { get; set; }
        public string ES_PV_HOS { get; set; }
        public string REMARK { get; set; }
        public string linkcode { get; set; }
        [JsonProperty("Center")]
        public MongoDB.Bson.BsonDocument Center { get; set; }
        public double? Flag { get; set; }

    }

}