// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.EventGrid.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Filters configuration for the Event Subscription.
    /// </summary>
    public partial class FiltersConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the FiltersConfiguration class.
        /// </summary>
        public FiltersConfiguration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FiltersConfiguration class.
        /// </summary>
        /// <param name="includedEventTypes">A list of applicable event types
        /// that need to be part of the event subscription. If it is desired to
        /// subscribe to all default event types, set the IncludedEventTypes to
        /// null.</param>
        /// <param name="filters">An array of filters that are used for
        /// filtering event subscriptions.</param>
        public FiltersConfiguration(IList<string> includedEventTypes = default(IList<string>), IList<Filter> filters = default(IList<Filter>))
        {
            IncludedEventTypes = includedEventTypes;
            Filters = filters;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a list of applicable event types that need to be part
        /// of the event subscription. If it is desired to subscribe to all
        /// default event types, set the IncludedEventTypes to null.
        /// </summary>
        [JsonProperty(PropertyName = "includedEventTypes")]
        public IList<string> IncludedEventTypes { get; set; }

        /// <summary>
        /// Gets or sets an array of filters that are used for filtering event
        /// subscriptions.
        /// </summary>
        [JsonProperty(PropertyName = "filters")]
        public IList<Filter> Filters { get; set; }

    }
}
