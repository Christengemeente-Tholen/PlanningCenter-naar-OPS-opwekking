namespace PlanningCenter_to_OPS.BookTypes
{
    internal class EigenTeksten : BookType
    {
        public string override_name;

        public EigenTeksten(Config config)
        {
            this.override_name = config.et_bundle_name;
        }
        public override string SongBookName => this.override_name;

        public override string StyleName => "OPS";

        public override string SelectedVersion => "MyVersion";
    }
}
