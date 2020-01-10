﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: include/capi/cef_frame_capi.h
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
	/// Structure used to represent a frame in the browser window. When used in the
	/// browser process the functions of this structure may be called on any thread
	/// unless otherwise indicated in the comments. When used in the render process
	/// the functions of this structure may only be called on the main thread.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct cef_frame_t
	{
		/// <summary>
		/// Base structure.
		/// </summary>
		public cef_base_ref_counted_t @base;

		/// <summary>
		/// int (*)(_cef_frame_t* self)*
		/// </summary>
		public void* is_valid;

		/// <summary>
		/// True if this object is currently attached to a valid frame.
		/// </summary>
		[NativeName("is_valid")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern int IsValid();

		/// <summary>
		/// void (*)(_cef_frame_t* self)*
		/// </summary>
		public void* undo;

		/// <summary>
		/// Execute undo in this frame.
		/// </summary>
		[NativeName("undo")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern void Undo();

		/// <summary>
		/// void (*)(_cef_frame_t* self)*
		/// </summary>
		public void* redo;

		/// <summary>
		/// Execute redo in this frame.
		/// </summary>
		[NativeName("redo")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern void Redo();

		/// <summary>
		/// void (*)(_cef_frame_t* self)*
		/// </summary>
		public void* cut;

		/// <summary>
		/// Execute cut in this frame.
		/// </summary>
		[NativeName("cut")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern void Cut();

		/// <summary>
		/// void (*)(_cef_frame_t* self)*
		/// </summary>
		public void* copy;

		/// <summary>
		/// Execute copy in this frame.
		/// </summary>
		[NativeName("copy")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern void Copy();

		/// <summary>
		/// void (*)(_cef_frame_t* self)*
		/// </summary>
		public void* paste;

		/// <summary>
		/// Execute paste in this frame.
		/// </summary>
		[NativeName("paste")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern void Paste();

		/// <summary>
		/// void (*)(_cef_frame_t* self)*
		/// </summary>
		public void* del;

		/// <summary>
		/// Execute delete in this frame.
		/// </summary>
		[NativeName("del")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern void Del();

		/// <summary>
		/// void (*)(_cef_frame_t* self)*
		/// </summary>
		public void* select_all;

		/// <summary>
		/// Execute select all in this frame.
		/// </summary>
		[NativeName("select_all")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern void SelectAll();

		/// <summary>
		/// void (*)(_cef_frame_t* self)*
		/// </summary>
		public void* view_source;

		/// <summary>
		/// Save this frame&apos;s HTML source to a temporary file and open it in the
		/// default text viewing application. This function can only be called from the
		/// browser process.
		/// </summary>
		[NativeName("view_source")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern void ViewSource();

		/// <summary>
		/// void (*)(_cef_frame_t* self, _cef_string_visitor_t* visitor)*
		/// </summary>
		public void* get_source;

		/// <summary>
		/// Retrieve this frame&apos;s HTML source as a string sent to the specified
		/// visitor.
		/// </summary>
		[NativeName("get_source")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern void GetSource(cef_string_visitor_t* visitor);

		/// <summary>
		/// void (*)(_cef_frame_t* self, _cef_string_visitor_t* visitor)*
		/// </summary>
		public void* get_text;

		/// <summary>
		/// Retrieve this frame&apos;s display text as a string sent to the specified
		/// visitor.
		/// </summary>
		[NativeName("get_text")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern void GetText(cef_string_visitor_t* visitor);

		/// <summary>
		/// void (*)(_cef_frame_t* self, _cef_request_t* request)*
		/// </summary>
		public void* load_request;

		/// <summary>
		/// Load the request represented by the |request| object.
		/// </summary>
		[NativeName("load_request")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern void LoadRequest(cef_request_t* request);

		/// <summary>
		/// void (*)(_cef_frame_t* self, const cef_string_t* url)*
		/// </summary>
		public void* load_url;

		/// <summary>
		/// Load the specified |url|.
		/// </summary>
		[NativeName("load_url")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern void LoadUrl([Immutable]cef_string_t* url);

		/// <summary>
		/// void (*)(_cef_frame_t* self, const cef_string_t* string_val, const cef_string_t* url)*
		/// </summary>
		public void* load_string;

		/// <summary>
		/// Load the contents of |string_val| with the specified dummy |url|. |url|
		/// should have a standard scheme (for example, http scheme) or behaviors like
		/// link clicks and web security restrictions may not behave as expected.
		/// </summary>
		[NativeName("load_string")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern void LoadString([Immutable]cef_string_t* string_val, [Immutable]cef_string_t* url);

		/// <summary>
		/// void (*)(_cef_frame_t* self, const cef_string_t* code, const cef_string_t* script_url, int start_line)*
		/// </summary>
		public void* execute_java_script;

		/// <summary>
		/// Execute a string of JavaScript code in this frame. The |script_url|
		/// parameter is the URL where the script in question can be found, if any. The
		/// renderer may request this URL to show the developer the source of the
		/// error.  The |start_line| parameter is the base line number to use for error
		/// reporting.
		/// </summary>
		[NativeName("execute_java_script")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern void ExecuteJavaScript([Immutable]cef_string_t* code, [Immutable]cef_string_t* script_url, int start_line);

		/// <summary>
		/// int (*)(_cef_frame_t* self)*
		/// </summary>
		public void* is_main;

		/// <summary>
		/// Returns true (1) if this is the main (top-level) frame.
		/// </summary>
		[NativeName("is_main")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern int IsMain();

		/// <summary>
		/// int (*)(_cef_frame_t* self)*
		/// </summary>
		public void* is_focused;

		/// <summary>
		/// Returns true (1) if this is the focused frame.
		/// </summary>
		[NativeName("is_focused")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern int IsFocused();

		/// <summary>
		/// cef_string_userfree_t (*)(_cef_frame_t* self)*
		/// </summary>
		public void* get_name;

		/// <summary>
		/// Returns the name for this frame. If the frame has an assigned name (for
		/// example, set via the iframe &quot;name&quot; attribute) then that value will be
		/// returned. Otherwise a unique name will be constructed based on the frame
		/// parent hierarchy. The main (top-level) frame will always have an NULL name
		/// value.
		/// The resulting string must be freed by calling cef_string_userfree_free().
		/// </summary>
		[NativeName("get_name")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern cef_string_userfree_t GetName();

		/// <summary>
		/// int64 (*)(_cef_frame_t* self)*
		/// </summary>
		public void* get_identifier;

		/// <summary>
		/// Returns the globally unique identifier for this frame or 
		/// &lt;
		/// 0 if the
		/// underlying frame does not yet exist.
		/// </summary>
		[NativeName("get_identifier")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern long GetIdentifier();

		/// <summary>
		/// _cef_frame_t* (*)(_cef_frame_t* self)*
		/// </summary>
		public void* get_parent;

		/// <summary>
		/// Returns the parent of this frame or NULL if this is the main (top-level)
		/// frame.
		/// </summary>
		[NativeName("get_parent")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern cef_frame_t* GetParent();

		/// <summary>
		/// cef_string_userfree_t (*)(_cef_frame_t* self)*
		/// </summary>
		public void* get_url;

		/// <summary>
		/// Returns the URL currently loaded in this frame.
		/// The resulting string must be freed by calling cef_string_userfree_free().
		/// </summary>
		[NativeName("get_url")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern cef_string_userfree_t GetUrl();

		/// <summary>
		/// _cef_browser_t* (*)(_cef_frame_t* self)*
		/// </summary>
		public void* get_browser;

		/// <summary>
		/// Returns the browser that this frame belongs to.
		/// </summary>
		[NativeName("get_browser")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern cef_browser_t* GetBrowser();

		/// <summary>
		/// _cef_v8context_t* (*)(_cef_frame_t* self)*
		/// </summary>
		public void* get_v8context;

		/// <summary>
		/// Get the V8 context associated with the frame. This function can only be
		/// called from the render process.
		/// </summary>
		[NativeName("get_v8context")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern cef_v8context_t* GetV8Context();

		/// <summary>
		/// void (*)(_cef_frame_t* self, _cef_domvisitor_t* visitor)*
		/// </summary>
		public void* visit_dom;

		/// <summary>
		/// Visit the DOM document. This function can only be called from the render
		/// process.
		/// </summary>
		[NativeName("visit_dom")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern void VisitDOM(cef_domvisitor_t* visitor);

		/// <summary>
		/// _cef_urlrequest_t* (*)(_cef_frame_t* self, _cef_request_t* request, _cef_urlrequest_client_t* client)*
		/// </summary>
		public void* create_urlrequest;

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
		[NativeName("create_urlrequest")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern cef_urlrequest_t* CreateUrlRequest(cef_request_t* request, cef_urlrequest_client_t* client);

		/// <summary>
		/// void (*)(_cef_frame_t* self, cef_process_id_t target_process, _cef_process_message_t* message)*
		/// </summary>
		public void* send_process_message;

		/// <summary>
		/// Send a message to the specified |target_process|. Message delivery is not
		/// guaranteed in all cases (for example, if the browser is closing,
		/// navigating, or if the target process crashes). Send an ACK message back
		/// from the target process if confirmation is required.
		/// </summary>
		[NativeName("send_process_message")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern void SendProcessMessage(CefProcessId target_process, cef_process_message_t* message);
	}
}

