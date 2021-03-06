﻿using Serveur.Controllers.Server;
using ZeroFormatter;

namespace Serveur.Packets.ServerPackets
{
    [ZeroFormattable]
    public class GetSysInfo : IPackets
    {
        public override TypePackets Type
        {
            get
            {
                return TypePackets.GetSysInfo;
            }
        }

        public void Execute(ClientMosaique client)
        {
            client.send(this);
        }
    }
}
