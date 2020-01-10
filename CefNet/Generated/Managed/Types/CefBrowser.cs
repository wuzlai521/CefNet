﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: Generated/Native/Types/cef_browser_t.cs
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
	/// Structure used to represent a browser window. When used in the browser
	/// process the functions of this structure may be called on any thread unless
	/// otherwise indicated in the comments. When used in the render process the
	/// functions of this structure may only be called on the main thread.
	/// </summary>
	/// <remarks>
	/// Role: Proxy
	/// </remarks>
	public unsafe partial class CefBrowser : CefBaseRefCounted<cef_browser_t>
	{
		internal static unsafe CefBrowser Create(IntPtr instance)
		{
			return new CefBrowser((cef_browser_t*)instance);
		}

		public CefBrowser(cef_browser_t* instance)
			: base((cef_base_ref_counted_t*)instance)
		{
		}

		/// <summary>
		/// Gets the browser host object. This property can only be called in the
		/// browser process.
		/// </summary>
		public unsafe virtual CefBrowserHost Host
		{
			get
			{
				return CefBrowserHost.Wrap(CefBrowserHost.Create, NativeInstance->GetHost());
			}
		}

		/// <summary>
		/// Gets a value indicating whether the browser can navigate backwards.
		/// </summary>
		public unsafe virtual bool CanGoBack
		{
			get
			{
				return NativeInstance->CanGoBack() != 0;
			}
		}

		/// <summary>
		/// Gets a value indicating whether the browser can navigate forwards.
		/// </summary>
		public unsafe virtual bool CanGoForward
		{
			get
			{
				return NativeInstance->CanGoForward() != 0;
			}
		}

		/// <summary>
		/// Gets a value indicating whether the browser is currently loading.
		/// </summary>
		public unsafe virtual bool IsLoading
		{
			get
			{
				return NativeInstance->IsLoading() != 0;
			}
		}

		/// <summary>
		/// Gets the globally unique identifier for this browser. This value is also
		/// used as the tabId for extension APIs.
		/// </summary>
		public unsafe virtual int Identifier
		{
			get
			{
				return NativeInstance->GetIdentifier();
			}
		}

		/// <summary>
		/// Gets a value indicating whether the window is a popup window.
		/// </summary>
		public unsafe virtual bool IsPopup
		{
			get
			{
				return NativeInstance->IsPopup() != 0;
			}
		}

		/// <summary>
		/// Gets a value indicating whether a document has been loaded in the browser.
		/// </summary>
		public unsafe virtual bool HasDocument
		{
			get
			{
				return NativeInstance->HasDocument() != 0;
			}
		}

		/// <summary>
		/// Gets the main (top-level) frame for the browser window.
		/// </summary>
		public unsafe virtual CefFrame MainFrame
		{
			get
			{
				return CefFrame.Wrap(CefFrame.Create, NativeInstance->GetMainFrame());
			}
		}

		/// <summary>
		/// Gets the focused frame for the browser window.
		/// </summary>
		public unsafe virtual CefFrame FocusedFrame
		{
			get
			{
				return CefFrame.Wrap(CefFrame.Create, NativeInstance->GetFocusedFrame());
			}
		}

		/// <summary>
		/// Gets the number of frames that currently exist.
		/// </summary>
		public unsafe virtual long FrameCount
		{
			get
			{
				return (long)NativeInstance->GetFrameCount();
			}
		}

		/// <summary>
		/// Navigate backwards.
		/// </summary>
		public unsafe virtual void GoBack()
		{
			NativeInstance->GoBack();
		}

		/// <summary>
		/// Navigate forwards.
		/// </summary>
		public unsafe virtual void GoForward()
		{
			NativeInstance->GoForward();
		}

		/// <summary>
		/// Reload the current page.
		/// </summary>
		public unsafe virtual void Reload()
		{
			NativeInstance->Reload();
		}

		/// <summary>
		/// Reload the current page ignoring any cached data.
		/// </summary>
		public unsafe virtual void ReloadIgnoreCache()
		{
			NativeInstance->ReloadIgnoreCache();
		}

		/// <summary>
		/// Stop loading the page.
		/// </summary>
		public unsafe virtual void StopLoad()
		{
			NativeInstance->StopLoad();
		}

		/// <summary>
		/// Returns true (1) if this object is pointing to the same handle as |that|
		/// object.
		/// </summary>
		public unsafe virtual bool IsSame(CefBrowser that)
		{
			return NativeInstance->IsSame((that != null) ? that.GetNativeInstance() : null) != 0;
		}

		/// <summary>
		/// Returns the frame with the specified identifier, or NULL if not found.
		/// </summary>
		public unsafe virtual CefFrame GetFrameByIdent(long identifier)
		{
			return CefFrame.Wrap(CefFrame.Create, NativeInstance->GetFrameByIdent(identifier));
		}

		/// <summary>
		/// Returns the frame with the specified name, or NULL if not found.
		/// </summary>
		public unsafe virtual CefFrame GetFrame(string name)
		{
			fixed (char* s0 = name)
			{
				var cstr0 = new cef_string_t { Str = s0, Length = name != null ? name.Length : 0 };
				return CefFrame.Wrap(CefFrame.Create, NativeInstance->GetFrame(&cstr0));
			}
		}

		/// <summary>
		/// Returns the identifiers of all existing frames.
		/// </summary>
		public unsafe virtual void GetFrameIdentifiers(ref long identifiersCount, ref long[] identifiers)
		{
			fixed (long* p1 = identifiers)
			{
				UIntPtr c1 = new UIntPtr((uint)identifiers.Length);
				NativeInstance->GetFrameIdentifiers(&c1, p1);
				identifiersCount = (long)c1;
				Array.Resize(ref identifiers, (int)c1);
			}
		}

		/// <summary>
		/// Returns the names of all existing frames.
		/// </summary>
		public unsafe virtual void GetFrameNames(CefStringList names)
		{
			NativeInstance->GetFrameNames(names.GetNativeInstance());
		}
	}
}
