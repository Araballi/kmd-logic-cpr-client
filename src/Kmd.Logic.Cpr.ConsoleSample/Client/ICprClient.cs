// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Kmd.Logic.Cpr.ConsoleSample.Client
{
    using Microsoft.Rest;
    using Models;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.IO;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// </summary>
    public partial interface ICprClient : System.IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }

        /// <summary>
        /// Client API version.
        /// </summary>
        string ApiVersion { get; }

        /// <summary>
        /// Subscription credentials which uniquely identify client
        /// subscription.
        /// </summary>
        ServiceClientCredentials Credentials { get; }


        /// <summary>
        /// Gets citizen data by CPR
        /// </summary>
        /// <param name='subscriptionId'>
        /// LoGIC subscription ID
        /// </param>
        /// <param name='cpr'>
        /// Personal identification number of danish citizen
        /// </param>
        /// <param name='configurationId'>
        /// Identifier that represents CPR environment and associated
        /// configuration which this request will be sent with.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<Citizen>> GetByCprWithHttpMessagesAsync(System.Guid subscriptionId, string cpr, System.Guid? configurationId = default(System.Guid?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets citizen data by ID
        /// </summary>
        /// <param name='subscriptionId'>
        /// LoGIC subscription ID
        /// </param>
        /// <param name='id'>
        /// ID of danish citizen
        /// </param>
        /// <param name='configurationId'>
        /// Identifier that represents CPR environment and associated
        /// configuration which this request will be sent with.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<Citizen>> GetByIdWithHttpMessagesAsync(System.Guid subscriptionId, System.Guid id, System.Guid? configurationId = default(System.Guid?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Retrieves Cpr configuration assigned to the logic subscription
        /// </summary>
        /// <param name='subscriptionId'>
        /// </param>
        /// <param name='configurationId'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<CprProviderConfigurationModel>> GetCprConfigurationWithHttpMessagesAsync(System.Guid subscriptionId, System.Guid configurationId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Retrieves all Cpr configurations assigned to the logic subscription
        /// </summary>
        /// <param name='subscriptionId'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<IList<CprProviderConfigurationModel>>> GetAllCprConfigurationsWithHttpMessagesAsync(System.Guid subscriptionId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds new CPR configuration and uploads certificate file to the
        /// Azure Key Vault
        /// </summary>
        /// <param name='subscriptionId'>
        /// </param>
        /// <param name='name'>
        /// </param>
        /// <param name='environment'>
        /// Possible values include: 'production', 'test'
        /// </param>
        /// <param name='certificate'>
        /// </param>
        /// <param name='certificatePassword'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<CprProviderConfiguration>> CreateDataDistributorConfigurationWithHttpMessagesAsync(System.Guid subscriptionId, string name = default(string), string environment = default(string), Stream certificate = default(Stream), string certificatePassword = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds or updates existing cpr configuration and uploads certificate
        /// file to the Azure Key Vault
        /// </summary>
        /// <param name='subscriptionId'>
        /// </param>
        /// <param name='configurationId'>
        /// </param>
        /// <param name='name'>
        /// </param>
        /// <param name='environment'>
        /// Possible values include: 'production', 'test'
        /// </param>
        /// <param name='certificate'>
        /// </param>
        /// <param name='certificatePassword'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<CprProviderConfiguration>> UpdateDataDistributorConfigurationWithHttpMessagesAsync(System.Guid subscriptionId, System.Guid configurationId, string name = default(string), string environment = default(string), Stream certificate = default(Stream), string certificatePassword = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

    }
}
