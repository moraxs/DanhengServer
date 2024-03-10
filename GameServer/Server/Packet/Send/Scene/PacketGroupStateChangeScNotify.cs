﻿using EggLink.DanhengServer.Enums;
using EggLink.DanhengServer.Proto;

namespace EggLink.DanhengServer.Server.Packet.Send.Scene
{
    public class PacketGroupStateChangeScNotify : BasePacket
    {
        public PacketGroupStateChangeScNotify(int entryId, int groupId, PropStateEnum propState) : base(CmdIds.GroupStateChangeScNotify)
        {
            var notify = new GroupStateChangeScNotify()
            {
                GroupStateInfo = new GroupStateInfo()
                {
                    EntryId = (uint)entryId,
                    GroupId = (uint)groupId,
                    GroupState = (uint)propState,
                }
            };

            SetData(notify);
        }
    }
}
