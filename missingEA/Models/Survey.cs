using System;
using Newtonsoft.Json;

namespace missingEA.Models
{
    public class Survey
    {
        public Survey(string _id, string sampleId, string sampleType, string name, string buildingId, string province, string userId, string eA, string srcUserId, string srcEA, string containerName, string blobName, DateTime lastUpdate, string status, bool enlisted, bool hasWarning, int hasWarningWater, bool hasWarningMsg, string resolutionId) 
        {
            this._id = _id;
                this.SampleId = sampleId;
                this.SampleType = sampleType;
                this.Name = name;
                this.BuildingId = buildingId;
                this.Province = province;
                this.UserId = userId;
                this.EA = eA;
                this.SrcUserId = srcUserId;
                this.SrcEA = srcEA;
                this.ContainerName = containerName;
                this.BlobName = blobName;
                this.LastUpdate = lastUpdate;
                this.Status = status;
                this.Enlisted = enlisted;
                this.HasWarning = hasWarning;
                this.HasWarningWater = hasWarningWater;
                this.HasWarningMsg = hasWarningMsg;
                this.ResolutionId = resolutionId;
               
        }
                public string _id { get; set; }
        public string SampleId { get; set; }
        public string SampleType { get; set; }
        public string Name { get; set; }
        public string BuildingId { get; set; }
        public string Province { get; set; }
        public string UserId { get; set; }
        [JsonProperty("ea")]
        public string EA { get; set; }
        public string SrcUserId { get; set; }
        [JsonProperty("srcea")]
        public string SrcEA { get; set; }
        public string ContainerName { get; set; }
        public string BlobName { get; set; }
        public DateTime LastUpdate { get; set; }
        public string Status { get; set; }
        public int?[] Accesses { get; set; }
        public bool Enlisted { get; set; }
        public bool HasWarning { get; set; }
        public int HasWarningWater { get; set; }
        public bool HasWarningMsg { get; set; }
        public string ResolutionId { get; set; }
        public DateTime? DeletionDateTime { get; set; }
        public DateTime? CreationDateTime { get; set; }
    }
}