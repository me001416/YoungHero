using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoungHero.StringManager
{
    public class DataStringBuilderList
    {
        public List<DataStringBuilder> dsList { get; private set; }

        public DataStringBuilderList()
        {
            dsList = new List<DataStringBuilder>();
        }

        public void Add(StringBuilder SrcSb)
        {
            if (dsList.Count == 0)
            {
                this.New();
            }

            dsList[dsList.Count - 1].Add(SrcSb);
        }

        public void Add(StringBuilder SrcSb, int SrcIndex)
        {
            dsList[SrcIndex].Add(SrcSb);
        }

        public void New()
        {
            dsList.Add(new DataStringBuilder(dsList.Count - 1));
        }

        public void New(int SrcIndex)
        {
            dsList.Add(new DataStringBuilder(SrcIndex));
        }

        public string FormatFileData(int SelectMode = 1)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(@"""NeigongList"":[");

            foreach (var x in dsList)
            {
                for(var i = 0; i < x.SbList.Count; i++)
                {
                    if(x.SbList.Count < 2)
                    {
                        continue;
                    }

                    if(i == 0)
                    {
                        sb.Append(@"{""id"":""");
                        sb.Append(x.SbList[i]);
                        sb.Append(@""",");
                    }
                    else if (i == x.SbList.Count-1)
                    {
                        sb.Append(@"""");
                        sb.Append(x.SbList[i]);
                        sb.Append(@"""}");

                        ///
                        /// 分行，方便驗證結果
                        ///
                        sb.Append("\n");
                    }
                    else
                    {
                        sb.Append(x.SbList[i]);
                    }
                }
            }

            sb.Append("]");

            return sb.ToString();
        }
    }

    public class DataStringBuilder
    {
        public List<StringBuilder> SbList { get; private set; }
        int Index;

        public DataStringBuilder()
        {
            Index = 0;
            SbList = new List<StringBuilder>();
        }

        public DataStringBuilder(int SrcIndex)
        {
            Index = SrcIndex;
            SbList = new List<StringBuilder>();
        }

        public void Add(StringBuilder SrcSb)
        {
            SbList.Add(SrcSb);
        }
    }
}
