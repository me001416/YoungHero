﻿using System.Collections.Generic;
using System.Text;

namespace YoungHero.StringManager
{
    /// <summary>
    /// 管理 List DataStringBuilder 的 Class
    /// </summary>
    public class DataStringBuilderList
    {
        /// <summary>
        /// List StringBuild，提供使用者存取字串
        /// </summary>
        public List<DataStringBuilder> dsList { get; private set; }

        /// <summary>
        /// Constructor Function
        /// </summary>
        public DataStringBuilderList()
        {
            dsList = new List<DataStringBuilder>();
        }

        /// <summary>
        /// 新增 StringBuilder 到 DataStringBuilder 裡面
        /// </summary>
        /// <param name="SrcSb"></param>
        public void Add(StringBuilder SrcSb)
        {
            if (dsList.Count == 0)
            {
                New();
            }

            dsList[dsList.Count - 1].Add(SrcSb);
        }

        /// <summary>
        /// 新增 StringBuilder 透過特殊的 Index
        /// </summary>
        /// <param name="SrcSb"></param>
        /// <param name="SrcIndex"></param>
        public void Add(StringBuilder SrcSb, int SrcIndex)
        {
            dsList[SrcIndex].Add(SrcSb);
        }

        /// <summary>
        /// 新增 DataStringBuilder 到 List
        /// </summary>
        public void New()
        {
            dsList.Add(new DataStringBuilder(dsList.Count - 1));
        }

        /// <summary>
        /// 透過特殊的 Index 新增 DataStringBuilder 到 List
        /// </summary>
        /// <param name="SrcIndex"></param>
        public void New(int SrcIndex)
        {
            dsList.Add(new DataStringBuilder(SrcIndex));
        }

        /// <summary>
        /// 格式化輸入資料，可選擇格式化的模式
        /// </summary>
        /// <param name="SelectMode"></param>
        /// <returns></returns>
        public string FormatFileData(int SelectMode = 1)
        {
            string str = string.Empty;

            if(SelectMode == 1)
            {
                str = Neigong();
            }
            else if(SelectMode == 2)
            {
                str = NPC();
            }

            return str;
        }

        /// <summary>
        /// 給 NPC 資料使用
        /// </summary>
        /// <returns></returns>
        private string NPC()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(@"{""NPCList"":[");

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
                        sb.Append(@"""AfterStoryID"":""");
                        sb.Append(x.SbList[i]);
                        sb.Append(@"""},");

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

            sb.Remove(sb.Length - 2, 1);
            sb.Append("]}");

            return sb.ToString();
        }

        /// <summary>
        /// 給 Neigong 資料使用
        /// </summary>
        /// <returns></returns>
        private string Neigong()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(@"{""NeigongList"":[");

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
                        sb.Append(@"""},");

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
                        sb.Append(@"""FinalCondition"":""");
                        sb.Append(x.SbList[i]);
                        sb.Append(@"""},");

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

            sb.Remove(sb.Length - 2, 1);
            sb.Append("]}");

            return sb.ToString();
        }
    }

    /// <summary>
    /// 管理 List StringBuilder 的 Class
    /// </summary>
    public class DataStringBuilder
    {
        public List<StringBuilder> SbList { get; private set; }

        public DataStringBuilder()
        {
            SbList = new List<StringBuilder>();
        }

        public DataStringBuilder(int SrcIndex)
        {
            SbList = new List<StringBuilder>();
        }

        public void Add(StringBuilder SrcSb)
        {
            SbList.Add(SrcSb);
        }
    }
}
