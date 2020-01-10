﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: include/capi/cef_extension_handler_capi.h
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
	/// Callback structure used for asynchronous continuation of
	/// cef_extension_tHandler::GetExtensionResource.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct cef_get_extension_resource_callback_t
	{
		/// <summary>
		/// Base structure.
		/// </summary>
		public cef_base_ref_counted_t @base;

		/// <summary>
		/// void (*)(_cef_get_extension_resource_callback_t* self, _cef_stream_reader_t* stream)*
		/// </summary>
		public void* cont;

		/// <summary>
		/// Continue the request. Read the resource contents from |stream|.
		/// </summary>
		[NativeName("cont")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern void Continue(cef_stream_reader_t* stream);

		/// <summary>
		/// void (*)(_cef_get_extension_resource_callback_t* self)*
		/// </summary>
		public void* cancel;

		/// <summary>
		/// Cancel the request.
		/// </summary>
		[NativeName("cancel")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern void Cancel();
	}
}

