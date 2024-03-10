﻿using EggLink.DanhengServer.Enums;
using Newtonsoft.Json.Converters;
using System.Text.Json.Serialization;

namespace EggLink.DanhengServer.Data.Excel
{
    [ResourceEntity("InteractConfig.json")]
    public class InteractConfigExcel : ExcelResource
    {
        public int InteractID { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public PropStateEnum SrcState { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public PropStateEnum TargetState { get; set; } = PropStateEnum.Closed;

        public override int GetId()
        {
            return InteractID;
        }

        public override void Loaded()
        {
            GameData.InteractConfigData.Add(InteractID, this);
        }
    }
}
