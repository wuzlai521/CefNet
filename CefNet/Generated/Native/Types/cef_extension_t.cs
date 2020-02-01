﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: include/capi/cef_extension_capi.h
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
	/// Object representing an extension. Methods may be called on any thread unless
	/// otherwise indicated.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct cef_extension_t
	{
		/// <summary>
		/// Base structure.
		/// </summary>
		public cef_base_ref_counted_t @base;

		/// <summary>
		/// cef_string_userfree_t (*)(_cef_extension_t* self)*
		/// </summary>
		public void* get_identifier;

		/// <summary>
		/// Returns the unique extension identifier. This is calculated based on the
		/// extension public key, if available, or on the extension path. See
		/// https://developer.chrome.com/extensions/manifest/key for details.
		/// The resulting string must be freed by calling cef_string_userfree_free().
		/// </summary>
		[NativeName("get_identifier")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern cef_string_userfree_t GetIdentifier();

		/// <summary>
		/// cef_string_userfree_t (*)(_cef_extension_t* self)*
		/// </summary>
		public void* get_path;

		/// <summary>
		/// Returns the absolute path to the extension directory on disk. This value
		/// will be prefixed with PK_DIR_RESOURCES if a relative path was passed to
		/// cef_request_context_t::LoadExtension.
		/// The resulting string must be freed by calling cef_string_userfree_free().
		/// </summary>
		[NativeName("get_path")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern cef_string_userfree_t GetPath();

		/// <summary>
		/// _cef_dictionary_value_t* (*)(_cef_extension_t* self)*
		/// </summary>
		public void* get_manifest;

		/// <summary>
		/// Returns the extension manifest contents as a cef_dictionary_value_t object.
		/// See https://developer.chrome.com/extensions/manifest for details.
		/// </summary>
		[NativeName("get_manifest")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern cef_dictionary_value_t* GetManifest();

		/// <summary>
		/// int (*)(_cef_extension_t* self, _cef_extension_t* that)*
		/// </summary>
		public void* is_same;

		/// <summary>
		/// Returns true (1) if this object is the same extension as |that| object.
		/// Extensions are considered the same if identifier, path and loader context
		/// match.
		/// </summary>
		[NativeName("is_same")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern int IsSame(cef_extension_t* that);

		/// <summary>
		/// _cef_extension_handler_t* (*)(_cef_extension_t* self)*
		/// </summary>
		public void* get_handler;

		/// <summary>
		/// Returns the handler for this extension. Will return NULL for internal
		/// extensions or if no handler was passed to
		/// cef_request_context_t::LoadExtension.
		/// </summary>
		[NativeName("get_handler")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern cef_extension_handler_t* GetHandler();

		/// <summary>
		/// _cef_request_context_t* (*)(_cef_extension_t* self)*
		/// </summary>
		public void* get_loader_context;

		/// <summary>
		/// Returns the request context that loaded this extension. Will return NULL
		/// for internal extensions or if the extension has been unloaded. See the
		/// cef_request_context_t::LoadExtension documentation for more information
		/// about loader contexts. Must be called on the browser process UI thread.
		/// </summary>
		[NativeName("get_loader_context")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern cef_request_context_t* GetLoaderContext();

		/// <summary>
		/// int (*)(_cef_extension_t* self)*
		/// </summary>
		public void* is_loaded;

		/// <summary>
		/// Returns true (1) if this extension is currently loaded. Must be called on
		/// the browser process UI thread.
		/// </summary>
		[NativeName("is_loaded")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern int IsLoaded();

		/// <summary>
		/// void (*)(_cef_extension_t* self)*
		/// </summary>
		public void* unload;

		/// <summary>
		/// Unload this extension if it is not an internal extension and is currently
		/// loaded. Will result in a call to
		/// cef_extension_handler_t::OnExtensionUnloaded on success.
		/// </summary>
		[NativeName("unload")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern void Unload();
	}
}

