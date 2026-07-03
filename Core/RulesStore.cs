using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using Window_Priority_Layout.Models;

namespace Window_Priority_Layout.Core
{
    internal class RulesStore
    {
        // ルールを保存するファイルのパス
        private const string FilePath = "rules.json";

        // jsonファイルからルールを読み込む
        public List<SortRule> Load()
        {
            // ファイルが存在しない場合は空のリストを返す
            if (!File.Exists(FilePath))
            {
                return new List<SortRule>();
            }
            // ファイルが存在する場合は、JSON形式で保存されたルールを読み込む
            string json = File.ReadAllText(FilePath);
            // JSONをList<SortRule>に変換して返す
            return JsonConvert.DeserializeObject<List<SortRule>>(json);
        }
        
        public void Save(List<SortRule> rules)
        {
            // List<SortRule>をJSON形式に変換する
            string json = JsonConvert.SerializeObject(rules, Formatting.Indented);
            // JSONをファイルに書き込む
            File.WriteAllText(FilePath, json);
        }
        
    }
}
