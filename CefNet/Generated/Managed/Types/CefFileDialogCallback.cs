﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: Generated/Native/Types/cef_file_dialog_callback_t.cs
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
	/// Callback structure for asynchronous continuation of file dialog requests.
	/// </summary>
	/// <remarks>
	/// Role: Proxy
	/// </remarks>
	public unsafe partial class CefFileDialogCallback : CefBaseRefCounted<cef_file_dialog_callback_t>
	{
		internal static unsafe CefFileDialogCallback Create(IntPtr instance)
		{
			return new CefFileDialogCallback((cef_file_dialog_callback_t*)instance);
		}

		public CefFileDialogCallback(cef_file_dialog_callback_t* instance)
			: base((cef_base_ref_counted_t*)instance)
		{
		}

		/// <summary>
		/// Continue the file selection. |selected_accept_filter| should be the 0-based
		/// index of the value selected from the accept filters array passed to
		/// cef_dialog_handler_t::OnFileDialog. |file_paths| should be a single value
		/// or a list of values depending on the dialog mode. An NULL |file_paths|
		/// value is treated the same as calling cancel().
		/// </summary>
		public unsafe virtual void Continue(bool selectedAcceptFilter, CefStringList filePaths)
		{
			NativeInstance->Continue(selectedAcceptFilter ? 1 : 0, filePaths.GetNativeInstance());
		}

		/// <summary>
		/// Cancel the file selection.
		/// </summary>
		public unsafe virtual void Cancel()
		{
			NativeInstance->Cancel();
		}
	}
}
