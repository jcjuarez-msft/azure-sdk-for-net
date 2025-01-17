// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AlertsManagement.Models
{
    /// <summary> Alerts summary group item. </summary>
    public partial class ServiceAlertsSummaryGroupItemData
    {
        /// <summary> Initializes a new instance of ServiceAlertsSummaryGroupItemData. </summary>
        public ServiceAlertsSummaryGroupItemData()
        {
            Values = new ChangeTrackingList<ServiceAlertsSummaryGroupItemData>();
        }

        /// <summary> Initializes a new instance of ServiceAlertsSummaryGroupItemData. </summary>
        /// <param name="name"> Value of the aggregated field. </param>
        /// <param name="count"> Count of the aggregated field. </param>
        /// <param name="groupedBy"> Name of the field aggregated. </param>
        /// <param name="values"> List of the items. </param>
        internal ServiceAlertsSummaryGroupItemData(string name, long? count, string groupedBy, IList<ServiceAlertsSummaryGroupItemData> values)
        {
            Name = name;
            Count = count;
            GroupedBy = groupedBy;
            Values = values;
        }

        /// <summary> Value of the aggregated field. </summary>
        public string Name { get; set; }
        /// <summary> Count of the aggregated field. </summary>
        public long? Count { get; set; }
        /// <summary> Name of the field aggregated. </summary>
        public string GroupedBy { get; set; }
        /// <summary> List of the items. </summary>
        public IList<ServiceAlertsSummaryGroupItemData> Values { get; }
    }
}
