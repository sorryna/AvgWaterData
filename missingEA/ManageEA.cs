using missingEA.Models;
using MongoDB.Driver;
using System.Collections.Generic;
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
            CollectionResultDataEA = database.GetCollection<ResultDataEA>("ResultNewDataEAClean");
            CollectionEAInfo = database.GetCollection<EAInfo>("ea");
            CollectionResultDataAreaCode = database.GetCollection<ResultDataAreaCode>("ResultNewDataAreaCode");
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
                        Flag=2,
                    };
                    CollectionResultDataEA.InsertOne(avg);
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
                        Flag = 2
                    };
                    CollectionResultDataAreaCode.InsertOne(sum);
                }
            }
        }

        public void MsArea(List<string> MsAreaMsArea)
        {
            foreach (var item in MsAreaMsArea)
            {
                var result = CollectionResultDataAreaCode.Find(it => it._id == item).FirstOrDefault();
                var findEAInfo = CollectionEAInfo.Find(it => it.Area_Code == item).FirstOrDefault();
                var findResultArea = CollectionResultDataAreaCode.Find(it => it.CWT == findEAInfo.CWT && it.AMP == findEAInfo.AMP).ToList();
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
                    CountGroundWaterCom = result.CountGroundWaterCom == 0 ? (int)findResultArea.Average(it => it.CountGroundWaterCom) : result.CountGroundWaterCom,
                    CountGroundWaterUnit = result.CountGroundWaterUnit == 0 ? (int)findResultArea.Average(it => it.CountGroundWaterUnit) : result.CountGroundWaterUnit,
                    CubicMeterGroundWaterForAgriculture = result.CubicMeterGroundWaterForAgriculture == 0 ? findResultArea.Average(it => it.CubicMeterGroundWaterForAgriculture) : result.CubicMeterGroundWaterForAgriculture,
                    CubicMeterGroundWaterForDrink = result.CubicMeterGroundWaterForDrink == 0 ? findResultArea.Average(it => it.CubicMeterGroundWaterForDrink) : result.CubicMeterGroundWaterForDrink,
                    CubicMeterGroundWaterForProduct = result.CubicMeterGroundWaterForProduct == 0 ? findResultArea.Average(it => it.CubicMeterGroundWaterForProduct) : result.CubicMeterGroundWaterForProduct,
                    CubicMeterGroundWaterForService = result.CubicMeterGroundWaterForService == 0 ? findResultArea.Average(it => it.CubicMeterGroundWaterForService) : result.CubicMeterGroundWaterForService,
                    CubicMeterGroundWaterForUse = result.CubicMeterGroundWaterForUse == 0 ? findResultArea.Average(it => it.CubicMeterGroundWaterForUse) : result.CubicMeterGroundWaterForUse,
                    CubicMeterPlumbingForAgriculture = result.CubicMeterPlumbingForAgriculture == 0 ? findResultArea.Average(it => it.CubicMeterPlumbingForAgriculture) : result.CubicMeterPlumbingForAgriculture,
                    CubicMeterPlumbingForDrink = result.CubicMeterPlumbingForDrink == 0 ? findResultArea.Average(it => it.CubicMeterPlumbingForDrink) : result.CubicMeterPlumbingForDrink,
                    CubicMeterPlumbingForProduct = result.CubicMeterPlumbingForProduct == 0 ? findResultArea.Average(it => it.CubicMeterPlumbingForProduct) : result.CubicMeterPlumbingForProduct,
                    CubicMeterPlumbingForService = result.CubicMeterPlumbingForService == 0 ? findResultArea.Average(it => it.CubicMeterPlumbingForService) : result.CubicMeterPlumbingForService,
                    CubicMeterSurfaceForAgriculture = result.CubicMeterSurfaceForAgriculture == 0 ? findResultArea.Average(it => it.CubicMeterSurfaceForAgriculture) : result.CubicMeterSurfaceForAgriculture,
                    CubicMeterSurfaceForDrink = result.CubicMeterSurfaceForDrink == 0 ? findResultArea.Average(it => it.CubicMeterSurfaceForDrink) : result.CubicMeterSurfaceForDrink,
                    CubicMeterSurfaceForProduct = result.CubicMeterSurfaceForProduct == 0 ? findResultArea.Average(it => it.CubicMeterSurfaceForProduct) : result.CubicMeterSurfaceForProduct,
                    CubicMeterSurfaceForService = result.CubicMeterSurfaceForService == 0 ? findResultArea.Average(it => it.CubicMeterSurfaceForService) : result.CubicMeterSurfaceForService,
                    WaterSourcesCom = result.WaterSourcesCom == 0 ? findResultArea.Average(it => it.WaterSourcesCom) : result.WaterSourcesCom,
                    WaterSourcesUnit = result.WaterSourcesUnit == 0 ? findResultArea.Average(it => it.WaterSourcesUnit) : result.WaterSourcesUnit,
                    Flag = 2
                };
                //CollectionResultDataAreaCode.UpdateOne(it => it._id == item, Builders<ResultDataAreaCode>.Update.Set(x=>x.CountGroundWaterCom == sum.CountGroundWaterCom));
                //CollectionResultDataAreaCode.ReplaceOne(it => it._id == item, sum);
            }

        }
    }
}