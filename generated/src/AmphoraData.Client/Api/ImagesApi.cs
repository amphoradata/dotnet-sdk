/* 
 * Amphora Data Api
 *
 * API for interacting with the Amphora Data platform.
 *
 * The version of the OpenAPI document: 0.0.2
 * Contact: rian@amphoradata.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using AmphoraData.Client.Client;

namespace AmphoraData.Client.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IImagesApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Gets an organisations profile picture
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="AmphoraData.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Amphora Id</param>
        /// <returns></returns>
        void ApiOrganisationsIdProfileJpgGet (string id);

        /// <summary>
        /// Gets an organisations profile picture
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="AmphoraData.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Amphora Id</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ApiOrganisationsIdProfileJpgGetWithHttpInfo (string id);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IImagesApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Gets an organisations profile picture
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="AmphoraData.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Amphora Id</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ApiOrganisationsIdProfileJpgGetAsync (string id);

        /// <summary>
        /// Gets an organisations profile picture
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="AmphoraData.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Amphora Id</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ApiOrganisationsIdProfileJpgGetAsyncWithHttpInfo (string id);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IImagesApi : IImagesApiSync, IImagesApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ImagesApi : IImagesApi
    {
        private AmphoraData.Client.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ImagesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ImagesApi() : this((string) null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImagesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ImagesApi(String basePath)
        {
            this.Configuration = AmphoraData.Client.Client.Configuration.MergeConfigurations(
                AmphoraData.Client.Client.GlobalConfiguration.Instance,
                new AmphoraData.Client.Client.Configuration { BasePath = basePath }
            );
            this.Client = new AmphoraData.Client.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new AmphoraData.Client.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = AmphoraData.Client.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImagesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ImagesApi(AmphoraData.Client.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = AmphoraData.Client.Client.Configuration.MergeConfigurations(
                AmphoraData.Client.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new AmphoraData.Client.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new AmphoraData.Client.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = AmphoraData.Client.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PetApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public ImagesApi(AmphoraData.Client.Client.ISynchronousClient client,AmphoraData.Client.Client.IAsynchronousClient asyncClient, AmphoraData.Client.Client.IReadableConfiguration configuration)
        {
            if(client == null) throw new ArgumentNullException("client");
            if(asyncClient == null) throw new ArgumentNullException("asyncClient");
            if(configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = AmphoraData.Client.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public AmphoraData.Client.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public AmphoraData.Client.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public AmphoraData.Client.Client.IReadableConfiguration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public AmphoraData.Client.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets an organisations profile picture 
        /// </summary>
        /// <exception cref="AmphoraData.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Amphora Id</param>
        /// <returns></returns>
        public void ApiOrganisationsIdProfileJpgGet (string id)
        {
             ApiOrganisationsIdProfileJpgGetWithHttpInfo(id);
        }

        /// <summary>
        /// Gets an organisations profile picture 
        /// </summary>
        /// <exception cref="AmphoraData.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Amphora Id</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public AmphoraData.Client.Client.ApiResponse<Object> ApiOrganisationsIdProfileJpgGetWithHttpInfo (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new AmphoraData.Client.Client.ApiException(400, "Missing required parameter 'id' when calling ImagesApi->ApiOrganisationsIdProfileJpgGet");

            AmphoraData.Client.Client.RequestOptions requestOptions = new AmphoraData.Client.Client.RequestOptions();

            String[] @contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] @accepts = new String[] {
            };

            var localVarContentType = AmphoraData.Client.Client.ClientUtils.SelectHeaderContentType(@contentTypes);
            if (localVarContentType != null) requestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = AmphoraData.Client.Client.ClientUtils.SelectHeaderAccept(@accepts);
            if (localVarAccept != null) requestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (id != null)
                requestOptions.PathParameters.Add("id", AmphoraData.Client.Client.ClientUtils.ParameterToString(id)); // path parameter


            // make the HTTP request

            var response = this.Client.Get<Object>("/api/organisations/{id}/profile.jpg", requestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("ApiOrganisationsIdProfileJpgGet", response);
                if (exception != null) throw exception;
            }

            return response;
        }

        /// <summary>
        /// Gets an organisations profile picture 
        /// </summary>
        /// <exception cref="AmphoraData.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Amphora Id</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ApiOrganisationsIdProfileJpgGetAsync (string id)
        {
             await ApiOrganisationsIdProfileJpgGetAsyncWithHttpInfo(id);

        }

        /// <summary>
        /// Gets an organisations profile picture 
        /// </summary>
        /// <exception cref="AmphoraData.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Amphora Id</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<AmphoraData.Client.Client.ApiResponse<Object>> ApiOrganisationsIdProfileJpgGetAsyncWithHttpInfo (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new AmphoraData.Client.Client.ApiException(400, "Missing required parameter 'id' when calling ImagesApi->ApiOrganisationsIdProfileJpgGet");


            AmphoraData.Client.Client.RequestOptions requestOptions = new AmphoraData.Client.Client.RequestOptions();

            String[] @contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] @accepts = new String[] {
            };
            
            foreach (var contentType in @contentTypes)
                requestOptions.HeaderParameters.Add("Content-Type", contentType);
            
            foreach (var accept in @accepts)
                requestOptions.HeaderParameters.Add("Accept", accept);
            
            if (id != null)
                requestOptions.PathParameters.Add("id", AmphoraData.Client.Client.ClientUtils.ParameterToString(id)); // path parameter


            // make the HTTP request

            var response = await this.AsynchronousClient.GetAsync<Object>("/api/organisations/{id}/profile.jpg", requestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("ApiOrganisationsIdProfileJpgGet", response);
                if (exception != null) throw exception;
            }

            return response;
        }

    }
}