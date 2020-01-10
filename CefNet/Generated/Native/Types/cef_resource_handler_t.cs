﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: include/capi/cef_resource_handler_capi.h
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
	/// Structure used to implement a custom request handler structure. The functions
	/// of this structure will be called on the IO thread unless otherwise indicated.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct cef_resource_handler_t
	{
		/// <summary>
		/// Base structure.
		/// </summary>
		public cef_base_ref_counted_t @base;

		/// <summary>
		/// int (*)(_cef_resource_handler_t* self, _cef_request_t* request, int* handle_request, _cef_callback_t* callback)*
		/// </summary>
		public void* open;

		/// <summary>
		/// Open the response stream. To handle the request immediately set
		/// |handle_request| to true (1) and return true (1). To decide at a later time
		/// set |handle_request| to false (0), return true (1), and execute |callback|
		/// to continue or cancel the request. To cancel the request immediately set
		/// |handle_request| to true (1) and return false (0). This function will be
		/// called in sequence but not from a dedicated thread. For backwards
		/// compatibility set |handle_request| to false (0) and return false (0) and
		/// the ProcessRequest function will be called.
		/// </summary>
		[NativeName("open")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern int Open(cef_request_t* request, int* handle_request, cef_callback_t* callback);

		/// <summary>
		/// int (*)(_cef_resource_handler_t* self, _cef_request_t* request, _cef_callback_t* callback)*
		/// </summary>
		public void* process_request;

		/// <summary>
		/// Begin processing the request. To handle the request return true (1) and
		/// call cef_callback_t::cont() once the response header information is
		/// available (cef_callback_t::cont() can also be called from inside this
		/// function if header information is available immediately). To cancel the
		/// request return false (0).
		/// WARNING: This function is deprecated. Use Open instead.
		/// </summary>
		[NativeName("process_request")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern int ProcessRequest(cef_request_t* request, cef_callback_t* callback);

		/// <summary>
		/// void (*)(_cef_resource_handler_t* self, _cef_response_t* response, int64* response_length, cef_string_t* redirectUrl)*
		/// </summary>
		public void* get_response_headers;

		/// <summary>
		/// Retrieve response header information. If the response length is not known
		/// set |response_length| to -1 and read_response() will be called until it
		/// returns false (0). If the response length is known set |response_length| to
		/// a positive value and read_response() will be called until it returns false
		/// (0) or the specified number of bytes have been read. Use the |response|
		/// object to set the mime type, http status code and other optional header
		/// values. To redirect the request to a new URL set |redirectUrl| to the new
		/// URL. |redirectUrl| can be either a relative or fully qualified URL. It is
		/// also possible to set |response| to a redirect http status code and pass the
		/// new URL via a Location header. Likewise with |redirectUrl| it is valid to
		/// set a relative or fully qualified URL as the Location header value. If an
		/// error occured while setting up the request you can call set_error() on
		/// |response| to indicate the error condition.
		/// </summary>
		[NativeName("get_response_headers")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern void GetResponseHeaders(cef_response_t* response, long* response_length, cef_string_t* redirectUrl);

		/// <summary>
		/// int (*)(_cef_resource_handler_t* self, int64 bytes_to_skip, int64* bytes_skipped, _cef_resource_skip_callback_t* callback)*
		/// </summary>
		public void* skip;

		/// <summary>
		/// Skip response data when requested by a Range header. Skip over and discard
		/// |bytes_to_skip| bytes of response data. If data is available immediately
		/// set |bytes_skipped| to the number of bytes skipped and return true (1). To
		/// read the data at a later time set |bytes_skipped| to 0, return true (1) and
		/// execute |callback| when the data is available. To indicate failure set
		/// |bytes_skipped| to 
		/// &lt;
		/// 0 (e.g. -2 for ERR_FAILED) and return false (0). This
		/// function will be called in sequence but not from a dedicated thread.
		/// </summary>
		[NativeName("skip")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern int Skip(long bytes_to_skip, long* bytes_skipped, cef_resource_skip_callback_t* callback);

		/// <summary>
		/// int (*)(_cef_resource_handler_t* self, void* data_out, int bytes_to_read, int* bytes_read, _cef_resource_read_callback_t* callback)*
		/// </summary>
		public void* read;

		/// <summary>
		/// Read response data. If data is available immediately copy up to
		/// |bytes_to_read| bytes into |data_out|, set |bytes_read| to the number of
		/// bytes copied, and return true (1). To read the data at a later time keep a
		/// pointer to |data_out|, set |bytes_read| to 0, return true (1) and execute
		/// |callback| when the data is available (|data_out| will remain valid until
		/// the callback is executed). To indicate response completion set |bytes_read|
		/// to 0 and return false (0). To indicate failure set |bytes_read| to 
		/// &lt;
		/// 0
		/// (e.g. -2 for ERR_FAILED) and return false (0). This function will be called
		/// in sequence but not from a dedicated thread. For backwards compatibility
		/// set |bytes_read| to -1 and return false (0) and the ReadResponse function
		/// will be called.
		/// </summary>
		[NativeName("read")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern int Read(void* data_out, int bytes_to_read, int* bytes_read, cef_resource_read_callback_t* callback);

		/// <summary>
		/// int (*)(_cef_resource_handler_t* self, void* data_out, int bytes_to_read, int* bytes_read, _cef_callback_t* callback)*
		/// </summary>
		public void* read_response;

		/// <summary>
		/// Read response data. If data is available immediately copy up to
		/// |bytes_to_read| bytes into |data_out|, set |bytes_read| to the number of
		/// bytes copied, and return true (1). To read the data at a later time set
		/// |bytes_read| to 0, return true (1) and call cef_callback_t::cont() when the
		/// data is available. To indicate response completion return false (0).
		/// WARNING: This function is deprecated. Use Skip and Read instead.
		/// </summary>
		[NativeName("read_response")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern int ReadResponse(void* data_out, int bytes_to_read, int* bytes_read, cef_callback_t* callback);

		/// <summary>
		/// void (*)(_cef_resource_handler_t* self)*
		/// </summary>
		public void* cancel;

		/// <summary>
		/// Request processing has been canceled.
		/// </summary>
		[NativeName("cancel")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern void Cancel();
	}
}

