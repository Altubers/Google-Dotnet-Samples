﻿// Copyright 2017 DAIMTO ([Linda Lawton](https://twitter.com/LindaLawtonDK)) :  [www.daimto.com](http://www.daimto.com/)
//
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on
// an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the
// specific language governing permissions and limitations under the License.
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by DAIMTO-Google-apis-Sample-generator 1.0.0
//     Template File Name:  methodTemplate.tt
//     Build date: 2017-10-08
//     C# generater version: 1.0.0
//     
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------  
// About 
// 
// Unoffical sample for the Storage v1beta2 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Lets you store and retrieve potentially-large, immutable data objects.
// API Documentation Link https://developers.google.com/storage/docs/json_api/
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Storage/v1beta2/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Storage.v1beta2/ 
// Install Command: PM>  Install-Package Google.Apis.Storage.v1beta2
//
//------------------------------------------------------------------------------  
using Google.Apis.Storage.v1beta2;
using Google.Apis.Storage.v1beta2.Data;
using System;

namespace GoogleSamplecSharpSample.Storagev1beta2.Methods
{
  
    public static class ObjectAccessControlsSample
    {

        public class ObjectAccessControlsDeleteOptionalParms
        {
            /// If present, selects a specific revision of this object (as opposed to the latest version, the default).
            public string Generation { get; set; }  
        
        }
 
        /// <summary>
        /// Permanently deletes the ACL entry for the specified entity on the specified object. 
        /// Documentation https://developers.google.com/storage/v1beta2/reference/objectAccessControls/delete
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Storage service.</param>  
        /// <param name="bucket">Name of a bucket.</param>
        /// <param name="object">Name of the object.</param>
        /// <param name="entity">The entity holding the permission. Can be user-userId, user-emailAddress, group-groupId, group-emailAddress, allUsers, or allAuthenticatedUsers.</param>
        /// <param name="optional">Optional paramaters.</param>
        public static void Delete(StorageService service, string bucket, string object, string entity, ObjectAccessControlsDeleteOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (bucket == null)
                    throw new ArgumentNullException(bucket);
                if (object == null)
                    throw new ArgumentNullException(object);
                if (entity == null)
                    throw new ArgumentNullException(entity);

                // Building the initial request.
                var request = service.ObjectAccessControls.Delete(bucket, object, entity);

                // Applying optional parameters to the request.                
                request = (ObjectAccessControlsResource.DeleteRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                 request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request ObjectAccessControls.Delete failed.", ex);
            }
        }
        public class ObjectAccessControlsGetOptionalParms
        {
            /// If present, selects a specific revision of this object (as opposed to the latest version, the default).
            public string Generation { get; set; }  
        
        }
 
        /// <summary>
        /// Returns the ACL entry for the specified entity on the specified object. 
        /// Documentation https://developers.google.com/storage/v1beta2/reference/objectAccessControls/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Storage service.</param>  
        /// <param name="bucket">Name of a bucket.</param>
        /// <param name="object">Name of the object.</param>
        /// <param name="entity">The entity holding the permission. Can be user-userId, user-emailAddress, group-groupId, group-emailAddress, allUsers, or allAuthenticatedUsers.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>ObjectAccessControlResponse</returns>
        public static ObjectAccessControl Get(StorageService service, string bucket, string object, string entity, ObjectAccessControlsGetOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (bucket == null)
                    throw new ArgumentNullException(bucket);
                if (object == null)
                    throw new ArgumentNullException(object);
                if (entity == null)
                    throw new ArgumentNullException(entity);

                // Building the initial request.
                var request = service.ObjectAccessControls.Get(bucket, object, entity);

                // Applying optional parameters to the request.                
                request = (ObjectAccessControlsResource.GetRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request ObjectAccessControls.Get failed.", ex);
            }
        }
        public class ObjectAccessControlsInsertOptionalParms
        {
            /// If present, selects a specific revision of this object (as opposed to the latest version, the default).
            public string Generation { get; set; }  
        
        }
 
        /// <summary>
        /// Creates a new ACL entry on the specified object. 
        /// Documentation https://developers.google.com/storage/v1beta2/reference/objectAccessControls/insert
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Storage service.</param>  
        /// <param name="bucket">Name of a bucket.</param>
        /// <param name="object">Name of the object.</param>
        /// <param name="body">A valid Storage v1beta2 body.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>ObjectAccessControlResponse</returns>
        public static ObjectAccessControl Insert(StorageService service, string bucket, string object, ObjectAccessControl body, ObjectAccessControlsInsertOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (bucket == null)
                    throw new ArgumentNullException(bucket);
                if (object == null)
                    throw new ArgumentNullException(object);

                // Building the initial request.
                var request = service.ObjectAccessControls.Insert(body, bucket, object);

                // Applying optional parameters to the request.                
                request = (ObjectAccessControlsResource.InsertRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request ObjectAccessControls.Insert failed.", ex);
            }
        }
        public class ObjectAccessControlsListOptionalParms
        {
            /// If present, selects a specific revision of this object (as opposed to the latest version, the default).
            public string Generation { get; set; }  
        
        }
 
        /// <summary>
        /// Retrieves ACL entries on the specified object. 
        /// Documentation https://developers.google.com/storage/v1beta2/reference/objectAccessControls/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Storage service.</param>  
        /// <param name="bucket">Name of a bucket.</param>
        /// <param name="object">Name of the object.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>ObjectAccessControlsResponse</returns>
        public static ObjectAccessControls List(StorageService service, string bucket, string object, ObjectAccessControlsListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (bucket == null)
                    throw new ArgumentNullException(bucket);
                if (object == null)
                    throw new ArgumentNullException(object);

                // Building the initial request.
                var request = service.ObjectAccessControls.List(bucket, object);

                // Applying optional parameters to the request.                
                request = (ObjectAccessControlsResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request ObjectAccessControls.List failed.", ex);
            }
        }
        public class ObjectAccessControlsPatchOptionalParms
        {
            /// If present, selects a specific revision of this object (as opposed to the latest version, the default).
            public string Generation { get; set; }  
        
        }
 
        /// <summary>
        /// Updates an ACL entry on the specified object. This method supports patch semantics. 
        /// Documentation https://developers.google.com/storage/v1beta2/reference/objectAccessControls/patch
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Storage service.</param>  
        /// <param name="bucket">Name of a bucket.</param>
        /// <param name="object">Name of the object.</param>
        /// <param name="entity">The entity holding the permission. Can be user-userId, user-emailAddress, group-groupId, group-emailAddress, allUsers, or allAuthenticatedUsers.</param>
        /// <param name="body">A valid Storage v1beta2 body.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>ObjectAccessControlResponse</returns>
        public static ObjectAccessControl Patch(StorageService service, string bucket, string object, string entity, ObjectAccessControl body, ObjectAccessControlsPatchOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (bucket == null)
                    throw new ArgumentNullException(bucket);
                if (object == null)
                    throw new ArgumentNullException(object);
                if (entity == null)
                    throw new ArgumentNullException(entity);

                // Building the initial request.
                var request = service.ObjectAccessControls.Patch(body, bucket, object, entity);

                // Applying optional parameters to the request.                
                request = (ObjectAccessControlsResource.PatchRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request ObjectAccessControls.Patch failed.", ex);
            }
        }
        public class ObjectAccessControlsUpdateOptionalParms
        {
            /// If present, selects a specific revision of this object (as opposed to the latest version, the default).
            public string Generation { get; set; }  
        
        }
 
        /// <summary>
        /// Updates an ACL entry on the specified object. 
        /// Documentation https://developers.google.com/storage/v1beta2/reference/objectAccessControls/update
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Storage service.</param>  
        /// <param name="bucket">Name of a bucket.</param>
        /// <param name="object">Name of the object.</param>
        /// <param name="entity">The entity holding the permission. Can be user-userId, user-emailAddress, group-groupId, group-emailAddress, allUsers, or allAuthenticatedUsers.</param>
        /// <param name="body">A valid Storage v1beta2 body.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>ObjectAccessControlResponse</returns>
        public static ObjectAccessControl Update(StorageService service, string bucket, string object, string entity, ObjectAccessControl body, ObjectAccessControlsUpdateOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (bucket == null)
                    throw new ArgumentNullException(bucket);
                if (object == null)
                    throw new ArgumentNullException(object);
                if (entity == null)
                    throw new ArgumentNullException(entity);

                // Building the initial request.
                var request = service.ObjectAccessControls.Update(body, bucket, object, entity);

                // Applying optional parameters to the request.                
                request = (ObjectAccessControlsResource.UpdateRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request ObjectAccessControls.Update failed.", ex);
            }
        }
        
        }

        public static class SampleHelpers
        {

        /// <summary>
        /// Using reflection to apply optional parameters to the request.  
        /// 
        /// If the optonal parameters are null then we will just return the request as is.
        /// </summary>
        /// <param name="request">The request. </param>
        /// <param name="optional">The optional parameters. </param>
        /// <returns></returns>
        public static object ApplyOptionalParms(object request, object optional)
        {
            if (optional == null)
                return request;

            System.Reflection.PropertyInfo[] optionalProperties = (optional.GetType()).GetProperties();

            foreach (System.Reflection.PropertyInfo property in optionalProperties)
            {
                // Copy value from optional parms to the request.  They should have the same names and datatypes.
                System.Reflection.PropertyInfo piShared = (request.GetType()).GetProperty(property.Name);
				if (property.GetValue(optional, null) != null) // TODO Test that we do not add values for items that are null
					piShared.SetValue(request, property.GetValue(optional, null), null);
            }

            return request;
        }
    }
}