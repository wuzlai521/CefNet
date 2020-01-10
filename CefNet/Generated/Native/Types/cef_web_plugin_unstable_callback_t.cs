﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: include/capi/cef_web_plugin_capi.h
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
	/// Structure to implement for receiving unstable plugin information. The
	/// functions of this structure will be called on the browser process IO thread.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct cef_web_plugin_unstable_callback_t
	{
		/// <summary>
		/// Base structure.
		/// </summary>
		public cef_base_ref_counted_t @base;

		/// <summary>
		/// void (*)(_cef_web_plugin_unstable_callback_t* self, const cef_string_t* path, int unstable)*
		/// </summary>
		public void* is_unstable;

		/// <summary>
		/// Method that will be called for the requested plugin. |unstable| will be
		/// true (1) if the plugin has reached the crash count threshold of 3 times in
		/// 120 seconds.
		/// </summary>
		[NativeName("is_unstable")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern void IsUnstable([Immutable]cef_string_t* path, int unstable);
	}
}

