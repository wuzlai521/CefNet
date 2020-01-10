﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: Generated/Native/Types/cef_select_client_certificate_callback_t.cs
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
	/// Callback structure used to select a client certificate for authentication.
	/// </summary>
	/// <remarks>
	/// Role: Proxy
	/// </remarks>
	public unsafe partial class CefSelectClientCertificateCallback : CefBaseRefCounted<cef_select_client_certificate_callback_t>
	{
		internal static unsafe CefSelectClientCertificateCallback Create(IntPtr instance)
		{
			return new CefSelectClientCertificateCallback((cef_select_client_certificate_callback_t*)instance);
		}

		public CefSelectClientCertificateCallback(cef_select_client_certificate_callback_t* instance)
			: base((cef_base_ref_counted_t*)instance)
		{
		}

		/// <summary>
		/// Chooses the specified certificate for client certificate authentication.
		/// NULL value means that no client certificate should be used.
		/// </summary>
		public unsafe virtual void Select(CefX509Certificate cert)
		{
			NativeInstance->Select((cert != null) ? cert.GetNativeInstance() : null);
		}
	}
}
