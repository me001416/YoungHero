using System.Collections.Generic;
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
        public List<DataStringBuilder> dsList { get; protected set; }

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
    }

    /// <summary>
    /// 管理 List StringBuilder 的 Class
    /// </summary>
    public class DataStringBuilder
    {
        public List<StringBuilder> SbList { get; private set; }

        /// <summary>
        /// Constructor Function
        /// </summary>
        public DataStringBuilder()
        {
            SbList = new List<StringBuilder>();
        }

        /// <summary>
        /// Constructor Function
        /// </summary>
        /// <param name="SrcIndex"></param>
        public DataStringBuilder(int SrcIndex)
        {
            SbList = new List<StringBuilder>();
        }

        /// <summary>
        /// 新增 StringBuilder 到 List 裡面
        /// </summary>
        /// <param name="SrcSb"></param>
        public void Add(StringBuilder SrcSb)
        {
            SbList.Add(SrcSb);
        }
    }
}
