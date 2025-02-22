// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.AppService;

namespace Azure.ResourceManager.AppService.Models
{
    internal partial class PublishingCredentialsPoliciesListResult
    {
        internal static PublishingCredentialsPoliciesListResult DeserializePublishingCredentialsPoliciesListResult(JsonElement element)
        {
            IReadOnlyList<CsmPublishingCredentialsPoliciesEntityData> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<CsmPublishingCredentialsPoliciesEntityData> array = new List<CsmPublishingCredentialsPoliciesEntityData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CsmPublishingCredentialsPoliciesEntityData.DeserializeCsmPublishingCredentialsPoliciesEntityData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new PublishingCredentialsPoliciesListResult(value, nextLink.Value);
        }
    }
}
