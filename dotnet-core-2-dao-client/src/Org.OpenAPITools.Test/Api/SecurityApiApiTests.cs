/* 
 * Femr Core
 *
 * Femr Core
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

using Org.OpenAPITools.Client;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Model;

namespace Org.OpenAPITools.Test
{
    /// <summary>
    ///  Class for testing SecurityApiApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class SecurityApiApiTests : IDisposable
    {
        private SecurityApiApi instance;

        public SecurityApiApiTests()
        {
            instance = new SecurityApiApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SecurityApiApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' SecurityApiApi
            //Assert.IsType(typeof(SecurityApiApi), instance, "instance is a SecurityApiApi");
        }

        
        /// <summary>
        /// Test SecurityLoginPost
        /// </summary>
        [Fact]
        public void SecurityLoginPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //InlineObject inlineObject = null;
            //var response = instance.SecurityLoginPost(inlineObject);
            //Assert.IsType<InlineResponse200> (response, "response is InlineResponse200");
        }
        
        /// <summary>
        /// Test SecurityRefreshPost
        /// </summary>
        [Fact]
        public void SecurityRefreshPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.SecurityRefreshPost();
            //Assert.IsType<InlineResponse2001> (response, "response is InlineResponse2001");
        }
        
    }

}
