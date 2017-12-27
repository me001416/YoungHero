using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace YoungHero
{
    class NeigongJson
    {
        dynamic NJson;
        string NeigongFN = Application.StartupPath + @"\Data\NeigongData.txt";

        public NeigongJson()
        {
            LoadFile();
        }

        private void LoadFile()
        {
            if (!File.Exists(NeigongFN))
            {
                MessageBox.Show("NpcData.txt 不存在", "Error");
                return;
            }
        }

        private void LoadFile_Run()
        {
            StreamReader FileSR = new StreamReader(NeigongFN, System.Text.Encoding.Default);
            string FileStr = FileSR.ReadToEnd();
            NJson = JsonConvert.DeserializeObject(FileStr);
            FileSR.Close();
        }
    }
}
