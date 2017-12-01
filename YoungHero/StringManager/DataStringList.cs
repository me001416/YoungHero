using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoungHero.StringManager
{
    public class DataStringList
    {
        public List<DataString> dsList { get; private set; }

        public DataStringList()
        {
            dsList = new List<DataString>();
        }

        public void Add(string SrcSb)
        {
            if (dsList.Count == 0)
            {
                this.New();
            }

            dsList[dsList.Count - 1].Add(SrcSb);
        }

        public void Add(string SrcSb, int SrcIndex)
        {
            dsList[SrcIndex].Add(SrcSb);
        }

        public void New()
        {
            dsList.Add(new DataString(dsList.Count - 1));
        }

        public void New(int SrcIndex)
        {
            dsList.Add(new DataString(SrcIndex));
        }
    }

    public class DataString
    {
        public List<string> SbList { get; private set; }
        int Index;

        public DataString()
        {
            Index = 0;
            SbList = new List<string>();
        }

        public DataString(int SrcIndex)
        {
            Index = SrcIndex;
            SbList = new List<string>();
        }

        public void Add(string SrcSb)
        {
            SbList.Add(SrcSb);
        }
    }
}
