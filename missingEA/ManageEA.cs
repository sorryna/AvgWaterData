using missingEA.Models;
using MongoDB.Driver;
using System.IO;
using System.Linq;

namespace missingEA
{
    public class ManageEA
    {
        IMongoCollection<ResultDataEA> CollectionResultDataEA { get; set; }
        IMongoCollection<ResultDataAreaCode> CollectionResultDataAreaCode { get; set; }
        IMongoCollection<EAInfo> CollectionEAInfo { get; set; }

        public ManageEA()
        {
            var client = new MongoClient("mongodb://firstclass:Th35F1rstCla55@mongoquickx4h3q4klpbxtq-vm0.southeastasia.cloudapp.azure.com/wdata");
            var database = client.GetDatabase("wdata");
            CollectionResultDataEA = database.GetCollection<ResultDataEA>("ResultDataEA");
            CollectionEAInfo = database.GetCollection<EAInfo>("ea");
            CollectionResultDataAreaCode = database.GetCollection<ResultDataAreaCode>("ResultDataAreaCode");
        }

        public void EA()
        {
            var path = @"MissingEA.txt";
            var lines = System.IO.File.ReadAllLines(path);
            foreach (var item in lines)
            {
                System.Console.WriteLine(item);
                var findEAInfo = CollectionEAInfo.Find(it => it._id == item).FirstOrDefault();
                var findResultEA = CollectionResultDataEA.Find(it => it.Area_Code == findEAInfo.Area_Code).ToList();
                if (findResultEA != null)
                {
                    var avg = new ResultDataEA
                    {
                        _id = item,
                        REG = findEAInfo.REG,
                        REG_NAME = findEAInfo.REG_NAME,
                        CWT = findEAInfo.CWT,
                        CWT_NAME = findEAInfo.CWT_NAME,
                        AMP = findEAInfo.AMP,
                        AMP_NAME = findEAInfo.AMP_NAME,
                        TAM = findEAInfo.TAM,
                        TAM_NAME = findEAInfo.TAM_NAME,
                        MUN = findEAInfo.MUN,
                        MUN_NAME = findEAInfo.MUN_NAME,
                        TAO = findEAInfo.TAO,
                        TAO_NAME = findEAInfo.TAO_NAME,
                        VIL = findEAInfo.VIL,
                        VIL_NAME = findEAInfo.VIL_NAME,
                        Area_Code = findEAInfo.Area_Code,
                        EA = findEAInfo.EA,
                        AvgWaterHeightCm = findResultEA.Average(it => it.AvgWaterHeightCm),
                        CommunityNatureDisaster = (int)findResultEA.Average(it => it.CommunityNatureDisaster),
                        CountCommunity = (int)findResultEA.Average(it => it.CountCommunity),
                        CountCommunityHasDisaster = (int)findResultEA.Average(it => it.CountCommunityHasDisaster),
                        CountGroundWaterCom = (int)findResultEA.Average(it => it.CountGroundWaterCom),
                        CountGroundWaterUnit = (int)findResultEA.Average(it => it.CountGroundWaterUnit),
                        CountPopulation = (int)findResultEA.Average(it => it.CountPopulation),
                        CountWorkingAge = (int)findResultEA.Average(it => it.CountWorkingAge),
                        FieldCommunity = (int)findResultEA.Average(it => it.FieldCommunity),
                        HasntPlumbing = findResultEA.Average(it => it.HasntPlumbing),
                        IndustryHasWasteWaterTreatment = (int)findResultEA.Average(it => it.IndustryHasWasteWaterTreatment),
                        IsAgriculture = (int)findResultEA.Average(it => it.IsAgriculture),
                        IsAgricultureHasIrrigationField = (int)findResultEA.Average(it => it.IsAgricultureHasIrrigationField),
                        IsAllCommercial = (int)findResultEA.Average(it => it.IsAllCommercial),
                        IsAllFactorial = (int)findResultEA.Average(it => it.IsAllFactorial),
                        IsAllHouseHoldCountryside = (int)findResultEA.Average(it => it.IsAllHouseHoldCountryside),
                        IsAllHouseHoldDistrict = (int)findResultEA.Average(it => it.IsAllHouseHoldDistrict),
                        IsCommercialWaterQuality = (int)findResultEA.Average(it => it.IsCommercialWaterQuality),
                        IsCommunityWaterManagementHasWaterTreatment = (int)findResultEA.Average(it => it.IsCommunityWaterManagementHasWaterTreatment),
                        IsFactorial = (int)findResultEA.Average(it => it.IsFactorial),
                        IsFactorialWaterQuality = (int)findResultEA.Average(it => it.IsFactorialWaterQuality),
                        IsFactorialWaterTreatment = (int)findResultEA.Average(it => it.IsFactorialWaterTreatment),
                        IsGovernment = (int)findResultEA.Average(it => it.IsGovernment),
                        IsGovernmentUsage = (int)findResultEA.Average(it => it.IsGovernmentUsage),
                        IsGovernmentWaterQuality = (int)findResultEA.Average(it => it.IsGovernmentWaterQuality),
                        IsHouseHold = (int)findResultEA.Average(it => it.IsHouseHold),
                        IsHouseHoldGoodPlumbing = (int)findResultEA.Average(it => it.IsHouseHoldGoodPlumbing),
                        IsHouseHoldHasPlumbingCountryside = (int)findResultEA.Average(it => it.IsHouseHoldHasPlumbingCountryside),
                        IsHouseHoldHasPlumbingDistrict = (int)findResultEA.Average(it => it.IsHouseHoldHasPlumbingDistrict),
                        PeopleInFloodedArea = (int)findResultEA.Average(it => it.PeopleInFloodedArea),
                        TimeWaterHeightCm = findResultEA.Average(it => it.TimeWaterHeightCm),
                        WaterSourcesCom = findResultEA.Average(it => it.WaterSourcesCom),
                        WaterSourcesUnit = findResultEA.Average(it => it.WaterSourcesUnit),
                    };
                    // TODO: Create it in Data Base
                }
            }
        }

        public void Area()
        {
            var path = @"MissingArea.txt";
            var lines = System.IO.File.ReadAllLines(path);
            foreach (var item in lines)
            {
                var findEAInfo = CollectionEAInfo.Find(it => it.Area_Code == item).FirstOrDefault();
                var findResultArea = CollectionResultDataAreaCode.Find(it => it.CWT == findEAInfo.CWT && it.AMP == findEAInfo.AMP).ToList();
                if (findResultArea != null)
                {
                    var sum = new ResultDataAreaCode
                    {
                        _id = item,
                        REG = findEAInfo.REG,
                        REG_NAME = findEAInfo.REG_NAME,
                        CWT = findEAInfo.CWT,
                        CWT_NAME = findEAInfo.CWT_NAME,
                        AMP = findEAInfo.AMP,
                        AMP_NAME = findEAInfo.AMP_NAME,
                        TAM = findEAInfo.TAM,
                        TAM_NAME = findEAInfo.TAM_NAME,
                        CountGroundWaterCom = (int)findResultArea.Average(it => it.CountGroundWaterCom),
                        CountGroundWaterUnit = (int)findResultArea.Average(it => it.CountGroundWaterUnit),
                        CubicMeterGroundWaterForAgriculture = findResultArea.Average(it => it.CubicMeterGroundWaterForAgriculture),
                        CubicMeterGroundWaterForDrink = findResultArea.Average(it => it.CubicMeterGroundWaterForDrink),
                        CubicMeterGroundWaterForProduct = findResultArea.Average(it => it.CubicMeterGroundWaterForProduct),
                        CubicMeterGroundWaterForService = findResultArea.Average(it => it.CubicMeterGroundWaterForService),
                        CubicMeterGroundWaterForUse = findResultArea.Average(it => it.CubicMeterGroundWaterForUse),
                        CubicMeterPlumbingForAgriculture = findResultArea.Average(it => it.CubicMeterPlumbingForAgriculture),
                        CubicMeterPlumbingForDrink = findResultArea.Average(it => it.CubicMeterPlumbingForDrink),
                        CubicMeterPlumbingForProduct = findResultArea.Average(it => it.CubicMeterPlumbingForProduct),
                        CubicMeterPlumbingForService = findResultArea.Average(it => it.CubicMeterPlumbingForService),
                        CubicMeterSurfaceForAgriculture = findResultArea.Average(it => it.CubicMeterSurfaceForAgriculture),
                        CubicMeterSurfaceForDrink = findResultArea.Average(it => it.CubicMeterSurfaceForDrink),
                        CubicMeterSurfaceForProduct = findResultArea.Average(it => it.CubicMeterSurfaceForProduct),
                        CubicMeterSurfaceForService = findResultArea.Average(it => it.CubicMeterSurfaceForService),
                        WaterSourcesCom = findResultArea.Average(it => it.WaterSourcesCom),
                        WaterSourcesUnit = findResultArea.Average(it => it.WaterSourcesUnit),
                    };
                    // TODO: Create it in Data Base
                }
            }
        }
    }
}