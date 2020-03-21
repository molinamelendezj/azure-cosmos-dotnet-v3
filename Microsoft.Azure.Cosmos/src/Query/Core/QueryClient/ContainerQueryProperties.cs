﻿//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Cosmos.Query.Core.QueryClient
{
    using Microsoft.Azure.Documents;

    internal struct ContainerQueryProperties
    {
        internal ContainerQueryProperties(
            string resourceId,
            string effectivePartitionKeyString,
            PartitionKeyDefinition partitionKeyDefinition)
        {
            this.ResourceId = resourceId;
            this.EffectivePartitionKeyString = effectivePartitionKeyString;
            this.PartitionKeyDefinition = partitionKeyDefinition;
        }

        public string ResourceId { get; }
        public string EffectivePartitionKeyString { get; }
        internal PartitionKeyDefinition PartitionKeyDefinition { get; }
    }
}