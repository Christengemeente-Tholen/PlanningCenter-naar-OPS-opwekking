namespace PlanningCenter_to_OPS
{
    internal class Config
    {
        public string app_id;
        public string secret;
        public string song_folder;
        public bool opw_selector_enabled;
        public bool kopw_selector_enabled;
        public string opw_selector;
        public string kopw_selector;
        public bool opw_case_sensitive;
        public bool kopw_case_sensitive;
        public string et_abbreviation;
        public string et_bundle_name;
        public bool et_enabled;
        public string last_used_ops_theme;

        public Config()
        {
            app_id = Properties.Settings.Default.app_id;
            secret = Properties.Settings.Default.secret;
            song_folder = Properties.Settings.Default.song_folder;
            opw_selector_enabled = Properties.Settings.Default.opw_selector_enabled;
            kopw_selector_enabled = Properties.Settings.Default.kopw_selector_enabled;
            opw_selector = Properties.Settings.Default.opw_selector;
            kopw_selector = Properties.Settings.Default.kopw_selector;
            opw_case_sensitive = Properties.Settings.Default.opw_case_sensitive;
            kopw_case_sensitive = Properties.Settings.Default.kopw_case_sensitive;
            et_abbreviation = Properties.Settings.Default.et_abbreviation;
            et_bundle_name = Properties.Settings.Default.et_bundle_name;
            et_enabled = Properties.Settings.Default.et_enabled;
            last_used_ops_theme = Properties.Settings.Default.last_used_ops_theme;
        }

        public void Update()
        {
            Properties.Settings.Default.app_id = app_id;
            Properties.Settings.Default.secret = secret;
            Properties.Settings.Default.song_folder = song_folder;
            Properties.Settings.Default.opw_selector_enabled = opw_selector_enabled;
            Properties.Settings.Default.kopw_selector_enabled = kopw_selector_enabled;
            Properties.Settings.Default.opw_selector = opw_selector;
            Properties.Settings.Default.kopw_selector = kopw_selector;
            Properties.Settings.Default.opw_case_sensitive = opw_case_sensitive;
            Properties.Settings.Default.kopw_case_sensitive = kopw_case_sensitive;
            Properties.Settings.Default.et_abbreviation = et_abbreviation;
            Properties.Settings.Default.et_bundle_name = et_bundle_name;
            Properties.Settings.Default.et_enabled = et_enabled;
            Properties.Settings.Default.last_used_ops_theme = last_used_ops_theme;
            Properties.Settings.Default.Save();
        }
    }
}
