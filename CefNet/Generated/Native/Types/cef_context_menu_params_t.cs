﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: include/capi/cef_context_menu_handler_capi.h
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
	/// Provides information about the context menu state. The ethods of this
	/// structure can only be accessed on browser process the UI thread.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct cef_context_menu_params_t
	{
		/// <summary>
		/// Base structure.
		/// </summary>
		public cef_base_ref_counted_t @base;

		/// <summary>
		/// int (*)(_cef_context_menu_params_t* self)*
		/// </summary>
		public void* get_xcoord;

		/// <summary>
		/// Returns the X coordinate of the mouse where the context menu was invoked.
		/// Coords are relative to the associated RenderView&apos;s origin.
		/// </summary>
		[NativeName("get_xcoord")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern int GetXCoord();

		/// <summary>
		/// int (*)(_cef_context_menu_params_t* self)*
		/// </summary>
		public void* get_ycoord;

		/// <summary>
		/// Returns the Y coordinate of the mouse where the context menu was invoked.
		/// Coords are relative to the associated RenderView&apos;s origin.
		/// </summary>
		[NativeName("get_ycoord")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern int GetYCoord();

		/// <summary>
		/// cef_context_menu_type_flags_t (*)(_cef_context_menu_params_t* self)*
		/// </summary>
		public void* get_type_flags;

		/// <summary>
		/// Returns flags representing the type of node that the context menu was
		/// invoked on.
		/// </summary>
		[NativeName("get_type_flags")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern CefContextMenuTypeFlags GetTypeFlags();

		/// <summary>
		/// cef_string_userfree_t (*)(_cef_context_menu_params_t* self)*
		/// </summary>
		public void* get_link_url;

		/// <summary>
		/// Returns the URL of the link, if any, that encloses the node that the
		/// context menu was invoked on.
		/// The resulting string must be freed by calling cef_string_userfree_free().
		/// </summary>
		[NativeName("get_link_url")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern cef_string_userfree_t GetLinkUrl();

		/// <summary>
		/// cef_string_userfree_t (*)(_cef_context_menu_params_t* self)*
		/// </summary>
		public void* get_unfiltered_link_url;

		/// <summary>
		/// Returns the link URL, if any, to be used ONLY for &quot;copy link address&quot;. We
		/// don&apos;t validate this field in the frontend process.
		/// The resulting string must be freed by calling cef_string_userfree_free().
		/// </summary>
		[NativeName("get_unfiltered_link_url")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern cef_string_userfree_t GetUnfilteredLinkUrl();

		/// <summary>
		/// cef_string_userfree_t (*)(_cef_context_menu_params_t* self)*
		/// </summary>
		public void* get_source_url;

		/// <summary>
		/// Returns the source URL, if any, for the element that the context menu was
		/// invoked on. Example of elements with source URLs are img, audio, and video.
		/// The resulting string must be freed by calling cef_string_userfree_free().
		/// </summary>
		[NativeName("get_source_url")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern cef_string_userfree_t GetSourceUrl();

		/// <summary>
		/// int (*)(_cef_context_menu_params_t* self)*
		/// </summary>
		public void* has_image_contents;

		/// <summary>
		/// Returns true (1) if the context menu was invoked on an image which has non-
		/// NULL contents.
		/// </summary>
		[NativeName("has_image_contents")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern int HasImageContents();

		/// <summary>
		/// cef_string_userfree_t (*)(_cef_context_menu_params_t* self)*
		/// </summary>
		public void* get_title_text;

		/// <summary>
		/// Returns the title text or the alt text if the context menu was invoked on
		/// an image.
		/// The resulting string must be freed by calling cef_string_userfree_free().
		/// </summary>
		[NativeName("get_title_text")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern cef_string_userfree_t GetTitleText();

		/// <summary>
		/// cef_string_userfree_t (*)(_cef_context_menu_params_t* self)*
		/// </summary>
		public void* get_page_url;

		/// <summary>
		/// Returns the URL of the top level page that the context menu was invoked on.
		/// The resulting string must be freed by calling cef_string_userfree_free().
		/// </summary>
		[NativeName("get_page_url")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern cef_string_userfree_t GetPageUrl();

		/// <summary>
		/// cef_string_userfree_t (*)(_cef_context_menu_params_t* self)*
		/// </summary>
		public void* get_frame_url;

		/// <summary>
		/// Returns the URL of the subframe that the context menu was invoked on.
		/// The resulting string must be freed by calling cef_string_userfree_free().
		/// </summary>
		[NativeName("get_frame_url")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern cef_string_userfree_t GetFrameUrl();

		/// <summary>
		/// cef_string_userfree_t (*)(_cef_context_menu_params_t* self)*
		/// </summary>
		public void* get_frame_charset;

		/// <summary>
		/// Returns the character encoding of the subframe that the context menu was
		/// invoked on.
		/// The resulting string must be freed by calling cef_string_userfree_free().
		/// </summary>
		[NativeName("get_frame_charset")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern cef_string_userfree_t GetFrameCharset();

		/// <summary>
		/// cef_context_menu_media_type_t (*)(_cef_context_menu_params_t* self)*
		/// </summary>
		public void* get_media_type;

		/// <summary>
		/// Returns the type of context node that the context menu was invoked on.
		/// </summary>
		[NativeName("get_media_type")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern CefContextMenuMediaType GetMediaType();

		/// <summary>
		/// cef_context_menu_media_state_flags_t (*)(_cef_context_menu_params_t* self)*
		/// </summary>
		public void* get_media_state_flags;

		/// <summary>
		/// Returns flags representing the actions supported by the media element, if
		/// any, that the context menu was invoked on.
		/// </summary>
		[NativeName("get_media_state_flags")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern CefContextMenuMediaStateFlags GetMediaStateFlags();

		/// <summary>
		/// cef_string_userfree_t (*)(_cef_context_menu_params_t* self)*
		/// </summary>
		public void* get_selection_text;

		/// <summary>
		/// Returns the text of the selection, if any, that the context menu was
		/// invoked on.
		/// The resulting string must be freed by calling cef_string_userfree_free().
		/// </summary>
		[NativeName("get_selection_text")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern cef_string_userfree_t GetSelectionText();

		/// <summary>
		/// cef_string_userfree_t (*)(_cef_context_menu_params_t* self)*
		/// </summary>
		public void* get_misspelled_word;

		/// <summary>
		/// Returns the text of the misspelled word, if any, that the context menu was
		/// invoked on.
		/// The resulting string must be freed by calling cef_string_userfree_free().
		/// </summary>
		[NativeName("get_misspelled_word")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern cef_string_userfree_t GetMisspelledWord();

		/// <summary>
		/// int (*)(_cef_context_menu_params_t* self, cef_string_list_t suggestions)*
		/// </summary>
		public void* get_dictionary_suggestions;

		/// <summary>
		/// Returns true (1) if suggestions exist, false (0) otherwise. Fills in
		/// |suggestions| from the spell check service for the misspelled word if there
		/// is one.
		/// </summary>
		[MethodImpl(MethodImplOptions.ForwardRef)]
		[NativeName("get_dictionary_suggestions")]
		public unsafe extern int GetDictionarySuggestions(cef_string_list_t suggestions);

		/// <summary>
		/// int (*)(_cef_context_menu_params_t* self)*
		/// </summary>
		public void* is_editable;

		/// <summary>
		/// Returns true (1) if the context menu was invoked on an editable node.
		/// </summary>
		[NativeName("is_editable")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern int IsEditable();

		/// <summary>
		/// int (*)(_cef_context_menu_params_t* self)*
		/// </summary>
		public void* is_spell_check_enabled;

		/// <summary>
		/// Returns true (1) if the context menu was invoked on an editable node where
		/// spell-check is enabled.
		/// </summary>
		[NativeName("is_spell_check_enabled")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern int IsSpellCheckEnabled();

		/// <summary>
		/// cef_context_menu_edit_state_flags_t (*)(_cef_context_menu_params_t* self)*
		/// </summary>
		public void* get_edit_state_flags;

		/// <summary>
		/// Returns flags representing the actions supported by the editable node, if
		/// any, that the context menu was invoked on.
		/// </summary>
		[NativeName("get_edit_state_flags")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern CefContextMenuEditStateFlags GetEditStateFlags();

		/// <summary>
		/// int (*)(_cef_context_menu_params_t* self)*
		/// </summary>
		public void* is_custom_menu;

		/// <summary>
		/// Returns true (1) if the context menu contains items specified by the
		/// renderer process (for example, plugin placeholder or pepper plugin menu
		/// items).
		/// </summary>
		[NativeName("is_custom_menu")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern int IsCustomMenu();

		/// <summary>
		/// int (*)(_cef_context_menu_params_t* self)*
		/// </summary>
		public void* is_pepper_menu;

		/// <summary>
		/// Returns true (1) if the context menu was invoked from a pepper plugin.
		/// </summary>
		[NativeName("is_pepper_menu")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern int IsPepperMenu();
	}
}

