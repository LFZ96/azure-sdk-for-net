// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Communication.JobRouter
{
    /// <summary> The UnknownWorkerSelectorAttachment. </summary>
    internal partial class UnknownWorkerSelectorAttachment : WorkerSelectorAttachment
    {
        /// <summary> Initializes a new instance of UnknownWorkerSelectorAttachment. </summary>
        /// <param name="kind"> The type discriminator describing the type of label selector attachment. </param>
        internal UnknownWorkerSelectorAttachment(string kind) : base(kind)
        {
            Kind = kind ?? "Unknown";
        }
    }
}
