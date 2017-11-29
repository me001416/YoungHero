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
            npcList = new List<NpcData>();

            npcList.Add(new NpcData(100004, "厲蒼龍"));
            npcList.Add(new NpcData(100006, "樊未離"));
            npcList.Add(new NpcData(100007, "納蘭衍"));
            npcList.Add(new NpcData(100008, "凌香兒"));
            npcList.Add(new NpcData(100009, "任天翔"));
            npcList.Add(new NpcData(100010, "羅蛇君"));
            npcList.Add(new NpcData(100011, "姬無雙"));
            npcList.Add(new NpcData(100017, "無瑕子"));
            npcList.Add(new NpcData(100018, "玄冥子"));
            npcList.Add(new NpcData(100019, "老胡"));
            npcList.Add(new NpcData(100022, "賈雲長"));
            npcList.Add(new NpcData(100023, "雷震天"));
            npcList.Add(new NpcData(100024, "趙驚風"));
            npcList.Add(new NpcData(100025, "賽飛鴻"));
            npcList.Add(new NpcData(100026, "醉仙"));
            npcList.Add(new NpcData(100027, "橘叟"));
            npcList.Add(new NpcData(100028, "神醫"));
            npcList.Add(new NpcData(100029, "仙音"));
            npcList.Add(new NpcData(100030, "書生"));
            npcList.Add(new NpcData(100031, "丹青"));
            npcList.Add(new NpcData(100033, "沈瀾"));
            npcList.Add(new NpcData(100034, "劍聖"));
            npcList.Add(new NpcData(100037, "方雲華"));
            npcList.Add(new NpcData(100038, "卓人清"));
            npcList.Add(new NpcData(100040, "古葉"));
            npcList.Add(new NpcData(100041, "莊人駿"));
            npcList.Add(new NpcData(100042, "武當弟子"));
            npcList.Add(new NpcData(100044, "無因方丈"));
            npcList.Add(new NpcData(100045, "無色"));
            npcList.Add(new NpcData(100046, "無慧"));
            npcList.Add(new NpcData(100047, "無嗔"));
            npcList.Add(new NpcData(100048, "無戒"));
            npcList.Add(new NpcData(100049, "少林門人"));
            npcList.Add(new NpcData(200022, "塔婭"));
            npcList.Add(new NpcData(200039, "岳胖子"));
            npcList.Add(new NpcData(210001, "谷月軒"));
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

        public int ReturnId(string SrcName)
        {
            int result = 0;

            npcList.ForEach(x =>
            {
                if (x.NpcName == SrcName)
                {
                    result = x.NpcId;
                }
            });

            return result;
        }
    }
}
