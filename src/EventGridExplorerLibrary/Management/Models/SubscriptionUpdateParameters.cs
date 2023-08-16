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
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Properties of the Event Subscription update.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class SubscriptionUpdateParameters
    {
        /// <summary>
        /// Initializes a new instance of the SubscriptionUpdateParameters
        /// class.
        /// </summary>
        public SubscriptionUpdateParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SubscriptionUpdateParameters
        /// class.
        /// </summary>
        /// <param name="deliveryConfiguration">Information about the delivery
        /// configuration of the event subscription.</param>
        /// <param name="eventDeliverySchema">The event delivery schema for the
        /// event subscription. Possible values include:
        /// 'CloudEventSchemaV1_0'</param>
        /// <param name="filtersConfiguration">Information about the filter for
        /// the event subscription.</param>
        public SubscriptionUpdateParameters(DeliveryConfiguration deliveryConfiguration = default(DeliveryConfiguration), string eventDeliverySchema = default(string), FiltersConfiguration filtersConfiguration = default(FiltersConfiguration))
        {
            DeliveryConfiguration = deliveryConfiguration;
            EventDeliverySchema = eventDeliverySchema;
            FiltersConfiguration = filtersConfiguration;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets information about the delivery configuration of the
        /// event subscription.
        /// </summary>
        [JsonProperty(PropertyName = "properties.deliveryConfiguration")]
        public DeliveryConfiguration DeliveryConfiguration { get; set; }

        /// <summary>
        /// Gets or sets the event delivery schema for the event subscription.
        /// Possible values include: 'CloudEventSchemaV1_0'
        /// </summary>
        [JsonProperty(PropertyName = "properties.eventDeliverySchema")]
        public string EventDeliverySchema { get; set; }

        /// <summary>
        /// Gets or sets information about the filter for the event
        /// subscription.
        /// </summary>
        [JsonProperty(PropertyName = "properties.filtersConfiguration")]
        public FiltersConfiguration FiltersConfiguration { get; set; }

    }
}
