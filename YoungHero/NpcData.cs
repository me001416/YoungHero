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
    public class NpcData
    {
        private int npcId;
        public int NpcId
        {
            get { return npcId; }
            set
            {
                npcId = value;
            }
        }

        private string npcName;
        public string NpcName
        {
            get { return npcName; }
            set
            {
                npcName = value;
            }
        }

        public NpcData(int srcId, string srcName)
        {
            NpcId = srcId;
            NpcName = srcName;
        }
    }

    public class NpcList
    {
        public List<NpcData> npcList { get; private set; }

        public NpcList()
        {
            npcList = new List<NpcData>();

            npcList.Add(new NpcData(100004, "厲蒼龍"));
            npcList.Add(new NpcData(100006, "樊未離"));
            npcList.Add(new NpcData(100007, "納蘭衍"));
            npcList.Add(new NpcData(100008, "凌香兒"));
            npcList.Add(new NpcData(100009, "任天翔"));
            npcList.Add(new NpcData(100010, "羅蛇君"));
            npcList.Add(new NpcData(100011, "姬無雙"));
            npcList.Add(new NpcData(100017, "無瑕子"));
            npcList.Add(new NpcData(100018, "玄冥子"));
            npcList.Add(new NpcData(100019, "老胡"));
            npcList.Add(new NpcData(100022, "賈雲長"));
            npcList.Add(new NpcData(100023, "雷震天"));
            npcList.Add(new NpcData(100024, "趙驚風"));
            npcList.Add(new NpcData(100025, "賽飛鴻"));
            npcList.Add(new NpcData(100026, "醉仙"));
            npcList.Add(new NpcData(100027, "橘叟"));
            npcList.Add(new NpcData(100028, "神醫"));
            npcList.Add(new NpcData(100029, "仙音"));
            npcList.Add(new NpcData(100030, "書生"));
            npcList.Add(new NpcData(100031, "丹青"));
            npcList.Add(new NpcData(100033, "沈瀾"));
            npcList.Add(new NpcData(100034, "劍聖"));
            npcList.Add(new NpcData(100037, "方雲華"));
            npcList.Add(new NpcData(100038, "卓人清"));
            npcList.Add(new NpcData(100040, "古葉"));
            npcList.Add(new NpcData(100041, "莊人駿"));
            npcList.Add(new NpcData(100042, "武當弟子"));
            npcList.Add(new NpcData(100044, "無因方丈"));
            npcList.Add(new NpcData(100045, "無色"));
            npcList.Add(new NpcData(100046, "無慧"));
            npcList.Add(new NpcData(100047, "無嗔"));
            npcList.Add(new NpcData(100048, "無戒"));
            npcList.Add(new NpcData(100049, "少林門人-A"));
            npcList.Add(new NpcData(100050, "少林門人-B"));
            npcList.Add(new NpcData(100051, "十八銅人-A"));
            npcList.Add(new NpcData(100052, "十八銅人-B"));
            npcList.Add(new NpcData(100053, "十八銅人-C"));
            npcList.Add(new NpcData(100054, "任清璇"));
            npcList.Add(new NpcData(100056, "紀玟"));
            npcList.Add(new NpcData(100058, "藍婷"));
            npcList.Add(new NpcData(100059, "史燕"));
            npcList.Add(new NpcData(100061, "風吹雪-A"));
            npcList.Add(new NpcData(100065, "史剛"));
            npcList.Add(new NpcData(100066, "史義"));
            npcList.Add(new NpcData(100067, "黃娟"));
            npcList.Add(new NpcData(100068, "毒龍教眾-A"));
            npcList.Add(new NpcData(100069, "毒龍教眾-B"));
            npcList.Add(new NpcData(100070, "霹靂幫眾"));
            npcList.Add(new NpcData(100071, "西門玄"));
            npcList.Add(new NpcData(100072, "西門峰"));
            npcList.Add(new NpcData(100073, "天劍門人"));
            npcList.Add(new NpcData(100074, "江天雄"));
            npcList.Add(new NpcData(100075, "江瑜"));
            npcList.Add(new NpcData(100077, "關長虹"));
            npcList.Add(new NpcData(100078, "關偉"));
            npcList.Add(new NpcData(100079, "長虹鏢師"));
            npcList.Add(new NpcData(100080, "唐飛"));
            npcList.Add(new NpcData(100081, "唐冠南"));
            npcList.Add(new NpcData(100082, "唐中慧"));
            npcList.Add(new NpcData(100083, "唐門門人"));
            npcList.Add(new NpcData(100084, "夏侯城"));
            npcList.Add(new NpcData(100085, "夏侯非"));
            npcList.Add(new NpcData(100086, "絕刀門人"));
            npcList.Add(new NpcData(100088, "商鶴鳴"));
            npcList.Add(new NpcData(100089, "商仲仁"));
            npcList.Add(new NpcData(100090, "八卦門人"));
            npcList.Add(new NpcData(100091, "楊雲"));
            npcList.Add(new NpcData(100093, "任浩然"));
            npcList.Add(new NpcData(100095, "護劍使"));
            npcList.Add(new NpcData(100096, "鞏光傑"));
            npcList.Add(new NpcData(100097, "百草門人"));
            npcList.Add(new NpcData(100099, "柯降龍"));
            npcList.Add(new NpcData(100100, "李浩"));
            npcList.Add(new NpcData(100101, "丐幫長老"));
            npcList.Add(new NpcData(100102, "丐幫幫眾-A"));
            npcList.Add(new NpcData(100103, "丐幫幫眾-B"));
            npcList.Add(new NpcData(100104, "毒"));
            npcList.Add(new NpcData(100105, "浪"));
            npcList.Add(new NpcData(100106, "狂"));
            npcList.Add(new NpcData(100107, "焦大"));
            npcList.Add(new NpcData(100108, "焦小"));
            npcList.Add(new NpcData(100109, "黑無常"));
            npcList.Add(new NpcData(100110, "白無常"));
            npcList.Add(new NpcData(100112, "郝虎"));
            npcList.Add(new NpcData(100113, "巴龍"));
            npcList.Add(new NpcData(100114, "戚將軍"));
            npcList.Add(new NpcData(100115, "陳公公"));
            npcList.Add(new NpcData(100116, "東廠殺手"));
            npcList.Add(new NpcData(100117, "衙門官兵"));
            npcList.Add(new NpcData(100118, "何未峰"));
            npcList.Add(new NpcData(100119, "易蘭"));
            npcList.Add(new NpcData(100120, "何秋娟"));
            npcList.Add(new NpcData(100121, "天山門人"));
            npcList.Add(new NpcData(100122, "紫陽子"));
            npcList.Add(new NpcData(100123, "青霞子"));
            npcList.Add(new NpcData(100124, "青城門人"));
            npcList.Add(new NpcData(100126, "吃"));
            npcList.Add(new NpcData(100127, "喝"));
            npcList.Add(new NpcData(100128, "嫖"));
            npcList.Add(new NpcData(100129, "賭"));
            npcList.Add(new NpcData(100130, "天龍教眾"));
            npcList.Add(new NpcData(100133, "修羅宮弟子"));
            npcList.Add(new NpcData(100135, "徐子騏"));
            npcList.Add(new NpcData(100136, "仇霸"));
            npcList.Add(new NpcData(100140, "西域番僧"));
            npcList.Add(new NpcData(100141, "熊天霸"));
            npcList.Add(new NpcData(100142, "海鯊幫眾"));
            npcList.Add(new NpcData(100143, "金翅鳥"));
            npcList.Add(new NpcData(100144, "東瀛倭寇"));
            npcList.Add(new NpcData(100145, "東瀛浪人"));
            npcList.Add(new NpcData(100146, "豆漿小白"));
            npcList.Add(new NpcData(100245, "曹岱"));
            npcList.Add(new NpcData(100246, "華山門人"));
            npcList.Add(new NpcData(100297, "陸少臨"));
            npcList.Add(new NpcData(100298, "無顛"));
            npcList.Add(new NpcData(100299, "燕宇"));
            npcList.Add(new NpcData(100312, "公孫堅"));
            npcList.Add(new NpcData(100415, "天王舊部"));
            npcList.Add(new NpcData(100419, "花癡"));
            npcList.Add(new NpcData(100422, "天意城主"));
            npcList.Add(new NpcData(200000, "衛紫綾"));
            npcList.Add(new NpcData(200001, "韋子陵"));
            npcList.Add(new NpcData(200002, "辟邪老人"));
            npcList.Add(new NpcData(200003, "佛母"));
            npcList.Add(new NpcData(200004, "心殘"));
            npcList.Add(new NpcData(200005, "傀屍"));
            npcList.Add(new NpcData(200006, "金屍"));
            npcList.Add(new NpcData(200007, "銀屍"));
            npcList.Add(new NpcData(200008, "鐵屍"));
            npcList.Add(new NpcData(200009, "歐陽笑"));
            npcList.Add(new NpcData(200010, "寒蝠"));
            npcList.Add(new NpcData(200011, "九陰"));
            npcList.Add(new NpcData(200012, "九陰幽僕"));
            npcList.Add(new NpcData(200013, "賽王爺"));
            npcList.Add(new NpcData(200014, "完顏柯爾克"));
            npcList.Add(new NpcData(200015, "賽王府親兵"));
            npcList.Add(new NpcData(200016, "水盼盼"));
            npcList.Add(new NpcData(200017, "龍墨"));
            npcList.Add(new NpcData(200020, "蕭復"));
            npcList.Add(new NpcData(200022, "塔婭"));
            npcList.Add(new NpcData(200023, "閻羅"));
            npcList.Add(new NpcData(200024, "孟婆"));
            npcList.Add(new NpcData(200025, "羅煞"));
            npcList.Add(new NpcData(200026, "阿傍"));
            npcList.Add(new NpcData(200027, "敖廣"));
            npcList.Add(new NpcData(200028, "酆都鬼眾"));
            npcList.Add(new NpcData(200029, "商仲智"));
            npcList.Add(new NpcData(200030, "萬青山"));
            npcList.Add(new NpcData(200031, "獸王莊門人"));
            npcList.Add(new NpcData(200032, "黑冢羅王"));
            npcList.Add(new NpcData(200036, "老虎-A"));
            npcList.Add(new NpcData(200037, "老虎-B"));
            npcList.Add(new NpcData(200038, "不動"));
            npcList.Add(new NpcData(200039, "岳胖子"));
            npcList.Add(new NpcData(200040, "岳曉遙"));
            npcList.Add(new NpcData(200041, "岳在淵"));
            npcList.Add(new NpcData(200043, "封青霄"));
            npcList.Add(new NpcData(200044, "楚繪"));
            npcList.Add(new NpcData(200045, "天機老道"));
            npcList.Add(new NpcData(200046, "賀陀"));
            npcList.Add(new NpcData(200050, "親兵隊長"));
            npcList.Add(new NpcData(200051, "總兵長"));
            npcList.Add(new NpcData(210001, "谷月軒"));
            npcList.Add(new NpcData(210002, "荊棘"));
            npcList.Add(new NpcData(210003, "沈湘芸"));
            npcList.Add(new NpcData(210004, "古實"));
            npcList.Add(new NpcData(210005, "秦紅殤"));
            npcList.Add(new NpcData(210006, "風吹雪"));
            npcList.Add(new NpcData(210007, "傅劍寒"));
            npcList.Add(new NpcData(210008, "任劍南"));
            npcList.Add(new NpcData(210009, "蕭遙"));
            npcList.Add(new NpcData(210048, "小阿曼"));
            npcList.Add(new NpcData(210055, "游進"));
            npcList.Add(new NpcData(210056, "大蛇丸"));
            npcList.Add(new NpcData(210057, "萬蛇"));
            npcList.Add(new NpcData(210067, "張燁"));
            npcList.Add(new NpcData(210068, "李順"));
            npcList.Add(new NpcData(210072, "劈卦拳門人"));
            npcList.Add(new NpcData(210075, "江湖中人-A"));
            npcList.Add(new NpcData(210076, "江湖中人-B"));
            npcList.Add(new NpcData(210077, "江湖中人-C"));
            npcList.Add(new NpcData(210078, "江湖中人-D"));
            npcList.Add(new NpcData(210079, "崔國倫"));
            npcList.Add(new NpcData(210103, "殘兵"));
            npcList.Add(new NpcData(210104, "阿薩辛"));
            npcList.Add(new NpcData(210105, "李大肚"));
            npcList.Add(new NpcData(210106, "李武靖"));
            npcList.Add(new NpcData(210109, "巨鱷"));
            npcList.Add(new NpcData(210110, "沙狼"));
            npcList.Add(new NpcData(210116, "巨熊"));
            npcList.Add(new NpcData(210125, "谷月軒-A"));
            npcList.Add(new NpcData(210151, "青樓圍事"));
            npcList.Add(new NpcData(210153, "前沐王死士"));
            npcList.Add(new NpcData(210154, "鋼刀盟眾-A"));
            npcList.Add(new NpcData(210155, "鋼刀盟眾-B"));
            npcList.Add(new NpcData(210156, "鋼刀盟眾-C"));
            npcList.Add(new NpcData(210157, "鋼刀盟眾-D"));
            npcList.Add(new NpcData(210158, "幽谷客-A"));
            npcList.Add(new NpcData(210159, "入魔的蕭復"));
            npcList.Add(new NpcData(210161, "胡非"));
            npcList.Add(new NpcData(210162, "苗奉先"));
            npcList.Add(new NpcData(210163, "酆都厲鬼-A"));
            npcList.Add(new NpcData(210164, "酆都厲鬼-B"));
            npcList.Add(new NpcData(210165, "酆都厲鬼-C"));
            npcList.Add(new NpcData(210166, "酆都豔鬼"));
            npcList.Add(new NpcData(210167, "紫羅蠱蛇"));
            npcList.Add(new NpcData(210168, "赤蛛蠱王"));
            npcList.Add(new NpcData(210177, "洪京保"));
            npcList.Add(new NpcData(210178, "陳龍"));
            npcList.Add(new NpcData(210179, "李蓮杰"));
            npcList.Add(new NpcData(210180, "酆都鬼眾-A"));
            npcList.Add(new NpcData(210181, "傀屍門毒人-A"));
            npcList.Add(new NpcData(210182, "傀屍門毒人-B"));
            npcList.Add(new NpcData(210183, "傀屍門毒人-C"));
            npcList.Add(new NpcData(220000, "東方未明"));
            npcList.Add(new NpcData(300001, "天龍菁英"));
            npcList.Add(new NpcData(500005, "張虎"));
            npcList.Add(new NpcData(500006, "趙龍"));
            npcList.Add(new NpcData(500016, "菜籃大盜"));
            npcList.Add(new NpcData(500020, "天劍小師弟"));
            npcList.Add(new NpcData(500023, "快刀小孟"));
            npcList.Add(new NpcData(500036, "天悟禪師"));
            npcList.Add(new NpcData(500037, "虛明"));
            npcList.Add(new NpcData(500040, "錦衣衛"));
            npcList.Add(new NpcData(500058, "尚書府守衛"));
            npcList.Add(new NpcData(500059, "于修"));
            npcList.Add(new NpcData(500073, "黑狗"));
            npcList.Add(new NpcData(500074, "白狗"));
            npcList.Add(new NpcData(500075, "黃狗"));
            npcList.Add(new NpcData(500083, "辟邪死士"));
            npcList.Add(new NpcData(500085, "駱翎楓"));
            npcList.Add(new NpcData(500092, "袈裟竊賊"));
            npcList.Add(new NpcData(500097, "雲遊商人"));
            npcList.Add(new NpcData(500102, "幸長"));
            npcList.Add(new NpcData(500103, "金渦"));
            npcList.Add(new NpcData(500104, "駱烈夫"));
            npcList.Add(new NpcData(500105, "飛垣"));
            npcList.Add(new NpcData(500108, "鷲鷹"));
            npcList.Add(new NpcData(500112, "虹兒"));
            npcList.Add(new NpcData(500113, "小寶"));
            npcList.Add(new NpcData(500114, "挑嘴熊"));
            npcList.Add(new NpcData(500115, "猴三"));
            npcList.Add(new NpcData(500116, "修羅宮弟子-A"));
            npcList.Add(new NpcData(600011, "老乞丐"));
            npcList.Add(new NpcData(600012, "儒生屍體"));
            npcList.Add(new NpcData(600017, "葉掌門（金屍）"));
            npcList.Add(new NpcData(600018, "屍鱉"));
            npcList.Add(new NpcData(600019, "神秘人"));
            npcList.Add(new NpcData(600022, "知名不具"));
            npcList.Add(new NpcData(600026, "歐陽笑(?)"));
            npcList.Add(new NpcData(600027, "阿黑"));
            npcList.Add(new NpcData(600035, "令狐大俠"));
            npcList.Add(new NpcData(600043, "黑衣殺手"));
            npcList.Add(new NpcData(600047, "黑冢上忍"));
            npcList.Add(new NpcData(600048, "赫蒙族戰士"));
            npcList.Add(new NpcData(600049, "赫蒙族女戰士"));
            npcList.Add(new NpcData(600050, "武當弟子?"));
            npcList.Add(new NpcData(600051, "絕刀門人?"));
            npcList.Add(new NpcData(600052, "天劍門人?"));
            npcList.Add(new NpcData(600053, "唐門門人?"));
            npcList.Add(new NpcData(600054, "青城門人?"));
            npcList.Add(new NpcData(600055, "八卦門人?"));
            npcList.Add(new NpcData(600056, "首蛇道弟子"));
            npcList.Add(new NpcData(600057, "玄龜道弟子"));
            npcList.Add(new NpcData(600058, "兵鴉道弟子"));
            npcList.Add(new NpcData(600061, "鐵叉厲鬼"));
            npcList.Add(new NpcData(600063, "馬猴"));
            npcList.Add(new NpcData(600064, "萬勞九"));
            npcList.Add(new NpcData(600065, "上泉"));
            npcList.Add(new NpcData(600067, "神槍兵"));
            npcList.Add(new NpcData(600068, "神火兵"));
            npcList.Add(new NpcData(600073, "張三"));
            npcList.Add(new NpcData(600074, "李四"));
            npcList.Add(new NpcData(600075, "夜翼"));
            npcList.Add(new NpcData(600077, "江洋大盜"));
            npcList.Add(new NpcData(600079, "夜飄香"));
            npcList.Add(new NpcData(600081, "馬賊首領"));
            npcList.Add(new NpcData(600085, "假夜飄香"));
            npcList.Add(new NpcData(600087, "孟婆-A"));
            npcList.Add(new NpcData(600088, "六扇門官兵"));
            npcList.Add(new NpcData(600089, "六扇門捕快"));
            npcList.Add(new NpcData(600092, "歐陽笑(?)-A"));
            npcList.Add(new NpcData(600093, "歐陽笑(?)-B"));
            npcList.Add(new NpcData(600094, "歐陽笑(?)-C"));
            npcList.Add(new NpcData(600095, "歐陽笑(?)-D"));
            npcList.Add(new NpcData(600096, "谷月軒-B"));
            npcList.Add(new NpcData(600097, "谷月軒-C"));
            npcList.Add(new NpcData(600100, "騙子少女"));
            npcList.Add(new NpcData(600101, "阿疙兒"));
            npcList.Add(new NpcData(600102, "判官"));
            npcList.Add(new NpcData(600158, "幽谷客-B"));
            npcList.Add(new NpcData(600159, "傀屍-A"));
            npcList.Add(new NpcData(600160, "九陰幽僕-A"));
            npcList.Add(new NpcData(600161, "九陰幽僕-B"));
            npcList.Add(new NpcData(600162, "九陰幽僕-C"));
            npcList.Add(new NpcData(600163, "九陰幽僕-D"));
            npcList.Add(new NpcData(600164, "九陰幽僕-E"));
            npcList.Add(new NpcData(600165, "九陰幽僕-F"));
            npcList.Add(new NpcData(600166, "婆竭羅"));
            npcList.Add(new NpcData(600167, "攝濕生"));
            npcList.Add(new NpcData(600168, "自在天"));
            npcList.Add(new NpcData(600169, "持國天"));
            npcList.Add(new NpcData(600170, "山賊"));
            npcList.Add(new NpcData(600171, "山賊頭領"));
            npcList.Add(new NpcData(600172, "巴哈里德"));
            npcList.Add(new NpcData(600173, "烏衣教眾"));
            npcList.Add(new NpcData(600174, "仙希爾"));
            //npcList.Add(new NpcData(600176, "青樓圍事"));
            //npcList.Add(new NpcData(600177, "青樓圍事"));
            npcList.Add(new NpcData(800015, "谷月軒 II"));
            npcList.Add(new NpcData(800016, "荊棘 II"));
            npcList.Add(new NpcData(800035, "沈湘芸 II"));
            npcList.Add(new NpcData(800036, "古實 II"));
            npcList.Add(new NpcData(800057, "秦紅殤 II"));
            npcList.Add(new NpcData(800075, "江瑜 II"));
            npcList.Add(new NpcData(800091, "楊雲 II"));
            npcList.Add(new NpcData(800092, "傅劍寒 II"));
            npcList.Add(new NpcData(800094, "任劍南 II"));
            npcList.Add(new NpcData(800098, "蕭遙 II"));
            npcList.Add(new NpcData(800104, "毒 II"));
            npcList.Add(new NpcData(800105, "浪 II"));
            npcList.Add(new NpcData(800106, "狂 II"));
            npcList.Add(new NpcData(820005, "傀屍 II"));
            npcList.Add(new NpcData(820013, "賽王爺 II"));
            npcList.Add(new NpcData(820075, "天意菁英"));
            npcList.Add(new NpcData(890013, "賽王爺 III"));
            npcList.Add(new NpcData(890014, "酆都麗鬼"));
            npcList.Add(new NpcData(890023, "葉孤"));
            npcList.Add(new NpcData(890024, "花玖瑟-A"));
            npcList.Add(new NpcData(890025, "金熙鳳-A"));
            npcList.Add(new NpcData(890026, "尹世允"));
            npcList.Add(new NpcData(990024, "花玖瑟-B"));
            npcList.Add(new NpcData(990025, "金熙鳳-B"));
            npcList.Add(new NpcData(990027, "玄漓公"));
            npcList.Add(new NpcData(990028, "陽第上人"));
            npcList.Add(new NpcData(990029, "南天槐"));

            this.NpcNameCheck();
        }

        public bool IsPresent(int SrcID)
        {
            bool result = false;

            npcList.ForEach(x =>
            {
                if (x.NpcId == SrcID)
                {
                    result = true;
                }
            });

            return result;
        }

        public string ReturnName(int SrcID)
        {
            string str = string.Empty;

            npcList.ForEach(x =>
            {
                if (x.NpcId == SrcID)
                {
                    str = x.NpcName;
                }
            });

            return str;
        }

        public int ReturnId(string SrcName)
        {
            int result = 0;

            npcList.ForEach(x =>
            {
                if (x.NpcName == SrcName)
                {
                    result = x.NpcId;
                }
            });

            return result;
        }

        public void NpcNameCheck()
        {
            string errMsg = string.Empty;

            npcList.ForEach(x =>
            {
                npcList.ForEach(y =>
                {
                    if (x.NpcName == y.NpcName)
                    {
                        if (x.NpcId != y.NpcId)
                        {
                            errMsg = errMsg + $"{x.NpcName} 重複，{x.NpcId} != {y.NpcId}\n";
                        }
                    }
                });
            });

            if (!string.IsNullOrEmpty(errMsg))
            {
                MessageBox.Show(errMsg, "Error");
            }
        }
    }

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
