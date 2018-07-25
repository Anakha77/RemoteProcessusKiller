namespace KillerClient.Common
{
    public class Processus
    {
        public string Name { get; set; }
        public string MainWindowTitle { get; set; }
        public int Id { get; set; }

        public string DisplayName => string.IsNullOrWhiteSpace(MainWindowTitle) ? $"{Name}~" : MainWindowTitle;
    }
}