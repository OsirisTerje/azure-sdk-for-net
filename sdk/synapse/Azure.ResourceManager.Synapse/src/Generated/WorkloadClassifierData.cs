// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Synapse
{
    /// <summary> A class representing the WorkloadClassifier data model. </summary>
    public partial class WorkloadClassifierData : ResourceData
    {
        /// <summary> Initializes a new instance of WorkloadClassifierData. </summary>
        public WorkloadClassifierData()
        {
        }

        /// <summary> Initializes a new instance of WorkloadClassifierData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="memberName"> The workload classifier member name. </param>
        /// <param name="label"> The workload classifier label. </param>
        /// <param name="context"> The workload classifier context. </param>
        /// <param name="startTime"> The workload classifier start time for classification. </param>
        /// <param name="endTime"> The workload classifier end time for classification. </param>
        /// <param name="importance"> The workload classifier importance. </param>
        internal WorkloadClassifierData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string memberName, string label, string context, string startTime, string endTime, string importance) : base(id, name, resourceType, systemData)
        {
            MemberName = memberName;
            Label = label;
            Context = context;
            StartTime = startTime;
            EndTime = endTime;
            Importance = importance;
        }

        /// <summary> The workload classifier member name. </summary>
        public string MemberName { get; set; }
        /// <summary> The workload classifier label. </summary>
        public string Label { get; set; }
        /// <summary> The workload classifier context. </summary>
        public string Context { get; set; }
        /// <summary> The workload classifier start time for classification. </summary>
        public string StartTime { get; set; }
        /// <summary> The workload classifier end time for classification. </summary>
        public string EndTime { get; set; }
        /// <summary> The workload classifier importance. </summary>
        public string Importance { get; set; }
    }
}
