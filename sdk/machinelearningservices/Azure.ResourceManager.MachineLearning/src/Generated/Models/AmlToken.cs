// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> AML Token identity configuration. </summary>
    public partial class AmlToken : IdentityConfiguration
    {
        /// <summary> Initializes a new instance of AmlToken. </summary>
        public AmlToken()
        {
            IdentityType = IdentityConfigurationType.AMLToken;
        }

        /// <summary> Initializes a new instance of AmlToken. </summary>
        /// <param name="identityType"> [Required] Specifies the type of identity framework. </param>
        internal AmlToken(IdentityConfigurationType identityType) : base(identityType)
        {
            IdentityType = identityType;
        }
    }
}
