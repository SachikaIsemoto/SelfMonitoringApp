using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfMonitoringGame
{
    static class FileName
    {
        public static readonly string activityDirName = "./file/activity/";
        public static readonly string thoughtDirName = "./file/thought/";
        public static readonly string categoryDirName = "./file/category/";

        public static readonly string activityFileName = activityDirName + "activityRecords.csv";
        public static readonly string thoughtFileName = thoughtDirName + "thoughtRecords.csv";
        public static readonly string categoryFileName = categoryDirName + "categoryList.csv";

        public static readonly int thoughtDataCount = 100;
        public static readonly int categoryDataCount = 10;

        public static readonly int activityHeaderCount = 5;
        public static readonly string dateHeader = "日付";
        public static readonly string timeHeader = "時間";
        public static readonly string categoryHeader = "カテゴリ";
        public static readonly string contentHeader = "活動内容";
        public static readonly string feelingHeader = "気分";
        public static readonly string[] activityHeader =
        {
            dateHeader,
            timeHeader,
            categoryHeader,
            contentHeader,
            feelingHeader
        };

        public static readonly int thoughtHeaderCount = 9;
        public static readonly string titleHeader = "タイトル";
        /* 日付は活動記録と共有 */
        public static readonly string situationHeader = "状況";
        public static readonly string atThatTimeFeelingHeader = "気分（％）";
        public static readonly string autoThoughtHeader = "自動思考";
        public static readonly string basisHeader = "根拠";
        public static readonly string disproofHeader = "反証";
        public static readonly string adaptThoughtHeader = "適応思考";
        public static readonly string nowFeelingHeader = "今の気分（％）";
        public static readonly string[] thoughtHeader =
        {
            titleHeader,
            dateHeader,
            situationHeader,
            atThatTimeFeelingHeader,
            autoThoughtHeader,
            basisHeader,
            disproofHeader,
            adaptThoughtHeader,
            nowFeelingHeader
        };

        public static readonly int categoryHeaderCount = 4;
        public static readonly string categoryNameHeader = "カテゴリ名";
        public static readonly string colorRHeader = "色(R)";
        public static readonly string colorGHeader = "色(G)";
        public static readonly string colorBHeader = "色(B)";
        public static readonly string[] categoryDataHeader =
        {
            categoryNameHeader,
            colorRHeader,
            colorGHeader,
            colorBHeader
        };

        public static readonly string cellToolTip = "左クリック：追加　右クリック：削除";
    }
}
