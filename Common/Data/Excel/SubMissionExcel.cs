﻿using EggLink.DanhengServer.Data.Config;
using Newtonsoft.Json;

namespace EggLink.DanhengServer.Data.Excel
{
    [ResourceEntity("SubMission.json")]
    public class SubMissionExcel : ExcelResource
    {
        public int SubMissionID { get; set; }

        [JsonIgnore()]
        public int MainMissionID { get; set; }
        [JsonIgnore()]
        public MissionInfo? MainMissionInfo { get; set; }
        [JsonIgnore()]
        public SubMissionInfo? SubMissionInfo { get; set; }

        public override int GetId()
        {
            return SubMissionID;
        }

        public override void Loaded()
        {
            GameData.SubMissionData[GetId()] = this;
        }
    }
}
