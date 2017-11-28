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

        private string npcName;
        public string NpcName
        {
            get { return npcName; }
            set
            {
                npcName = value;
            }
        }

        public NpcData(int srcId, string srcName)
        {
            NpcId = srcId;
            NpcName = srcName;
        }
    }

    public class NpcList
    {
        public List<NpcData> npcList { get; private set; }

        public NpcList()
        {
            npcList.Add(new NpcData(210001, "谷月軒"));
            npcList.Add(new NpcData(200022, "塔婭"));
            npcList.Add(new NpcData(200039, "岳胖子"));
        }

        public bool IsPresent(int SrcID)
        {
            bool result = false;

            npcList.ForEach(x =>
            {
                if (x.NpcId == SrcID)
                {
                    result = true;
                }
            });

            return result;
        }

        public string ReturnName(int SrcID)
        {
            string str = string.Empty;

            npcList.ForEach(x =>
            {
                if (x.NpcId == SrcID)
                {
                    str = x.NpcName;
                }
            });

            return str;
        }
    }
}
