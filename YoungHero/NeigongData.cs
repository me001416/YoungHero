using System.IO;
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
    }
}
