// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.AzureStack.Management.Storage.Admin.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Metric information.
    /// </summary>
    public partial class Metric
    {
        /// <summary>
        /// Initializes a new instance of the Metric class.
        /// </summary>
        public Metric()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Metric class.
        /// </summary>
        /// <param name="name">Metric Name.</param>
        /// <param name="metricUnit">Metric Unit. Possible values include:
        /// 'Count', 'Bytes', 'Seconds', 'CountPerSecond',
        /// 'BytesPerSecond'</param>
        /// <param name="timeGrain">Metric time grain.</param>
        /// <param name="startTime">Metric start time.</param>
        /// <param name="endTime">Metric end time.</param>
        /// <param name="metricValues">List of metric values.</param>
        public Metric(LocalizableString name = default(LocalizableString), string metricUnit = default(string), string timeGrain = default(string), System.DateTime? startTime = default(System.DateTime?), System.DateTime? endTime = default(System.DateTime?), IList<MetricValue> metricValues = default(IList<MetricValue>))
        {
            Name = name;
            MetricUnit = metricUnit;
            TimeGrain = timeGrain;
            StartTime = startTime;
            EndTime = endTime;
            MetricValues = metricValues;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets metric Name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public LocalizableString Name { get; private set; }

        /// <summary>
        /// Gets metric Unit. Possible values include: 'Count', 'Bytes',
        /// 'Seconds', 'CountPerSecond', 'BytesPerSecond'
        /// </summary>
        [JsonProperty(PropertyName = "metricUnit")]
        public string MetricUnit { get; private set; }

        /// <summary>
        /// Gets metric time grain.
        /// </summary>
        [JsonProperty(PropertyName = "timeGrain")]
        public string TimeGrain { get; private set; }

        /// <summary>
        /// Gets metric start time.
        /// </summary>
        [JsonProperty(PropertyName = "startTime")]
        public System.DateTime? StartTime { get; private set; }

        /// <summary>
        /// Gets metric end time.
        /// </summary>
        [JsonProperty(PropertyName = "endTime")]
        public System.DateTime? EndTime { get; private set; }

        /// <summary>
        /// Gets list of metric values.
        /// </summary>
        [JsonProperty(PropertyName = "metricValues")]
        public IList<MetricValue> MetricValues { get; private set; }

    }
}