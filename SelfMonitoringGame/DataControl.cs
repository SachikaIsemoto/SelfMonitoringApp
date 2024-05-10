using Csv;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfMonitoringGame
{
    public static class DataControl
    {
        private static List<ActivityRecord> activityRecords = new List<ActivityRecord>();
        private static List<ThoughtRecord> thoughtRecords = new List<ThoughtRecord>();
        private static List<CategoryRecord> categoryRecords = new List<CategoryRecord>();
        
        public static DateTime activitySelectDate { get; set; }
        public static int thoughtSelectNo { get; set; }

        /* 活動記録表データ取得 */
        public static void SetActivityRecords()
        {
            /* ファイルなければ作る */
            if (!File.Exists(FileName.activityFileName))
            {
                string outcsv = string.Join(",", FileName.activityHeader);
                File.WriteAllText(FileName.activityFileName, outcsv + Environment.NewLine, Encoding.UTF8);
                return;
            }

            var avtivityCsvText = File.ReadAllText(FileName.activityFileName, Encoding.UTF8);


            foreach (var line in CsvReader.ReadFromText(avtivityCsvText))
            {
                var record = new ActivityRecord();

                /* 各列を取得 */
                record.Day = DateTime.Parse(line[FileName.dateHeader]);
                record.Time = int.Parse(line[FileName.timeHeader]);
                record.Category = line[FileName.categoryHeader];
                record.Content = line[FileName.contentHeader];
                record.Feeling = line[FileName.feelingHeader];

                activityRecords.Add(record);
            }
        }

        /* 活動記録表データ出力 */
        public static void OutputActivityRecords()
        {
            string[][] outline = new string[activityRecords.Count][];

            for (int i = 0; i < activityRecords.Count; i++)
            {
                outline[i] = new string[FileName.activityHeaderCount];

                outline[i][0] = activityRecords[i].Day.ToString("yyyy/MM/dd");
                outline[i][1] = activityRecords[i].Time.ToString();
                outline[i][2] = activityRecords[i].Category ?? "";
                outline[i][3] = activityRecords[i].Content ?? "";
                outline[i][4] = activityRecords[i].Feeling ?? "";
            }

            string outcsv = CsvWriter.WriteToText(FileName.activityHeader, outline);
            File.WriteAllText(FileName.activityFileName, outcsv, Encoding.UTF8);
        }

        /* 活動記録表データ参照 */
        public static List<ActivityRecord> GetActivityRecords()
        {
            return activityRecords;
        }

        /* 活動記録表データ追加 */
        public static void AddActivityRecord(ActivityRecord record)
        {
            List<ActivityRecord> records = new List<ActivityRecord>(activityRecords);
            ActivityRecord newRecord = record.EasyClone();


            foreach (var activityRecord in records)
            {
                if ((activityRecord.Day.Date == record.Day.Date) && (record.Time == activityRecord.Time))
                {
                    activityRecords.Remove(activityRecord);
                }
            }
            
            activityRecords.Add(newRecord);

        }

        /* 活動記録表データ削除 */
        public static void RemoveActivityRecord(ActivityRecord record)
        {
            activityRecords.Remove(record);

        }

        /* 思考記録表データ取得 */
        public static void SetThoughtRecords()
        {
            /* ファイルなければ作る */
            if (!File.Exists(FileName.thoughtFileName))
            {
                string outcsv = string.Join(",", FileName.thoughtHeader);
                File.WriteAllText(FileName.thoughtFileName, outcsv + Environment.NewLine, Encoding.UTF8);
                return;
            }

            var thoughtCsvText = File.ReadAllText(FileName.thoughtFileName, Encoding.UTF8);

            var options = new CsvOptions();
            options.AllowNewLineInEnclosedFieldValues = true;

            foreach (var line in CsvReader.ReadFromText(thoughtCsvText, options))
            {
                var record = new ThoughtRecord();

                /* 各列を取得 */
                record.title = line[FileName.titleHeader];
                record.date = DateTime.Parse(line[FileName.dateHeader]);
                record.situation = line[FileName.situationHeader];
                record.atThatTimeFeeling = line[FileName.atThatTimeFeelingHeader];
                record.autoThought = line[FileName.autoThoughtHeader];
                record.basis = line[FileName.basisHeader];
                record.disproof = line[FileName.disproofHeader];
                record.adaptThought = line[FileName.adaptThoughtHeader];
                record.nowFeeling = line[FileName.nowFeelingHeader];

                thoughtRecords.Add(record);
            }
        }

        /* 思考記録表データ参照 */
        public static List<ThoughtRecord> GetThoughtRecords()
        {
            return thoughtRecords;
        }

        /* 思考記録表データ追加 */
        public static void AddThoughtRecord(ThoughtRecord thoughtRecord)
        {
            ThoughtRecord newRecord = thoughtRecord.EasyClone();

            thoughtRecords.Add (newRecord);
        }

        /* 思考記録表データ削除 */
        public static void RemoveThoughtRecord(ThoughtRecord thoughtRecord)
        {
            thoughtRecords.Remove(thoughtRecord);
        }

        /* 思考記録表データ変更 */
        public static void EditThoughtRecord(ThoughtRecord thoughtRecord)
        {
            thoughtRecords[DataControl.thoughtSelectNo] = thoughtRecord;
        }

        /* 思考記録表データ出力 */
        public static void OutputThoughtRecoeds()
        {
            string[][] outline = new string[thoughtRecords.Count][];

            for (int i = 0; i < thoughtRecords.Count; i++)
            {
                outline[i] = new string[FileName.thoughtHeaderCount];

                outline[i][0] = thoughtRecords[i].title ?? "";
                outline[i][1] = thoughtRecords[i].date.ToString("yyyy/MM/dd");
                outline[i][2] = thoughtRecords[i].situation ?? "";
                outline[i][3] = thoughtRecords[i].atThatTimeFeeling ?? "";
                outline[i][4] = thoughtRecords[i].autoThought ?? "";
                outline[i][5] = thoughtRecords[i].basis ?? "";
                outline[i][6] = thoughtRecords[i].disproof ?? "";
                outline[i][7] = thoughtRecords[i].adaptThought ?? "";
                outline[i][8] = thoughtRecords[i].nowFeeling ?? "";
            }

            string outcsv = CsvWriter.WriteToText(FileName.thoughtHeader, outline);
            File.WriteAllText(FileName.thoughtFileName, outcsv, Encoding.UTF8);
        }

        /* カテゴリデータ取得 */
        public static void SetCategoryRecords()
        {
            /* ファイルなければ作る */
            if (!File.Exists(FileName.categoryFileName))
            {
                /* 初期データ設定 */
                string[][] defaultData = new string[4][];
                for (int i = 0; i < defaultData.Length; i++)
                {
                    defaultData[i] = new string[FileName.categoryHeaderCount];
                }
                defaultData[0][0] = "睡眠";
                defaultData[0][1] = "0";
                defaultData[0][2] = "128";
                defaultData[0][3] = "255";
                defaultData[1][0] = "運動";
                defaultData[1][1] = "255";
                defaultData[1][2] = "128";
                defaultData[1][3] = "128";
                defaultData[2][0] = "趣味";
                defaultData[2][1] = "255";
                defaultData[2][2] = "255";
                defaultData[2][3] = "128";
                defaultData[3][0] = "食事";
                defaultData[3][1] = "128";
                defaultData[3][2] = "255";
                defaultData[3][3] = "128";

                string outcsv = CsvWriter.WriteToText(FileName.categoryDataHeader, defaultData);

                File.WriteAllText(FileName.categoryFileName, outcsv, Encoding.UTF8);

            }

            var categoryCsvText = File.ReadAllText(FileName.categoryFileName, Encoding.UTF8);

            foreach (var line in CsvReader.ReadFromText(categoryCsvText))
            {
                var record = new CategoryRecord();

                /* 各列を取得 */
                record.Name = line[FileName.categoryNameHeader];
                record.Color_r = int.Parse(line[FileName.colorRHeader]);
                record.Color_g = int.Parse(line[FileName.colorGHeader]);
                record.Color_b = int.Parse(line[FileName.colorBHeader]);

                categoryRecords.Add(record);

            }
        }

        /* カテゴリデータ出力 */
        public static void OutputCategoryRecords()
        {
            string[][] outline = new string[categoryRecords.Count][];

            for (int i = 0; i < categoryRecords.Count; i++)
            {
                outline[i] = new string[FileName.categoryHeaderCount];

                outline[i][0] = categoryRecords[i].Name ?? "";
                outline[i][1] = categoryRecords[i].Color_r.ToString();
                outline[i][2] = categoryRecords[i].Color_g.ToString();
                outline[i][3] = categoryRecords[i].Color_b.ToString();
            }

            string outcsv = CsvWriter.WriteToText(FileName.categoryDataHeader, outline);
            File.WriteAllText(FileName.categoryFileName, outcsv, Encoding.UTF8 );
        }

        /* カテゴリデータ参照 */
        public static List<CategoryRecord> GetCategoryRecords()
        {
            return categoryRecords;
        }

        /* カテゴリデータ追加 */
        public static void AddCategoryRecord(CategoryRecord record)
        {
            CategoryRecord newRecord = record.EasyClone();

            categoryRecords.Add(newRecord);
        }

        /* カテゴリデータ削除 */
        public static void RemoveCategoryRecord(CategoryRecord record)
        {
            categoryRecords.Remove(record);
        }
    }


}
