namespace Window_Priority_Layout.Models
{
    internal class SortRule
    {
        // 一致させるキーワード
        public string Keyword { get; set; }

        // 設定する優先度
        public int Priority { get; set; }

        // 一致させる対象（タイトルまたはプロセス名）
        public MatchTarget Target { get; set; }

    }

    // 一致させる対象を表す列挙型(タイトルまたはプロセス名しか選択できない)
    internal enum MatchTarget
    {
        Title,
        ProcessName
    }
}
