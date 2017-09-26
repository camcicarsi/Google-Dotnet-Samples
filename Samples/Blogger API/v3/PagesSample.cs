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
//     Build date: 2017-09-26
//     C# generater version: 1.0.0
//     
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------  
// About 
// 
// Unoffical sample for the Blogger v3 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: API for access to the data within Blogger.
// API Documentation Link https://developers.google.com/blogger/docs/3.0/getting_started
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Blogger/v3/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Blogger.v3/ 
// Install Command: PM>  Install-Package Google.Apis.Blogger.v3
//
//------------------------------------------------------------------------------  
using Google.Apis.Blogger.v3;
using Google.Apis.Blogger.v3.Data;
using System;

namespace GoogleSamplecSharpSample.Bloggerv3.Methods
{
  
    public static class PagesSample
    {


        /// <summary>
        /// Delete a page by ID. 
        /// Documentation https://developers.google.com/blogger/v3/reference/pages/delete
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Blogger service.</param>  
        /// <param name="blogId">The ID of the Blog.</param>
        /// <param name="pageId">The ID of the Page.</param>
        public static void Delete(BloggerService service, string blogId, string pageId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (blogId == null)
                    throw new ArgumentNullException(blogId);
                if (pageId == null)
                    throw new ArgumentNullException(pageId);

                // Make the request.
                 service.Pages.Delete(blogId, pageId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Pages.Delete failed.", ex);
            }
        }
        public class PagesGetOptionalParms
        {
            /// NA
            public string View { get; set; }  
        
        }
 
        /// <summary>
        /// Gets one blog page by ID. 
        /// Documentation https://developers.google.com/blogger/v3/reference/pages/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Blogger service.</param>  
        /// <param name="blogId">ID of the blog containing the page.</param>
        /// <param name="pageId">The ID of the page to get.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>PageResponse</returns>
        public static Page Get(BloggerService service, string blogId, string pageId, PagesGetOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (blogId == null)
                    throw new ArgumentNullException(blogId);
                if (pageId == null)
                    throw new ArgumentNullException(pageId);

                // Building the initial request.
                var request = service.Pages.Get(blogId, pageId);

                // Applying optional parameters to the request.                
                request = (PagesResource.GetRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Pages.Get failed.", ex);
            }
        }
        public class PagesInsertOptionalParms
        {
            /// Whether to create the page as a draft (default: false).
            public bool? IsDraft { get; set; }  
        
        }
 
        /// <summary>
        /// Add a page. 
        /// Documentation https://developers.google.com/blogger/v3/reference/pages/insert
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Blogger service.</param>  
        /// <param name="blogId">ID of the blog to add the page to.</param>
        /// <param name="body">A valid Blogger v3 body.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>PageResponse</returns>
        public static Page Insert(BloggerService service, string blogId, Page body, PagesInsertOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (blogId == null)
                    throw new ArgumentNullException(blogId);

                // Building the initial request.
                var request = service.Pages.Insert(body, blogId);

                // Applying optional parameters to the request.                
                request = (PagesResource.InsertRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Pages.Insert failed.", ex);
            }
        }
        public class PagesListOptionalParms
        {
            /// Whether to retrieve the Page bodies.
            public bool? FetchBodies { get; set; }  
            /// Maximum number of Pages to fetch.
            public int? MaxResults { get; set; }  
            /// Continuation token if the request is paged.
            public string PageToken { get; set; }  
            /// NA
            public string Status { get; set; }  
            /// Access level with which to view the returned result. Note that some fields require elevated access.
            public string View { get; set; }  
        
        }
 
        /// <summary>
        /// Retrieves the pages for a blog, optionally including non-LIVE statuses. 
        /// Documentation https://developers.google.com/blogger/v3/reference/pages/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Blogger service.</param>  
        /// <param name="blogId">ID of the blog to fetch Pages from.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>PageListResponse</returns>
        public static PageList List(BloggerService service, string blogId, PagesListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (blogId == null)
                    throw new ArgumentNullException(blogId);

                // Building the initial request.
                var request = service.Pages.List(blogId);

                // Applying optional parameters to the request.                
                request = (PagesResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Pages.List failed.", ex);
            }
        }
        public class PagesPatchOptionalParms
        {
            /// Whether a publish action should be performed when the page is updated (default: false).
            public bool? Publish { get; set; }  
            /// Whether a revert action should be performed when the page is updated (default: false).
            public bool? Revert { get; set; }  
        
        }
 
        /// <summary>
        /// Update a page. This method supports patch semantics. 
        /// Documentation https://developers.google.com/blogger/v3/reference/pages/patch
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Blogger service.</param>  
        /// <param name="blogId">The ID of the Blog.</param>
        /// <param name="pageId">The ID of the Page.</param>
        /// <param name="body">A valid Blogger v3 body.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>PageResponse</returns>
        public static Page Patch(BloggerService service, string blogId, string pageId, Page body, PagesPatchOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (blogId == null)
                    throw new ArgumentNullException(blogId);
                if (pageId == null)
                    throw new ArgumentNullException(pageId);

                // Building the initial request.
                var request = service.Pages.Patch(body, blogId, pageId);

                // Applying optional parameters to the request.                
                request = (PagesResource.PatchRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Pages.Patch failed.", ex);
            }
        }

        /// <summary>
        /// Publishes a draft page. 
        /// Documentation https://developers.google.com/blogger/v3/reference/pages/publish
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Blogger service.</param>  
        /// <param name="blogId">The ID of the blog.</param>
        /// <param name="pageId">The ID of the page.</param>
        /// <returns>PageResponse</returns>
        public static Page Publish(BloggerService service, string blogId, string pageId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (blogId == null)
                    throw new ArgumentNullException(blogId);
                if (pageId == null)
                    throw new ArgumentNullException(pageId);

                // Make the request.
                return service.Pages.Publish(blogId, pageId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Pages.Publish failed.", ex);
            }
        }

        /// <summary>
        /// Revert a published or scheduled page to draft state. 
        /// Documentation https://developers.google.com/blogger/v3/reference/pages/revert
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Blogger service.</param>  
        /// <param name="blogId">The ID of the blog.</param>
        /// <param name="pageId">The ID of the page.</param>
        /// <returns>PageResponse</returns>
        public static Page Revert(BloggerService service, string blogId, string pageId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (blogId == null)
                    throw new ArgumentNullException(blogId);
                if (pageId == null)
                    throw new ArgumentNullException(pageId);

                // Make the request.
                return service.Pages.Revert(blogId, pageId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Pages.Revert failed.", ex);
            }
        }
        public class PagesUpdateOptionalParms
        {
            /// Whether a publish action should be performed when the page is updated (default: false).
            public bool? Publish { get; set; }  
            /// Whether a revert action should be performed when the page is updated (default: false).
            public bool? Revert { get; set; }  
        
        }
 
        /// <summary>
        /// Update a page. 
        /// Documentation https://developers.google.com/blogger/v3/reference/pages/update
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Blogger service.</param>  
        /// <param name="blogId">The ID of the Blog.</param>
        /// <param name="pageId">The ID of the Page.</param>
        /// <param name="body">A valid Blogger v3 body.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>PageResponse</returns>
        public static Page Update(BloggerService service, string blogId, string pageId, Page body, PagesUpdateOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (blogId == null)
                    throw new ArgumentNullException(blogId);
                if (pageId == null)
                    throw new ArgumentNullException(pageId);

                // Building the initial request.
                var request = service.Pages.Update(body, blogId, pageId);

                // Applying optional parameters to the request.                
                request = (PagesResource.UpdateRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Pages.Update failed.", ex);
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