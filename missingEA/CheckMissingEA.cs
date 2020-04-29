using MongoDB.Driver;
using missingEA.Models;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace missingEA
{
    public class CheckMissingEA
    {
        IMongoCollection<ResultDataEA> CollectionResultDataEA { get; set; }
        IMongoCollection<ResultDataAreaCode> CollectionResultDataAreaCode { get; set; }
        IMongoCollection<EAInfo> CollectionEAInfo { get; set; }
        public CheckMissingEA()
        {
            var client = new MongoClient("mongodb://firstclass:Th35F1rstCla55@mongoquickx4h3q4klpbxtq-vm0.southeastasia.cloudapp.azure.com/wdata");
            var database = client.GetDatabase("wdata");
            CollectionResultDataEA = database.GetCollection<ResultDataEA>("ResultDataEA");
            CollectionEAInfo = database.GetCollection<EAInfo>("ea");
            CollectionResultDataAreaCode = database.GetCollection<ResultDataAreaCode>("ResultDataAreaCode");
        }

        public List<string> missingEA()
        {
            var allEA = CollectionEAInfo.Find(it => true).ToList();
            var result = new List<string>();
            foreach (var item in allEA)
            {
                var find = CollectionResultDataEA.Find(it => it._id == item._id).FirstOrDefault();
                if (find == null)
                {
                    System.Console.WriteLine(item._id + "NO Found!!");
                    result.Add(item._id);
                }
                else
                {
                    System.Console.WriteLine(item._id + "Found iT.");
                }
            }
            return result;
        }

        public List<string> missingArea(){
            var allArea = CollectionEAInfo.Find(it => true).ToList();
            var group = allArea.GroupBy(it => it.Area_Code).ToList();
            var result= new List<string>();
            foreach (var item in group)
            {
                var find = CollectionResultDataAreaCode.Find(it => it._id == item.Key).FirstOrDefault();
                if (find == null)
                {
                    System.Console.WriteLine(item.Key + "  Not Found.");
                    result.Add(item.Key);
                }else
                {
                    System.Console.WriteLine(item.Key + "  Found it.");
                }
            }
            return result;
        }
    }
}