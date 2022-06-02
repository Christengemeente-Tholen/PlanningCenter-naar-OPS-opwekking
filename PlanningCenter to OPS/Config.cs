namespace PlanningCenter_to_OPS
{
    internal class Config
    {
        public string app_id;
        public string secret;
        public string song_folder;

        public Config()
        {
            app_id = Properties.Settings.Default.app_id;
            secret = Properties.Settings.Default.secret;
            song_folder = Properties.Settings.Default.song_folder;
        }

        public void Update()
        {
            Properties.Settings.Default.app_id = app_id;
            Properties.Settings.Default.secret = secret;
            Properties.Settings.Default.song_folder = song_folder;
            Properties.Settings.Default.Save();
        }
    }
}
