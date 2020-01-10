﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: Generated/Native/Types/cef_resource_request_handler_t.cs
// --------------------------------------------------------------------------------------------﻿
// DO NOT MODIFY! THIS IS AUTOGENERATED FILE!
// --------------------------------------------------------------------------------------------

#pragma warning disable 0169

using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using CefNet.WinApi;
using CefNet.CApi;
using CefNet.Internal;

namespace CefNet
{
	/// <summary>
	/// Implement this structure to handle events related to browser requests. The
	/// functions of this structure will be called on the IO thread unless otherwise
	/// indicated.
	/// </summary>
	/// <remarks>
	/// Role: Handler
	/// </remarks>
	public unsafe partial class CefResourceRequestHandler : CefBaseRefCounted<cef_resource_request_handler_t>, ICefResourceRequestHandlerPrivate
	{
		private static readonly GetCookieAccessFilterDelegate fnGetCookieAccessFilter = GetCookieAccessFilterImpl;

		private static readonly OnBeforeResourceLoadDelegate fnOnBeforeResourceLoad = OnBeforeResourceLoadImpl;

		private static readonly GetResourceHandlerDelegate fnGetResourceHandler = GetResourceHandlerImpl;

		private static readonly OnResourceRedirectDelegate fnOnResourceRedirect = OnResourceRedirectImpl;

		private static readonly OnResourceResponseDelegate fnOnResourceResponse = OnResourceResponseImpl;

		private static readonly GetResourceResponseFilterDelegate fnGetResourceResponseFilter = GetResourceResponseFilterImpl;

		private static readonly OnResourceLoadCompleteDelegate fnOnResourceLoadComplete = OnResourceLoadCompleteImpl;

		private static readonly OnProtocolExecutionDelegate fnOnProtocolExecution = OnProtocolExecutionImpl;

		internal static unsafe CefResourceRequestHandler Create(IntPtr instance)
		{
			return new CefResourceRequestHandler((cef_resource_request_handler_t*)instance);
		}

		public CefResourceRequestHandler()
		{
			cef_resource_request_handler_t* self = this.NativeInstance;
			self->get_cookie_access_filter = (void*)Marshal.GetFunctionPointerForDelegate(fnGetCookieAccessFilter);
			self->on_before_resource_load = (void*)Marshal.GetFunctionPointerForDelegate(fnOnBeforeResourceLoad);
			self->get_resource_handler = (void*)Marshal.GetFunctionPointerForDelegate(fnGetResourceHandler);
			self->on_resource_redirect = (void*)Marshal.GetFunctionPointerForDelegate(fnOnResourceRedirect);
			self->on_resource_response = (void*)Marshal.GetFunctionPointerForDelegate(fnOnResourceResponse);
			self->get_resource_response_filter = (void*)Marshal.GetFunctionPointerForDelegate(fnGetResourceResponseFilter);
			self->on_resource_load_complete = (void*)Marshal.GetFunctionPointerForDelegate(fnOnResourceLoadComplete);
			self->on_protocol_execution = (void*)Marshal.GetFunctionPointerForDelegate(fnOnProtocolExecution);
		}

		public CefResourceRequestHandler(cef_resource_request_handler_t* instance)
			: base((cef_base_ref_counted_t*)instance)
		{
		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		extern bool ICefResourceRequestHandlerPrivate.AvoidGetCookieAccessFilter();

		/// <summary>
		/// Called on the IO thread before a resource request is loaded. The |browser|
		/// and |frame| values represent the source of the request, and may be NULL for
		/// requests originating from service workers or cef_urlrequest_t. To
		/// optionally filter cookies for the request return a
		/// cef_cookie_access_filter_t object. The |request| object cannot not be
		/// modified in this callback.
		/// </summary>
		public unsafe virtual CefCookieAccessFilter GetCookieAccessFilter(CefBrowser browser, CefFrame frame, CefRequest request)
		{
			return default;
		}

		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate cef_cookie_access_filter_t* GetCookieAccessFilterDelegate(cef_resource_request_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, cef_request_t* request);

		// _cef_cookie_access_filter_t* (*)(_cef_resource_request_handler_t* self, _cef_browser_t* browser, _cef_frame_t* frame, _cef_request_t* request)*
		private static unsafe cef_cookie_access_filter_t* GetCookieAccessFilterImpl(cef_resource_request_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, cef_request_t* request)
		{
			var instance = GetInstance((IntPtr)self) as CefResourceRequestHandler;
			if (instance == null || ((ICefResourceRequestHandlerPrivate)instance).AvoidGetCookieAccessFilter())
			{
				ReleaseIfNonNull((cef_base_ref_counted_t*)browser);
				ReleaseIfNonNull((cef_base_ref_counted_t*)frame);
				ReleaseIfNonNull((cef_base_ref_counted_t*)request);
				return default;
			}
			CefCookieAccessFilter rv = instance.GetCookieAccessFilter(CefBrowser.Wrap(CefBrowser.Create, browser), CefFrame.Wrap(CefFrame.Create, frame), CefRequest.Wrap(CefRequest.Create, request));
			if (rv == null)
				return null;
			return (rv != null) ? rv.GetNativeInstance() : null;
		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		extern bool ICefResourceRequestHandlerPrivate.AvoidOnBeforeResourceLoad();

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
		public unsafe virtual CefReturnValue OnBeforeResourceLoad(CefBrowser browser, CefFrame frame, CefRequest request, CefRequestCallback callback)
		{
			return default;
		}

		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate CefReturnValue OnBeforeResourceLoadDelegate(cef_resource_request_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, cef_request_t* request, cef_request_callback_t* callback);

		// cef_return_value_t (*)(_cef_resource_request_handler_t* self, _cef_browser_t* browser, _cef_frame_t* frame, _cef_request_t* request, _cef_request_callback_t* callback)*
		private static unsafe CefReturnValue OnBeforeResourceLoadImpl(cef_resource_request_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, cef_request_t* request, cef_request_callback_t* callback)
		{
			var instance = GetInstance((IntPtr)self) as CefResourceRequestHandler;
			if (instance == null || ((ICefResourceRequestHandlerPrivate)instance).AvoidOnBeforeResourceLoad())
			{
				ReleaseIfNonNull((cef_base_ref_counted_t*)browser);
				ReleaseIfNonNull((cef_base_ref_counted_t*)frame);
				ReleaseIfNonNull((cef_base_ref_counted_t*)request);
				ReleaseIfNonNull((cef_base_ref_counted_t*)callback);
				return default;
			}
			return instance.OnBeforeResourceLoad(CefBrowser.Wrap(CefBrowser.Create, browser), CefFrame.Wrap(CefFrame.Create, frame), CefRequest.Wrap(CefRequest.Create, request), CefRequestCallback.Wrap(CefRequestCallback.Create, callback));
		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		extern bool ICefResourceRequestHandlerPrivate.AvoidGetResourceHandler();

		/// <summary>
		/// Called on the IO thread before a resource is loaded. The |browser| and
		/// |frame| values represent the source of the request, and may be NULL for
		/// requests originating from service workers or cef_urlrequest_t. To allow the
		/// resource to load using the default network loader return NULL. To specify a
		/// handler for the resource return a cef_resource_handler_t object. The
		/// |request| object cannot not be modified in this callback.
		/// </summary>
		public unsafe virtual CefResourceHandler GetResourceHandler(CefBrowser browser, CefFrame frame, CefRequest request)
		{
			return default;
		}

		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate cef_resource_handler_t* GetResourceHandlerDelegate(cef_resource_request_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, cef_request_t* request);

		// _cef_resource_handler_t* (*)(_cef_resource_request_handler_t* self, _cef_browser_t* browser, _cef_frame_t* frame, _cef_request_t* request)*
		private static unsafe cef_resource_handler_t* GetResourceHandlerImpl(cef_resource_request_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, cef_request_t* request)
		{
			var instance = GetInstance((IntPtr)self) as CefResourceRequestHandler;
			if (instance == null || ((ICefResourceRequestHandlerPrivate)instance).AvoidGetResourceHandler())
			{
				ReleaseIfNonNull((cef_base_ref_counted_t*)browser);
				ReleaseIfNonNull((cef_base_ref_counted_t*)frame);
				ReleaseIfNonNull((cef_base_ref_counted_t*)request);
				return default;
			}
			CefResourceHandler rv = instance.GetResourceHandler(CefBrowser.Wrap(CefBrowser.Create, browser), CefFrame.Wrap(CefFrame.Create, frame), CefRequest.Wrap(CefRequest.Create, request));
			if (rv == null)
				return null;
			return (rv != null) ? rv.GetNativeInstance() : null;
		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		extern bool ICefResourceRequestHandlerPrivate.AvoidOnResourceRedirect();

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
		public unsafe virtual void OnResourceRedirect(CefBrowser browser, CefFrame frame, CefRequest request, CefResponse response, ref string newUrl)
		{
		}

		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate void OnResourceRedirectDelegate(cef_resource_request_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, cef_request_t* request, cef_response_t* response, cef_string_t* new_url);

		// void (*)(_cef_resource_request_handler_t* self, _cef_browser_t* browser, _cef_frame_t* frame, _cef_request_t* request, _cef_response_t* response, cef_string_t* new_url)*
		private static unsafe void OnResourceRedirectImpl(cef_resource_request_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, cef_request_t* request, cef_response_t* response, cef_string_t* new_url)
		{
			var instance = GetInstance((IntPtr)self) as CefResourceRequestHandler;
			if (instance == null || ((ICefResourceRequestHandlerPrivate)instance).AvoidOnResourceRedirect())
			{
				ReleaseIfNonNull((cef_base_ref_counted_t*)browser);
				ReleaseIfNonNull((cef_base_ref_counted_t*)frame);
				ReleaseIfNonNull((cef_base_ref_counted_t*)request);
				ReleaseIfNonNull((cef_base_ref_counted_t*)response);
				return;
			}
			string s_new_url = CefString.Read(new_url);
			string s_orig_new_url = s_new_url;
			instance.OnResourceRedirect(CefBrowser.Wrap(CefBrowser.Create, browser), CefFrame.Wrap(CefFrame.Create, frame), CefRequest.Wrap(CefRequest.Create, request), CefResponse.Wrap(CefResponse.Create, response), ref s_new_url);
		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		extern bool ICefResourceRequestHandlerPrivate.AvoidOnResourceResponse();

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
		public unsafe virtual bool OnResourceResponse(CefBrowser browser, CefFrame frame, CefRequest request, CefResponse response)
		{
			return default;
		}

		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate int OnResourceResponseDelegate(cef_resource_request_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, cef_request_t* request, cef_response_t* response);

		// int (*)(_cef_resource_request_handler_t* self, _cef_browser_t* browser, _cef_frame_t* frame, _cef_request_t* request, _cef_response_t* response)*
		private static unsafe int OnResourceResponseImpl(cef_resource_request_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, cef_request_t* request, cef_response_t* response)
		{
			var instance = GetInstance((IntPtr)self) as CefResourceRequestHandler;
			if (instance == null || ((ICefResourceRequestHandlerPrivate)instance).AvoidOnResourceResponse())
			{
				ReleaseIfNonNull((cef_base_ref_counted_t*)browser);
				ReleaseIfNonNull((cef_base_ref_counted_t*)frame);
				ReleaseIfNonNull((cef_base_ref_counted_t*)request);
				ReleaseIfNonNull((cef_base_ref_counted_t*)response);
				return default;
			}
			return instance.OnResourceResponse(CefBrowser.Wrap(CefBrowser.Create, browser), CefFrame.Wrap(CefFrame.Create, frame), CefRequest.Wrap(CefRequest.Create, request), CefResponse.Wrap(CefResponse.Create, response)) ? 1 : 0;
		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		extern bool ICefResourceRequestHandlerPrivate.AvoidGetResourceResponseFilter();

		/// <summary>
		/// Called on the IO thread to optionally filter resource response content. The
		/// |browser| and |frame| values represent the source of the request, and may
		/// be NULL for requests originating from service workers or cef_urlrequest_t.
		/// |request| and |response| represent the request and response respectively
		/// and cannot be modified in this callback.
		/// </summary>
		public unsafe virtual CefResponseFilter GetResourceResponseFilter(CefBrowser browser, CefFrame frame, CefRequest request, CefResponse response)
		{
			return default;
		}

		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate cef_response_filter_t* GetResourceResponseFilterDelegate(cef_resource_request_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, cef_request_t* request, cef_response_t* response);

		// _cef_response_filter_t* (*)(_cef_resource_request_handler_t* self, _cef_browser_t* browser, _cef_frame_t* frame, _cef_request_t* request, _cef_response_t* response)*
		private static unsafe cef_response_filter_t* GetResourceResponseFilterImpl(cef_resource_request_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, cef_request_t* request, cef_response_t* response)
		{
			var instance = GetInstance((IntPtr)self) as CefResourceRequestHandler;
			if (instance == null || ((ICefResourceRequestHandlerPrivate)instance).AvoidGetResourceResponseFilter())
			{
				ReleaseIfNonNull((cef_base_ref_counted_t*)browser);
				ReleaseIfNonNull((cef_base_ref_counted_t*)frame);
				ReleaseIfNonNull((cef_base_ref_counted_t*)request);
				ReleaseIfNonNull((cef_base_ref_counted_t*)response);
				return default;
			}
			CefResponseFilter rv = instance.GetResourceResponseFilter(CefBrowser.Wrap(CefBrowser.Create, browser), CefFrame.Wrap(CefFrame.Create, frame), CefRequest.Wrap(CefRequest.Create, request), CefResponse.Wrap(CefResponse.Create, response));
			if (rv == null)
				return null;
			return (rv != null) ? rv.GetNativeInstance() : null;
		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		extern bool ICefResourceRequestHandlerPrivate.AvoidOnResourceLoadComplete();

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
		public unsafe virtual void OnResourceLoadComplete(CefBrowser browser, CefFrame frame, CefRequest request, CefResponse response, CefUrlRequestStatus status, long receivedContentLength)
		{
		}

		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate void OnResourceLoadCompleteDelegate(cef_resource_request_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, cef_request_t* request, cef_response_t* response, CefUrlRequestStatus status, long received_content_length);

		// void (*)(_cef_resource_request_handler_t* self, _cef_browser_t* browser, _cef_frame_t* frame, _cef_request_t* request, _cef_response_t* response, cef_urlrequest_status_t status, int64 received_content_length)*
		private static unsafe void OnResourceLoadCompleteImpl(cef_resource_request_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, cef_request_t* request, cef_response_t* response, CefUrlRequestStatus status, long received_content_length)
		{
			var instance = GetInstance((IntPtr)self) as CefResourceRequestHandler;
			if (instance == null || ((ICefResourceRequestHandlerPrivate)instance).AvoidOnResourceLoadComplete())
			{
				ReleaseIfNonNull((cef_base_ref_counted_t*)browser);
				ReleaseIfNonNull((cef_base_ref_counted_t*)frame);
				ReleaseIfNonNull((cef_base_ref_counted_t*)request);
				ReleaseIfNonNull((cef_base_ref_counted_t*)response);
				return;
			}
			instance.OnResourceLoadComplete(CefBrowser.Wrap(CefBrowser.Create, browser), CefFrame.Wrap(CefFrame.Create, frame), CefRequest.Wrap(CefRequest.Create, request), CefResponse.Wrap(CefResponse.Create, response), status, received_content_length);
		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		extern bool ICefResourceRequestHandlerPrivate.AvoidOnProtocolExecution();

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
		public unsafe virtual void OnProtocolExecution(CefBrowser browser, CefFrame frame, CefRequest request, ref int allowOsExecution)
		{
		}

		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate void OnProtocolExecutionDelegate(cef_resource_request_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, cef_request_t* request, int* allow_os_execution);

		// void (*)(_cef_resource_request_handler_t* self, _cef_browser_t* browser, _cef_frame_t* frame, _cef_request_t* request, int* allow_os_execution)*
		private static unsafe void OnProtocolExecutionImpl(cef_resource_request_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, cef_request_t* request, int* allow_os_execution)
		{
			var instance = GetInstance((IntPtr)self) as CefResourceRequestHandler;
			if (instance == null || ((ICefResourceRequestHandlerPrivate)instance).AvoidOnProtocolExecution())
			{
				ReleaseIfNonNull((cef_base_ref_counted_t*)browser);
				ReleaseIfNonNull((cef_base_ref_counted_t*)frame);
				ReleaseIfNonNull((cef_base_ref_counted_t*)request);
				return;
			}
			instance.OnProtocolExecution(CefBrowser.Wrap(CefBrowser.Create, browser), CefFrame.Wrap(CefFrame.Create, frame), CefRequest.Wrap(CefRequest.Create, request), ref *allow_os_execution);
		}
	}
}
