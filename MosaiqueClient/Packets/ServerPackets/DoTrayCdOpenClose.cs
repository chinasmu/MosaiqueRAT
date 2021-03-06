﻿using Client.Controllers;
using ZeroFormatter;

namespace Client.Packets.ServerPackets
{
    [ZeroFormattable]
    public class DoTrayCdOpenClose : IPackets
    {
        public override TypePackets Type
        {
            get
            {
                return TypePackets.DoTrayCdOpenClose;
            }
        }

        [Index(0)]
        public virtual bool open { get; set; }

        public DoTrayCdOpenClose()
        {
        }

        public DoTrayCdOpenClose(bool open)
        {
            this.open = open;
        }

        public void Execute(ClientMosaique client)
        {
            client.send(this);
        }
    }
}
