// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.14.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Graph.RBAC
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;

    public static partial class ObjectsOperationsExtensions
    {
            /// <summary>
            /// Gets AD group membership by provided AD object Ids
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='parameters'>
            /// Objects filtering parameters.
            /// </param>
            public static IPage<AADObject> GetObjectsByObjectIds(this IObjectsOperations operations, GetObjectsParameters parameters)
            {
                return Task.Factory.StartNew(s => ((IObjectsOperations)s).GetObjectsByObjectIdsAsync(parameters), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets AD group membership by provided AD object Ids
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='parameters'>
            /// Objects filtering parameters.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<AADObject>> GetObjectsByObjectIdsAsync( this IObjectsOperations operations, GetObjectsParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                var _result = await operations.GetObjectsByObjectIdsWithHttpMessagesAsync(parameters, null, cancellationToken).ConfigureAwait(false);
                return _result.Body;
            }

            /// <summary>
            /// Gets AD group membership by provided AD object Ids
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<AADObject> GetObjectsByObjectIdsNext(this IObjectsOperations operations, string nextPageLink)
            {
                return Task.Factory.StartNew(s => ((IObjectsOperations)s).GetObjectsByObjectIdsNextAsync(nextPageLink), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets AD group membership by provided AD object Ids
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<AADObject>> GetObjectsByObjectIdsNextAsync( this IObjectsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                var _result = await operations.GetObjectsByObjectIdsNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false);
                return _result.Body;
            }

    }
}