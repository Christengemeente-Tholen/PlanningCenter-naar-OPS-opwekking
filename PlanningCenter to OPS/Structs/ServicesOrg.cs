namespace PlanningCenter_to_OPS.Structs
{
    internal class ServicesOrgAttributes
    {
        public string name { get; set; }
    }

    internal class ServicesOrgData
    {
        public ServicesOrgAttributes attributes { get; set; }
    }

    internal class ServicesOrg
    {
        public ServicesOrgData data { get; set; }
    }
}