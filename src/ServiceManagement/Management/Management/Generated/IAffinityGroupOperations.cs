// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure;
using Microsoft.WindowsAzure.Management.Models;

namespace Microsoft.WindowsAzure.Management
{
    /// <summary>
    /// Operations for managing affinity groups in your subscription.  (see
    /// http://msdn.microsoft.com/en-us/library/windowsazure/ee460798.aspx for
    /// more information)
    /// </summary>
    public partial interface IAffinityGroupOperations
    {
        /// <summary>
        /// The Create Affinity Group operation creates a new affinity group
        /// for the specified subscription.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/gg715317.aspx
        /// for more information)
        /// </summary>
        /// <param name='parameters'>
        /// Parameters supplied to the Create Affinity Group operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<AzureOperationResponse> CreateAsync(AffinityGroupCreateParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// The Delete Affinity Group operation deletes an affinity group in
        /// the specified subscription.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/gg715314.aspx
        /// for more information)
        /// </summary>
        /// <param name='affinityGroupName'>
        /// The name of the affinity group.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<AzureOperationResponse> DeleteAsync(string affinityGroupName, CancellationToken cancellationToken);
        
        /// <summary>
        /// The Get Affinity Group Properties operation returns the system
        /// properties associated with the specified affinity group.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/ee460789.aspx
        /// for more information)
        /// </summary>
        /// <param name='affinityGroupName'>
        /// The name of the desired affinity group as returned by the name
        /// element of the List Affinity Groups operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The Get Affinity Group operation response.
        /// </returns>
        Task<AffinityGroupGetResponse> GetAsync(string affinityGroupName, CancellationToken cancellationToken);
        
        /// <summary>
        /// The List Affinity Groups operation lists the affinity groups
        /// associated with the specified subscription.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/ee460797.aspx
        /// for more information)
        /// </summary>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The List Affinity Groups operation response.
        /// </returns>
        Task<AffinityGroupListResponse> ListAsync(CancellationToken cancellationToken);
        
        /// <summary>
        /// The Update Affinity Group operation updates the label and/or the
        /// description for an affinity group for the specified subscription.
        /// (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/gg715316.aspx
        /// for more information)
        /// </summary>
        /// <param name='affinityGroupName'>
        /// The name of the affinity group.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the Update Affinity Group operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<AzureOperationResponse> UpdateAsync(string affinityGroupName, AffinityGroupUpdateParameters parameters, CancellationToken cancellationToken);
    }
}
