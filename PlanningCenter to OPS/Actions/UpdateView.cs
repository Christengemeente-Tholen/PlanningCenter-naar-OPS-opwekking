using System.Collections.Generic;
using System.Net;
using System.Windows.Forms;

namespace PlanningCenter_to_OPS.Actions
{

    internal class UpdateView
    {
        internal static Dictionary<string, string> UpdateServiceType(Config config, ComboBox.ObjectCollection items)
        {
            items.Clear();
            try
            {
                Structs.ServiceType ServiceTypeDict = Api.GetServiceType(config);
                Dictionary<string, string> ServiceTypes = new Dictionary<string, string>();
                ServiceTypeDict.data.ForEach(x =>
                {
                    string currrent_service = x.attributes.name;
                    int i = 1;

                    if (items.Contains(currrent_service))
                    {
                        while (items.Contains(currrent_service + " " + i))
                        {
                            i++;
                        }
                        items.Add(currrent_service + " " + i);
                        ServiceTypes.Add(currrent_service + " " + i, x.id);
                    }
                    items.Add(currrent_service);
                    ServiceTypes.Add(currrent_service, x.id);
                });

                return ServiceTypes;
            }
            catch (WebException e)
            {
                MessageBox.Show(e.Message);
                return new Dictionary<string, string>();
            }
        }

        internal static List<string> filter_date_types = new List<string>() {"future", "no_dates"};

        internal static Dictionary<string, string> UpdatePlans(Config config, ComboBox.ObjectCollection items, string selected_service_type)
        {
            Dictionary<string, string> ServiceTypes = new Dictionary<string, string>();
            items.Clear();
            try
            {
                UpdateView.filter_date_types.ForEach(date_type =>
                {
                    Structs.ServicePlans ServiceTypeDict = Api.GetServicePlans(config, selected_service_type, date_type);
                    ServiceTypeDict.data.ForEach(x =>
                    {
                        string current_plan;
                        if (x.attributes.title != null)
                        {
                            current_plan = x.attributes.title;
                        }
                        else
                        {
                            current_plan = x.attributes.dates;
                        }
                        int i = 1;

                        if (items.Contains(current_plan))
                        {
                            while (items.Contains(current_plan + " " + i))
                            {
                                i++;
                            }
                            items.Add(current_plan + " " + i);
                            ServiceTypes.Add(current_plan + " " + i, x.links.self);
                        }
                        items.Add(current_plan);
                        ServiceTypes.Add(current_plan, x.links.self);
                    });
                });

                return ServiceTypes;
            }
            catch (WebException e)
            {
                MessageBox.Show(e.Message);
                return ServiceTypes;
            }
        }
    }
}
