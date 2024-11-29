namespace TradingCards.PlayerInfo
{
    static public class PlayerData // Note: code taken from assignment 2 - refactored to fit context
    {
        public static readonly List<Player> AllData = GetData(@"Data/PlayerData/NBA_PlayerStats_24-25.csv");

        public static List<Player> GetData(string path)
        {
            List<Player> data = new List<Player>();
            string csvPath = Path.Combine(Environment.CurrentDirectory, path);

            if (File.Exists(csvPath))
            {
                try
                {
                    data = ReadFile(csvPath);
                }
                catch (Exception e)
                {
                    data = new List<Player>();
                }
            }

            return data;
        }

        private static List<Player> ReadFile(string path)
        {
            List<Player> data = new List<Player>();

            using (StreamReader reader = new StreamReader(path))
            {
                int count = 0;
                while (!reader.EndOfStream)
                {
                    string? line = reader.ReadLine();

                    if (count == 0)
                    {
                        count++;
                        continue;
                    }

                    if (line == null)
                        continue;

                    List<string> cells = line.Split(',').ToList();

                    data.Add(new Player(cells));
                }
            }

            return data;
        }
    }
}
