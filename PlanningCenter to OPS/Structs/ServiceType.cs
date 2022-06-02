using System.Collections.Generic;

namespace PlanningCenter_to_OPS.Structs
{
    internal class ServiceTypeAttributes
    {
        public string name { get; set; }
    }

    internal class ServiceTypeInfo
    {
        public string id { get; set; }
        public ServiceTypeAttributes attributes { get; set; }
    }

    internal class ServiceType
    {
        public List<ServiceTypeInfo> data { get; set; }
    }
}
