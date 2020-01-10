﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: Generated/Native/Types/cef_frame_t.cs
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
	/// Structure used to represent a frame in the browser window. When used in the
	/// browser process the functions of this structure may be called on any thread
	/// unless otherwise indicated in the comments. When used in the render process
	/// the functions of this structure may only be called on the main thread.
	/// </summary>
	/// <remarks>
	/// Role: Proxy
	/// </remarks>
	public unsafe partial class CefFrame : CefBaseRefCounted<cef_frame_t>
	{
		internal static unsafe CefFrame Create(IntPtr instance)
		{
			return new CefFrame((cef_frame_t*)instance);
		}

		public CefFrame(cef_frame_t* instance)
			: base((cef_base_ref_counted_t*)instance)
		{
		}

		/// <summary>
		/// Gets a value indicating whether this object is currently attached to a valid frame.
		/// </summary>
		public unsafe virtual bool IsValid
		{
			get
			{
				return NativeInstance->IsValid() != 0;
			}
		}

		/// <summary>
		/// Gets a value indicating whether this is the main (top-level) frame.
		/// </summary>
		public unsafe virtual bool IsMain
		{
			get
			{
				return NativeInstance->IsMain() != 0;
			}
		}

		/// <summary>
		/// Gets a value indicating whether this is the focused frame.
		/// </summary>
		public unsafe virtual bool IsFocused
		{
			get
			{
				return NativeInstance->IsFocused() != 0;
			}
		}

		/// <summary>
		/// Gets the name for this frame. If the frame has an assigned name (for
		/// example, set via the iframe &quot;name&quot; attribute) then that value will be
		/// returned. Otherwise a unique name will be constructed based on the frame
		/// parent hierarchy. The main (top-level) frame will always have an NULL name
		/// value.
		/// The resulting string must be freed by calling cef_string_userfree_free().
		/// </summary>
		public unsafe virtual string Name
		{
			get
			{
				return CefString.ReadAndFree(NativeInstance->GetName());
			}
		}

		/// <summary>
		/// Gets the globally unique identifier for this frame or
		/// &lt;
		/// 0 if the
		/// underlying frame does not yet exist.
		/// </summary>
		public unsafe virtual long Identifier
		{
			get
			{
				return NativeInstance->GetIdentifier();
			}
		}

		/// <summary>
		/// Gets the parent of this frame or NULL if this is the main (top-level)
		/// frame.
		/// </summary>
		public unsafe virtual CefFrame Parent
		{
			get
			{
				return CefFrame.Wrap(CefFrame.Create, NativeInstance->GetParent());
			}
		}

		/// <summary>
		/// Gets the URL currently loaded in this frame.
		/// The resulting string must be freed by calling cef_string_userfree_free().
		/// </summary>
		public unsafe virtual string Url
		{
			get
			{
				return CefString.ReadAndFree(NativeInstance->GetUrl());
			}
		}

		/// <summary>
		/// Gets the browser that this frame belongs to.
		/// </summary>
		public unsafe virtual CefBrowser Browser
		{
			get
			{
				return CefBrowser.Wrap(CefBrowser.Create, NativeInstance->GetBrowser());
			}
		}

		/// <summary>
		/// Get the V8 context associated with the frame. This property can only be
		/// called from the render process.
		/// </summary>
		public unsafe virtual CefV8Context V8Context
		{
			get
			{
				return CefV8Context.Wrap(CefV8Context.Create, NativeInstance->GetV8Context());
			}
		}

		/// <summary>
		/// Execute undo in this frame.
		/// </summary>
		public unsafe virtual void Undo()
		{
			NativeInstance->Undo();
		}

		/// <summary>
		/// Execute redo in this frame.
		/// </summary>
		public unsafe virtual void Redo()
		{
			NativeInstance->Redo();
		}

		/// <summary>
		/// Execute cut in this frame.
		/// </summary>
		public unsafe virtual void Cut()
		{
			NativeInstance->Cut();
		}

		/// <summary>
		/// Execute copy in this frame.
		/// </summary>
		public unsafe virtual void Copy()
		{
			NativeInstance->Copy();
		}

		/// <summary>
		/// Execute paste in this frame.
		/// </summary>
		public unsafe virtual void Paste()
		{
			NativeInstance->Paste();
		}

		/// <summary>
		/// Execute delete in this frame.
		/// </summary>
		public unsafe virtual void Del()
		{
			NativeInstance->Del();
		}

		/// <summary>
		/// Execute select all in this frame.
		/// </summary>
		public unsafe virtual void SelectAll()
		{
			NativeInstance->SelectAll();
		}

		/// <summary>
		/// Save this frame&apos;s HTML source to a temporary file and open it in the
		/// default text viewing application. This function can only be called from the
		/// browser process.
		/// </summary>
		public unsafe virtual void ViewSource()
		{
			NativeInstance->ViewSource();
		}

		/// <summary>
		/// Retrieve this frame&apos;s HTML source as a string sent to the specified
		/// visitor.
		/// </summary>
		public unsafe virtual void GetSource(CefStringVisitor visitor)
		{
			NativeInstance->GetSource((visitor != null) ? visitor.GetNativeInstance() : null);
		}

		/// <summary>
		/// Retrieve this frame&apos;s display text as a string sent to the specified
		/// visitor.
		/// </summary>
		public unsafe virtual void GetText(CefStringVisitor visitor)
		{
			NativeInstance->GetText((visitor != null) ? visitor.GetNativeInstance() : null);
		}

		/// <summary>
		/// Load the request represented by the |request| object.
		/// </summary>
		public unsafe virtual void LoadRequest(CefRequest request)
		{
			NativeInstance->LoadRequest((request != null) ? request.GetNativeInstance() : null);
		}

		/// <summary>
		/// Load the specified |url|.
		/// </summary>
		public unsafe virtual void LoadUrl(string url)
		{
			fixed (char* s0 = url)
			{
				var cstr0 = new cef_string_t { Str = s0, Length = url != null ? url.Length : 0 };
				NativeInstance->LoadUrl(&cstr0);
			}
		}

		/// <summary>
		/// Load the contents of |string_val| with the specified dummy |url|. |url|
		/// should have a standard scheme (for example, http scheme) or behaviors like
		/// link clicks and web security restrictions may not behave as expected.
		/// </summary>
		public unsafe virtual void LoadString(string stringVal, string url)
		{
			fixed (char* s0 = stringVal)
			fixed (char* s1 = url)
			{
				var cstr0 = new cef_string_t { Str = s0, Length = stringVal != null ? stringVal.Length : 0 };
				var cstr1 = new cef_string_t { Str = s1, Length = url != null ? url.Length : 0 };
				NativeInstance->LoadString(&cstr0, &cstr1);
			}
		}

		/// <summary>
		/// Execute a string of JavaScript code in this frame. The |script_url|
		/// parameter is the URL where the script in question can be found, if any. The
		/// renderer may request this URL to show the developer the source of the
		/// error.  The |start_line| parameter is the base line number to use for error
		/// reporting.
		/// </summary>
		public unsafe virtual void ExecuteJavaScript(string code, string scriptUrl, int startLine)
		{
			fixed (char* s0 = code)
			fixed (char* s1 = scriptUrl)
			{
				var cstr0 = new cef_string_t { Str = s0, Length = code != null ? code.Length : 0 };
				var cstr1 = new cef_string_t { Str = s1, Length = scriptUrl != null ? scriptUrl.Length : 0 };
				NativeInstance->ExecuteJavaScript(&cstr0, &cstr1, startLine);
			}
		}

		/// <summary>
		/// Visit the DOM document. This function can only be called from the render
		/// process.
		/// </summary>
		public unsafe virtual void VisitDOM(CefDOMVisitor visitor)
		{
			NativeInstance->VisitDOM((visitor != null) ? visitor.GetNativeInstance() : null);
		}

		/// <summary>
		/// Create a new URL request that will be treated as originating from this
		/// frame and the associated browser. This request may be intercepted by the
		/// client via cef_resource_request_handler_t or cef_scheme_handler_factory_t.
		/// Use cef_urlrequest_t::Create instead if you do not want the request to have
		/// this association, in which case it may be handled differently (see
		/// documentation on that function). Requests may originate from both the
		/// browser process and the render process.
		/// For requests originating from the browser process:
		/// - POST data may only contain a single element of type PDE_TYPE_FILE or
		/// PDE_TYPE_BYTES.
		/// For requests originating from the render process:
		/// - POST data may only contain a single element of type PDE_TYPE_BYTES.
		/// - If the response contains Content-Disposition or Mime-Type header values
		/// that would not normally be rendered then the response may receive
		/// special handling inside the browser (for example, via the file download
		/// code path instead of the URL request code path).
		/// The |request| object will be marked as read-only after calling this
		/// function.
		/// </summary>
		public unsafe virtual CefUrlRequest CreateUrlRequest(CefRequest request, CefUrlRequestClient client)
		{
			return CefUrlRequest.Wrap(CefUrlRequest.Create, NativeInstance->CreateUrlRequest((request != null) ? request.GetNativeInstance() : null, (client != null) ? client.GetNativeInstance() : null));
		}

		/// <summary>
		/// Send a message to the specified |target_process|. Message delivery is not
		/// guaranteed in all cases (for example, if the browser is closing,
		/// navigating, or if the target process crashes). Send an ACK message back
		/// from the target process if confirmation is required.
		/// </summary>
		public unsafe virtual void SendProcessMessage(CefProcessId targetProcess, CefProcessMessage message)
		{
			NativeInstance->SendProcessMessage(targetProcess, (message != null) ? message.GetNativeInstance() : null);
		}
	}
}
