﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: include/capi/cef_resource_request_handler_capi.h
// --------------------------------------------------------------------------------------------﻿
// DO NOT MODIFY! THIS IS AUTOGENERATED FILE!
// --------------------------------------------------------------------------------------------

#pragma warning disable 0169

using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using CefNet.WinApi;

namespace CefNet.CApi
{
	/// <summary>
	/// Implement this structure to handle events related to browser requests. The
	/// functions of this structure will be called on the IO thread unless otherwise
	/// indicated.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct cef_resource_request_handler_t
	{
		/// <summary>
		/// Base structure.
		/// </summary>
		public cef_base_ref_counted_t @base;

		/// <summary>
		/// _cef_cookie_access_filter_t* (*)(_cef_resource_request_handler_t* self, _cef_browser_t* browser, _cef_frame_t* frame, _cef_request_t* request)*
		/// </summary>
		public void* get_cookie_access_filter;

		/// <summary>
		/// Called on the IO thread before a resource request is loaded. The |browser|
		/// and |frame| values represent the source of the request, and may be NULL for
		/// requests originating from service workers or cef_urlrequest_t. To
		/// optionally filter cookies for the request return a
		/// cef_cookie_access_filter_t object. The |request| object cannot not be
		/// modified in this callback.
		/// </summary>
		[NativeName("get_cookie_access_filter")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern cef_cookie_access_filter_t* GetCookieAccessFilter(cef_browser_t* browser, cef_frame_t* frame, cef_request_t* request);

		/// <summary>
		/// cef_return_value_t (*)(_cef_resource_request_handler_t* self, _cef_browser_t* browser, _cef_frame_t* frame, _cef_request_t* request, _cef_request_callback_t* callback)*
		/// </summary>
		public void* on_before_resource_load;

		/// <summary>
		/// Called on the IO thread before a resource request is loaded. The |browser|
		/// and |frame| values represent the source of the request, and may be NULL for
		/// requests originating from service workers or cef_urlrequest_t. To redirect
		/// or change the resource load optionally modify |request|. Modification of
		/// the request URL will be treated as a redirect. Return RV_CONTINUE to
		/// continue the request immediately. Return RV_CONTINUE_ASYNC and call
		/// cef_request_tCallback:: cont() at a later time to continue or cancel the
		/// request asynchronously. Return RV_CANCEL to cancel the request immediately.
		/// </summary>
		[NativeName("on_before_resource_load")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern CefReturnValue OnBeforeResourceLoad(cef_browser_t* browser, cef_frame_t* frame, cef_request_t* request, cef_request_callback_t* callback);

		/// <summary>
		/// _cef_resource_handler_t* (*)(_cef_resource_request_handler_t* self, _cef_browser_t* browser, _cef_frame_t* frame, _cef_request_t* request)*
		/// </summary>
		public void* get_resource_handler;

		/// <summary>
		/// Called on the IO thread before a resource is loaded. The |browser| and
		/// |frame| values represent the source of the request, and may be NULL for
		/// requests originating from service workers or cef_urlrequest_t. To allow the
		/// resource to load using the default network loader return NULL. To specify a
		/// handler for the resource return a cef_resource_handler_t object. The
		/// |request| object cannot not be modified in this callback.
		/// </summary>
		[NativeName("get_resource_handler")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern cef_resource_handler_t* GetResourceHandler(cef_browser_t* browser, cef_frame_t* frame, cef_request_t* request);

		/// <summary>
		/// void (*)(_cef_resource_request_handler_t* self, _cef_browser_t* browser, _cef_frame_t* frame, _cef_request_t* request, _cef_response_t* response, cef_string_t* new_url)*
		/// </summary>
		public void* on_resource_redirect;

		/// <summary>
		/// Called on the IO thread when a resource load is redirected. The |browser|
		/// and |frame| values represent the source of the request, and may be NULL for
		/// requests originating from service workers or cef_urlrequest_t. The
		/// |request| parameter will contain the old URL and other request-related
		/// information. The |response| parameter will contain the response that
		/// resulted in the redirect. The |new_url| parameter will contain the new URL
		/// and can be changed if desired. The |request| and |response| objects cannot
		/// be modified in this callback.
		/// </summary>
		[NativeName("on_resource_redirect")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern void OnResourceRedirect(cef_browser_t* browser, cef_frame_t* frame, cef_request_t* request, cef_response_t* response, cef_string_t* new_url);

		/// <summary>
		/// int (*)(_cef_resource_request_handler_t* self, _cef_browser_t* browser, _cef_frame_t* frame, _cef_request_t* request, _cef_response_t* response)*
		/// </summary>
		public void* on_resource_response;

		/// <summary>
		/// Called on the IO thread when a resource response is received. The |browser|
		/// and |frame| values represent the source of the request, and may be NULL for
		/// requests originating from service workers or cef_urlrequest_t. To allow the
		/// resource load to proceed without modification return false (0). To redirect
		/// or retry the resource load optionally modify |request| and return true (1).
		/// Modification of the request URL will be treated as a redirect. Requests
		/// handled using the default network loader cannot be redirected in this
		/// callback. The |response| object cannot be modified in this callback.
		/// WARNING: Redirecting using this function is deprecated. Use
		/// OnBeforeResourceLoad or GetResourceHandler to perform redirects.
		/// </summary>
		[NativeName("on_resource_response")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern int OnResourceResponse(cef_browser_t* browser, cef_frame_t* frame, cef_request_t* request, cef_response_t* response);

		/// <summary>
		/// _cef_response_filter_t* (*)(_cef_resource_request_handler_t* self, _cef_browser_t* browser, _cef_frame_t* frame, _cef_request_t* request, _cef_response_t* response)*
		/// </summary>
		public void* get_resource_response_filter;

		/// <summary>
		/// Called on the IO thread to optionally filter resource response content. The
		/// |browser| and |frame| values represent the source of the request, and may
		/// be NULL for requests originating from service workers or cef_urlrequest_t.
		/// |request| and |response| represent the request and response respectively
		/// and cannot be modified in this callback.
		/// </summary>
		[MethodImpl(MethodImplOptions.ForwardRef)]
		[NativeName("get_resource_response_filter")]
		public unsafe extern cef_response_filter_t* GetResourceResponseFilter(cef_browser_t* browser, cef_frame_t* frame, cef_request_t* request, cef_response_t* response);

		/// <summary>
		/// void (*)(_cef_resource_request_handler_t* self, _cef_browser_t* browser, _cef_frame_t* frame, _cef_request_t* request, _cef_response_t* response, cef_urlrequest_status_t status, int64 received_content_length)*
		/// </summary>
		public void* on_resource_load_complete;

		/// <summary>
		/// Called on the IO thread when a resource load has completed. The |browser|
		/// and |frame| values represent the source of the request, and may be NULL for
		/// requests originating from service workers or cef_urlrequest_t. |request|
		/// and |response| represent the request and response respectively and cannot
		/// be modified in this callback. |status| indicates the load completion
		/// status. |received_content_length| is the number of response bytes actually
		/// read. This function will be called for all requests, including requests
		/// that are aborted due to CEF shutdown or destruction of the associated
		/// browser. In cases where the associated browser is destroyed this callback
		/// may arrive after the cef_life_span_handler_t::OnBeforeClose callback for
		/// that browser. The cef_frame_t::IsValid function can be used to test for
		/// this situation, and care should be taken not to call |browser| or |frame|
		/// functions that modify state (like LoadURL, SendProcessMessage, etc.) if the
		/// frame is invalid.
		/// </summary>
		[NativeName("on_resource_load_complete")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern void OnResourceLoadComplete(cef_browser_t* browser, cef_frame_t* frame, cef_request_t* request, cef_response_t* response, CefUrlRequestStatus status, long received_content_length);

		/// <summary>
		/// void (*)(_cef_resource_request_handler_t* self, _cef_browser_t* browser, _cef_frame_t* frame, _cef_request_t* request, int* allow_os_execution)*
		/// </summary>
		public void* on_protocol_execution;

		/// <summary>
		/// Called on the IO thread to handle requests for URLs with an unknown
		/// protocol component. The |browser| and |frame| values represent the source
		/// of the request, and may be NULL for requests originating from service
		/// workers or cef_urlrequest_t. |request| cannot be modified in this callback.
		/// Set |allow_os_execution| to true (1) to attempt execution via the
		/// registered OS protocol handler, if any. SECURITY WARNING: YOU SHOULD USE
		/// THIS METHOD TO ENFORCE RESTRICTIONS BASED ON SCHEME, HOST OR OTHER URL
		/// ANALYSIS BEFORE ALLOWING OS EXECUTION.
		/// </summary>
		[NativeName("on_protocol_execution")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern void OnProtocolExecution(cef_browser_t* browser, cef_frame_t* frame, cef_request_t* request, int* allow_os_execution);
	}
}

