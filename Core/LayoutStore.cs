using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Window_Priority_Layout.Models;

namespace Window_Priority_Layout.Core
{
    internal class LayoutStore
    {
        private const string FilePath = "layout.json";

        public List<LayoutSlot> Load()
        {
            //ファイルが存在しない場合は空のリストを返す
            if (!File.Exists(FilePath)) return new List<LayoutSlot>();

            //ファイルが存在する場合はJSONを読み込んでデシリアライズする
            string json =File.ReadAllText(FilePath);
            //JSONをデシリアライズしてList<LayoutSlot>に変換する
            var result = Newtonsoft.Json.JsonConvert.DeserializeObject<List<LayoutSlot>>(json);
            //デシリアライズに失敗した場合は空のリストを返す
            return result ?? new List<LayoutSlot>();
        }

        public void Save(List<LayoutSlot> layout)
        {
            //List<LayoutSlot>をJSONにシリアライズする
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(layout, Newtonsoft.Json.Formatting.Indented);
            //JSONをファイルに書き込む
            File.WriteAllText(FilePath, json);
        }
    }
}
