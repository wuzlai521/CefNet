﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: Generated/Native/Types/cef_resolve_callback_t.cs
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
	/// Callback structure for cef_request_tContext::ResolveHost.
	/// </summary>
	/// <remarks>
	/// Role: Proxy
	/// </remarks>
	public unsafe partial class CefResolveCallback : CefBaseRefCounted<cef_resolve_callback_t>
	{
		internal static unsafe CefResolveCallback Create(IntPtr instance)
		{
			return new CefResolveCallback((cef_resolve_callback_t*)instance);
		}

		public CefResolveCallback(cef_resolve_callback_t* instance)
			: base((cef_base_ref_counted_t*)instance)
		{
		}

		/// <summary>
		/// Called on the UI thread after the ResolveHost request has completed.
		/// |result| will be the result code. |resolved_ips| will be the list of
		/// resolved IP addresses or NULL if the resolution failed.
		/// </summary>
		public unsafe virtual void OnResolveCompleted(CefErrorCode result, CefStringList resolvedIps)
		{
			NativeInstance->OnResolveCompleted(result, resolvedIps.GetNativeInstance());
		}
	}
}
