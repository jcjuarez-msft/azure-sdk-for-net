// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Cosmos DB SQL container resource object. </summary>
    public partial class CosmosDBSqlContainerResourceInfo
    {
        /// <summary> Initializes a new instance of CosmosDBSqlContainerResourceInfo. </summary>
        /// <param name="id"> Name of the Cosmos DB SQL container. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public CosmosDBSqlContainerResourceInfo(string id)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            Id = id;
        }

        /// <summary> Initializes a new instance of CosmosDBSqlContainerResourceInfo. </summary>
        /// <param name="id"> Name of the Cosmos DB SQL container. </param>
        /// <param name="indexingPolicy"> The configuration of the indexing policy. By default, the indexing is automatic for all document paths within the container. </param>
        /// <param name="partitionKey"> The configuration of the partition key to be used for partitioning data into multiple partitions. </param>
        /// <param name="defaultTtl"> Default time to live. </param>
        /// <param name="uniqueKeyPolicy"> The unique key policy configuration for specifying uniqueness constraints on documents in the collection in the Azure Cosmos DB service. </param>
        /// <param name="conflictResolutionPolicy"> The conflict resolution policy for the container. </param>
        /// <param name="analyticalStorageTtl"> Analytical TTL. </param>
        internal CosmosDBSqlContainerResourceInfo(string id, CosmosDBIndexingPolicy indexingPolicy, ContainerPartitionKey partitionKey, int? defaultTtl, CosmosDBUniqueKeyPolicy uniqueKeyPolicy, ConflictResolutionPolicy conflictResolutionPolicy, long? analyticalStorageTtl)
        {
            Id = id;
            IndexingPolicy = indexingPolicy;
            PartitionKey = partitionKey;
            DefaultTtl = defaultTtl;
            UniqueKeyPolicy = uniqueKeyPolicy;
            ConflictResolutionPolicy = conflictResolutionPolicy;
            AnalyticalStorageTtl = analyticalStorageTtl;
        }

        /// <summary> Name of the Cosmos DB SQL container. </summary>
        public string Id { get; set; }
        /// <summary> The configuration of the indexing policy. By default, the indexing is automatic for all document paths within the container. </summary>
        public CosmosDBIndexingPolicy IndexingPolicy { get; set; }
        /// <summary> The configuration of the partition key to be used for partitioning data into multiple partitions. </summary>
        public ContainerPartitionKey PartitionKey { get; set; }
        /// <summary> Default time to live. </summary>
        public int? DefaultTtl { get; set; }
        /// <summary> The unique key policy configuration for specifying uniqueness constraints on documents in the collection in the Azure Cosmos DB service. </summary>
        internal CosmosDBUniqueKeyPolicy UniqueKeyPolicy { get; set; }
        /// <summary> List of unique keys on that enforces uniqueness constraint on documents in the collection in the Azure Cosmos DB service. </summary>
        public IList<CosmosDBUniqueKey> UniqueKeys
        {
            get
            {
                if (UniqueKeyPolicy is null)
                    UniqueKeyPolicy = new CosmosDBUniqueKeyPolicy();
                return UniqueKeyPolicy.UniqueKeys;
            }
        }

        /// <summary> The conflict resolution policy for the container. </summary>
        public ConflictResolutionPolicy ConflictResolutionPolicy { get; set; }
        /// <summary> Analytical TTL. </summary>
        public long? AnalyticalStorageTtl { get; set; }
    }
}
