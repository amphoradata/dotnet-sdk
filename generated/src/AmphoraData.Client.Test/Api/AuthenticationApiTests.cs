/* 
 * AmphoraApi
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: v1
 * 
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
using AmphoraData.Client.Model;

namespace AmphoraData.Client.Test
{
    /// <summary>
    ///  Class for testing AuthenticationApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class AuthenticationApiTests : IDisposable
    {
        private AuthenticationApi instance;

        public AuthenticationApiTests()
        {
            instance = new AuthenticationApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AuthenticationApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' AuthenticationApi
            //Assert.IsType(typeof(AuthenticationApi), instance, "instance is a AuthenticationApi");
        }

        
        /// <summary>
        /// Test ApiAuthenticationRequestPost
        /// </summary>
        [Fact]
        public void ApiAuthenticationRequestPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TokenRequest tokenRequest = null;
            //var response = instance.ApiAuthenticationRequestPost(tokenRequest);
            //Assert.IsType<string> (response, "response is string");
        }
        
    }

}
