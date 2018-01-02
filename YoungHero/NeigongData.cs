using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Text;
using System.Globalization;
using System;

namespace YoungHero
{
    class NeigongJson
    {
        dynamic NJson;
        string NeigongFN = Application.StartupPath + @"\Data\NeigongData.txt";

        public int Length { get; private set; }

        public NeigongJson()
        {
            LoadFile();
            SetLength();
        }

        private void LoadFile()
        {
            if (!File.Exists(NeigongFN))
            {
                MessageBox.Show("NpcData.txt 不存在", "Error");
                return;
            }

            LoadFile_Run();
        }

        private void LoadFile_Run()
        {
            StreamReader FileSR = new StreamReader(NeigongFN, System.Text.Encoding.Default);
            string FileStr = FileSR.ReadToEnd();
            NJson = JsonConvert.DeserializeObject(FileStr);
            FileSR.Close();
        }

        private void SetLength()
        {
            int index = 0;

            foreach (dynamic Neigong in NJson.NeigongList)
            {
                index++;
            }

            Length = index;
        }

        public string GetNameByIndex(int SrcIndex)
        {
            int index = 0;
            string ResultStr = string.Empty;

            foreach (dynamic Neigong in NJson.NeigongList)
            {
                if(index == SrcIndex)
                {
                    ResultStr = Neigong.id + "\t" + Neigong.Name;
                    break;
                }

                index++;
            }

            return ResultStr;
        }

        public int GetIndexByID(string SrcID)
        {
            int ResultIndex = 0;
            int index = 0;

            foreach (dynamic Neigong in NJson.NeigongList)
            {
                if (Neigong.id == SrcID)
                {
                    ResultIndex = index;
                    break;
                }

                index++;
            }

            return ResultIndex;
        }

        private string IdFilter(string SrcName)
        {
            StringBuilder sb = new StringBuilder();

            for (var i = 0; i < SrcName.Length; i++)
            {
                string TempStr = StringInfo.GetNextTextElement(SrcName, i);

                if (TempStr == "\t")
                {
                    break;
                }

                sb.Append(TempStr);
            }

            return sb.ToString();
        }

        public int ReturnId(string SrcName)
        {
            int result = 0;
            string str = IdFilter(SrcName);

            foreach (dynamic Neigong in NJson.NeigongList)
            {
                if (Neigong.id == str)
                {
                    result = Neigong.id.ToObject<Int32>();
                }
            }

            return result;
        }
    }
}
