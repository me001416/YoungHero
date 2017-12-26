using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Globalization;

namespace YoungHero
{
    public class NpcJson
    {
        string NpcFN = Application.StartupPath + @"\Data\NpcData.txt";
        dynamic NFJson;
        bool JsonDone;

        public NpcJson()
        {
            JsonDone = false;
            LoadFile();
        }

        public bool IsPresent(int SrcID)
        {
            foreach (dynamic npc in NFJson.NPCList)
            {
                if (npc.id == SrcID)
                {
                    return true;
                }
            }

            return false;
        }

        public string ReturnName(int SrcID)
        {
            string str = string.Empty;

            foreach (dynamic npc in NFJson.NPCList)
            {
                if (npc.id == SrcID)
                {
                    str = npc.id + "\t" + npc.sNpcName;
                }
            }

            return str;
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

            foreach (dynamic npc in NFJson.NPCList)
            {
                if (npc.id == str)
                {
                    result = npc.id.ToObject<Int32>();
                }
            }

            return result;
        }

        public bool CheckJsonDone()
        {
            for(int i = 0; i < 0xFFF; i++)
            {
                if(JsonDone)
                {
                    return true;
                }

                Task.Delay(100);
            }

            return false;
        }

        private void LoadFile_Run()
        {
            StreamReader FileSR = new StreamReader(NpcFN, System.Text.Encoding.Default);
            string FileStr = FileSR.ReadToEnd();
            NFJson = JsonConvert.DeserializeObject(FileStr);
            FileSR.Close();

            JsonDone = true;
        }

        private async void LoadFile()
        {
            if(!File.Exists(NpcFN))
            {
                MessageBox.Show("NpcData.txt 不存在", "Error");
                return;
            }

            await Task.Run(() => LoadFile_Run());
        }
    }
}
