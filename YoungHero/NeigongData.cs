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

            foreach (dynamic Neigong in NJson)
            {
                index++;
            }

            Length = index;
        }
    }
}
