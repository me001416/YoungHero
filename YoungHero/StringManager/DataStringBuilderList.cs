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

            for(var i = 0; i < dsList.Count;i++)
            {
                if(dsList[i].SbList.Count < 3)
                {
                    if(i == 0)
                    {
                        continue;
                    }

                    foreach (var x in dsList[i].SbList)
                    {
                        dsList[i - 1].Add(x);
                    }

                    dsList.RemoveAt(i);

                    i--;
                }
            }

            foreach (var x in dsList)
            {
                sb.Append("(MarkHsu)\n");

                foreach (var y in x.SbList)
                {
                    sb.Append(y);
                }
            }

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
