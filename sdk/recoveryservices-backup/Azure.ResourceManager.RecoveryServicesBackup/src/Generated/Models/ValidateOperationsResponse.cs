// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> The ValidateOperationsResponse. </summary>
    public partial class ValidateOperationsResponse
    {
        /// <summary> Initializes a new instance of ValidateOperationsResponse. </summary>
        internal ValidateOperationsResponse()
        {
        }

        /// <summary> Initializes a new instance of ValidateOperationsResponse. </summary>
        /// <param name="validateOperationResponse"> Base class for validate operation response. </param>
        internal ValidateOperationsResponse(ValidateOperationResponse validateOperationResponse)
        {
            ValidateOperationResponse = validateOperationResponse;
        }

        /// <summary> Base class for validate operation response. </summary>
        internal ValidateOperationResponse ValidateOperationResponse { get; }
        /// <summary> Gets the validation result. </summary>
        public IReadOnlyList<ErrorDetail> ValidateOperationResponseValidationResults
        {
            get => ValidateOperationResponse?.ValidationResults;
        }
    }
}
