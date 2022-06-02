using System.Collections.Generic;

namespace PlanningCenter_to_OPS.Structs
{
    internal class ServicePlanAttributes
    {
        public string title { get; set; }
        public string dates { get; set; }
    }

    internal class ServicePlanLinks
    {
        public string self { get; set; }
    }

    internal class ServicePlanData
    {
        public ServicePlanAttributes attributes { get; set; }
        public ServicePlanLinks links { get; set; }
    }

    internal class ServicePlans
    {
        public List<ServicePlanData> data { get; set; }
    }
}
