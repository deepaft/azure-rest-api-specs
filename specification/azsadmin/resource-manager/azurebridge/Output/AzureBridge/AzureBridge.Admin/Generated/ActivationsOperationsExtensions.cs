// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.AzureStack.Management.AzureBridge.Admin
{
    using Microsoft.AzureStack;
    using Microsoft.AzureStack.Management;
    using Microsoft.AzureStack.Management.AzureBridge;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ActivationsOperations.
    /// </summary>
    public static partial class ActivationsOperationsExtensions
    {
            /// <summary>
            /// Return product name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IPage<ActivationResource> List(this IActivationsOperations operations)
            {
                return operations.ListAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Return product name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ActivationResource>> ListAsync(this IActivationsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Return product name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='activationName'>
            /// Name of the activation.
            /// </param>
            public static ActivationResource Get(this IActivationsOperations operations, string activationName)
            {
                return operations.GetAsync(activationName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Return product name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='activationName'>
            /// Name of the activation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ActivationResource> GetAsync(this IActivationsOperations operations, string activationName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(activationName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create a new activation.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='activationName'>
            /// Name of the activation.
            /// </param>
            /// <param name='activation'>
            /// new activation.
            /// </param>
            public static ActivationResource Put(this IActivationsOperations operations, string activationName, Activation activation)
            {
                return operations.PutAsync(activationName, activation).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create a new activation.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='activationName'>
            /// Name of the activation.
            /// </param>
            /// <param name='activation'>
            /// new activation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ActivationResource> PutAsync(this IActivationsOperations operations, string activationName, Activation activation, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PutWithHttpMessagesAsync(activationName, activation, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Return product name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ActivationResource> ListNext(this IActivationsOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Return product name.
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
            public static async Task<IPage<ActivationResource>> ListNextAsync(this IActivationsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
