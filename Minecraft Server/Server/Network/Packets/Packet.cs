using Minecraft_Server.Framework.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft_Server.Server.Network.Packets
{
    class Packett : Framework.Network.Packet
    {
        private byte opcode = 2;

        public static Packet Read(TcpClientm d)
        {
            return null;
        }
        public override void Write()
        {
        }
    }
}
