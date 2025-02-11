using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Windows.Forms;

namespace PlanningCenter_to_OPS.Actions
{

    internal class UpdateView
    {
        internal static (Dictionary<string, string>, Dictionary<string, string>) UpdateServiceType(Config config, ComboBox combo_box, ComboBox plans_selector, Dictionary<string, string> plans_info)
        {
            combo_box.Items.Clear();
            try
            {
                Structs.ServiceType ServiceTypeDict = Api.GetServiceType(config);
                Dictionary<string, string> ServiceTypes = new Dictionary<string, string>();
                ServiceTypeDict.data.ForEach(x =>
                {
                    string currrent_service = x.attributes.name;
                    int i = 1;

                    if (combo_box.Items.Contains(currrent_service))
                    {
                        while (combo_box.Items.Contains(currrent_service + " " + i))
                        {
                            i++;
                        }
                        combo_box.Items.Add(currrent_service + " " + i);
                        ServiceTypes.Add(currrent_service + " " + i, x.id);
                    }
                    combo_box.Items.Add(currrent_service);
                    ServiceTypes.Add(currrent_service, x.id);
                });
                // Only update when nothing was selected before
                if (combo_box.SelectedIndex == -1 && combo_box.Items.Count > 0)
                {
                    combo_box.SelectedIndex = 0;
                    plans_info = UpdatePlans(config, plans_selector, ServiceTypes[combo_box.SelectedItem.ToString()]);
                }

                return (ServiceTypes, plans_info);
            }
            catch (WebException e)
            {
                MessageBox.Show(e.Message);
                return (new Dictionary<string, string>(), plans_info);
            }
        }

        internal static List<string> filter_date_types = new List<string>() {"future", "no_dates"};

        internal static Dictionary<string, string> UpdatePlans(Config config, ComboBox combo_box, string selected_service_type)
        {
            Dictionary<string, string> ServiceTypes = new Dictionary<string, string>();
            List<Tuple<DateTime, string>> to_add = new List<Tuple<DateTime, string>>();
            combo_box.Items.Clear();
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

                        if (combo_box.Items.Contains(current_plan))
                        {
                            while (combo_box.Items.Contains(current_plan + " " + i))
                            {
                                i++;
                            }
                            combo_box.Items.Add(current_plan + " " + i);
                            ServiceTypes.Add(current_plan + " " + i, x.links.self);
                        } else
                        {
                            combo_box.Items.Add(current_plan);
                            ServiceTypes.Add(current_plan, x.links.self);
                        }
                    });
                });

                // Only update when nothing was selected before
                if (combo_box.SelectedIndex == -1 && combo_box.Items.Count > 0)
                {
                    combo_box.SelectedIndex = 0;
                }

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
