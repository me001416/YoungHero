using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoungHero
{
    public class NpcData
    {
        private bool updated;

        private int npcId;
        public int NpcId
        {
            get { return npcId; }
            set
            {
                npcId = value;
            }
        }
    }
}
