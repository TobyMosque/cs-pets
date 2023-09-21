/*
 * Swagger Petstore - OpenAPI 3.0
 *
 * This is a sample Pet Store Server based on the OpenAPI 3.0 specification.  You can find out more about Swagger at [http://swagger.io](http://swagger.io). In the third iteration of the pet store, we've switched to the design first approach! You can now help us improve the API whether it's by making changes to the definition itself or to the code. That way, with time, we can improve the API in general, and expose some of the new features in OAS3.  Some useful links: - [The Pet Store repository](https://github.com/swagger-api/swagger-petstore) - [The source API definition for the Pet Store](https://github.com/swagger-api/swagger-petstore/blob/master/src/main/resources/openapi.yaml)
 *
 * The version of the OpenAPI document: 1.0.17
 * Contact: apiteam@swagger.io
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using Xunit;

using OpenApi.Pets.Sdk.Client;
using OpenApi.Pets.Sdk.Api;
// uncomment below to import models
//using OpenApi.Pets.Sdk.Model;

namespace OpenApi.Pets.Sdk.Test.Api
{
    /// <summary>
    ///  Class for testing PetApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class PetApiTests : IDisposable
    {
        private PetApi instance;

        public PetApiTests()
        {
            instance = new PetApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PetApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' PetApi
            //Assert.IsType<PetApi>(instance);
        }

        /// <summary>
        /// Test AddPet
        /// </summary>
        [Fact]
        public void AddPetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Pet pet = null;
            //var response = instance.AddPet(pet);
            //Assert.IsType<Pet>(response);
        }

        /// <summary>
        /// Test DeletePet
        /// </summary>
        [Fact]
        public void DeletePetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long petId = null;
            //string? apiKey = null;
            //instance.DeletePet(petId, apiKey);
        }

        /// <summary>
        /// Test FindPetsByStatus
        /// </summary>
        [Fact]
        public void FindPetsByStatusTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? status = null;
            //var response = instance.FindPetsByStatus(status);
            //Assert.IsType<Collection<Pet>>(response);
        }

        /// <summary>
        /// Test FindPetsByTags
        /// </summary>
        [Fact]
        public void FindPetsByTagsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Collection<string>? tags = null;
            //var response = instance.FindPetsByTags(tags);
            //Assert.IsType<Collection<Pet>>(response);
        }

        /// <summary>
        /// Test GetPetById
        /// </summary>
        [Fact]
        public void GetPetByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long petId = null;
            //var response = instance.GetPetById(petId);
            //Assert.IsType<Pet>(response);
        }

        /// <summary>
        /// Test UpdatePet
        /// </summary>
        [Fact]
        public void UpdatePetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Pet pet = null;
            //var response = instance.UpdatePet(pet);
            //Assert.IsType<Pet>(response);
        }

        /// <summary>
        /// Test UpdatePetWithForm
        /// </summary>
        [Fact]
        public void UpdatePetWithFormTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long petId = null;
            //string? name = null;
            //string? status = null;
            //instance.UpdatePetWithForm(petId, name, status);
        }

        /// <summary>
        /// Test UploadFile
        /// </summary>
        [Fact]
        public void UploadFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long petId = null;
            //string? additionalMetadata = null;
            //FileParameter? body = null;
            //var response = instance.UploadFile(petId, additionalMetadata, body);
            //Assert.IsType<ApiResponse>(response);
        }
    }
}