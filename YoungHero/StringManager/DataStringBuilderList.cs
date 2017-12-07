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
            string str = string.Empty;

            if(SelectMode == 1)
            {
                str = Neigong();
            }

            return str;
        }

        private string NPC()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(@"""NPCList"":[");

            ///
            /// 分行，方便驗證結果
            ///
            sb.Append("\n");

            foreach (var x in dsList)
            {
                for (var i = 0; i < x.SbList.Count; i++)
                {
                    if (x.SbList.Count < 2)
                    {
                        continue;
                    }

                    if (i == 0)
                    {
                        sb.Append(@"{""id"":""");
                        sb.Append(x.SbList[i]);
                        sb.Append(@""",");
                    }
                    else if (i == 1)
                    {
                        sb.Append(@"""s3DModel"":""");
                        sb.Append(x.SbList[i]);
                        sb.Append(@""",");
                    }
                    else if (i == 2)
                    {
                        sb.Append(@"""sMaxImage"":""");
                        sb.Append(x.SbList[i]);
                        sb.Append(@""",");
                    }
                    else if (i == 3)
                    {
                        sb.Append(@"""sAllImage"":""");
                        sb.Append(x.SbList[i]);
                        sb.Append(@""",");
                    }
                    else if (i == 4)
                    {
                        sb.Append(@"""sMemberImage"":""");
                        sb.Append(x.SbList[i]);
                        sb.Append(@""",");
                    }
                    else if (i == 5)
                    {
                        sb.Append(@"""sSmallImage"":""");
                        sb.Append(x.SbList[i]);
                        sb.Append(@""",");
                    }
                    else if (i == 6)
                    {
                        sb.Append(@"""iFriendly"":""");
                        sb.Append(x.SbList[i]);
                        sb.Append(@""",");
                    }
                    else if (i == 7)
                    {
                        sb.Append(@"""sNpcName"":""");
                        sb.Append(x.SbList[i]);
                        sb.Append(@""",");
                    }
                    else if (i == 8)
                    {
                        sb.Append(@"""sIntroduction"":""");
                        sb.Append(x.SbList[i]);
                        sb.Append(@""",");
                    }
                    else if (i == 9)
                    {
                        sb.Append(@"""iGenderType"":""");
                        sb.Append(x.SbList[i]);
                        sb.Append(@""",");
                    }
                    else if (i == 10)
                    {
                        sb.Append(@"""iMartialType"":""");
                        sb.Append(x.SbList[i]);
                        sb.Append(@""",");
                    }
                    else if (i == 11)
                    {
                        sb.Append(@"""sTitle"":""");
                        sb.Append(x.SbList[i]);
                        sb.Append(@""",");
                    }
                    else if (i == 12)
                    {
                        sb.Append(@"""後日談ID"":""");
                        sb.Append(x.SbList[i]);
                        sb.Append(@""",");
                    }
                    else if ((x.SbList.Count == 14) && (i == 13))
                    {
                        sb.Append(@"""sConditionsID3"":""");
                        sb.Append(x.SbList[i]);
                        sb.Append(@"""}");

                        ///
                        /// 分行，方便驗證結果
                        ///
                        sb.Append("\n");
                    }
                    else if (i == 13)
                    {
                        sb.Append(@"""sConditionsID3"":""");
                        sb.Append(x.SbList[i]);
                        sb.Append(@""",");
                    }
                    else if (i == x.SbList.Count - 1)
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

        private string Neigong()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(@"""NeigongList"":[");

            ///
            /// 分行，方便驗證結果
            ///
            sb.Append("\n");

            foreach (var x in dsList)
            {
                for (var i = 0; i < x.SbList.Count; i++)
                {
                    if (x.SbList.Count < 2)
                    {
                        continue;
                    }

                    if (i == 0)
                    {
                        sb.Append(@"{""id"":""");
                        sb.Append(x.SbList[i]);
                        sb.Append(@""",");
                    }
                    else if (i == 1)
                    {
                        sb.Append(@"""Name"":""");
                        sb.Append(x.SbList[i]);
                        sb.Append(@""",");
                    }
                    else if (i == 2)
                    {
                        sb.Append(@"""Desc"":""");
                        sb.Append(x.SbList[i]);
                        sb.Append(@""",");
                    }
                    else if (i == 3)
                    {
                        sb.Append(@"""UpgradeNotes"":""");
                        sb.Append(x.SbList[i]);
                        sb.Append(@""",");
                    }
                    else if (i == 4)
                    {
                        sb.Append(@"""LevelUP"":""");
                        sb.Append(x.SbList[i]);
                        sb.Append(@""",");
                    }
                    else if (i == 5)
                    {
                        sb.Append(@"""MaxUP"":""");
                        sb.Append(x.SbList[i]);
                        sb.Append(@""",");
                    }
                    else if (i == 6)
                    {
                        sb.Append(@"""iExp"":""");
                        sb.Append(x.SbList[i]);
                        sb.Append(@""",");
                    }
                    else if (i == 7)
                    {
                        sb.Append(@"""sIcon1"":""");
                        sb.Append(x.SbList[i]);
                        sb.Append(@""",");
                    }
                    else if (i == 8)
                    {
                        sb.Append(@"""ConditionEffectID1"":""");
                        sb.Append(x.SbList[i]);
                        sb.Append(@""",");
                    }
                    else if (i == 9)
                    {
                        sb.Append(@"""sConditionsID1"":""");
                        sb.Append(x.SbList[i]);
                        sb.Append(@""",");
                    }
                    else if (i == 10)
                    {
                        sb.Append(@"""ConditionEffectID2"":""");
                        sb.Append(x.SbList[i]);
                        sb.Append(@""",");
                    }
                    else if (i == 11)
                    {
                        sb.Append(@"""sConditionsID2"":""");
                        sb.Append(x.SbList[i]);
                        sb.Append(@""",");
                    }
                    else if (i == 12)
                    {
                        sb.Append(@"""ConditionEffectID3"":""");
                        sb.Append(x.SbList[i]);
                        sb.Append(@""",");
                    }
                    else if ((x.SbList.Count == 14) && (i == 13))
                    {
                        sb.Append(@"""sConditionsID3"":""");
                        sb.Append(x.SbList[i]);
                        sb.Append(@"""}");

                        ///
                        /// 分行，方便驗證結果
                        ///
                        sb.Append("\n");
                    }
                    else if (i == 13)
                    {
                        sb.Append(@"""sConditionsID3"":""");
                        sb.Append(x.SbList[i]);
                        sb.Append(@""",");
                    }
                    else if (i == x.SbList.Count - 1)
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
