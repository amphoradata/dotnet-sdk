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
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using AmphoraData.Client.Client;
using AmphoraData.Client.Api;

namespace AmphoraData.Client.Test
{
    /// <summary>
    ///  Class for testing ImagesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ImagesApiTests : IDisposable
    {
        private ImagesApi instance;

        public ImagesApiTests()
        {
            instance = new ImagesApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ImagesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ImagesApi
            //Assert.IsType(typeof(ImagesApi), instance, "instance is a ImagesApi");
        }

        
        /// <summary>
        /// Test ApiOrganisationsIdProfileJpgGet
        /// </summary>
        [Fact]
        public void ApiOrganisationsIdProfileJpgGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.ApiOrganisationsIdProfileJpgGet(id);
            
        }
        
    }

}