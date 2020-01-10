﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: include/capi/cef_menu_model_delegate_capi.h
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
	/// Implement this structure to handle menu model events. The functions of this
	/// structure will be called on the browser process UI thread unless otherwise
	/// indicated.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct cef_menu_model_delegate_t
	{
		/// <summary>
		/// Base structure.
		/// </summary>
		public cef_base_ref_counted_t @base;

		/// <summary>
		/// void (*)(_cef_menu_model_delegate_t* self, _cef_menu_model_t* menu_model, int command_id, cef_event_flags_t event_flags)*
		/// </summary>
		public void* execute_command;

		/// <summary>
		/// Perform the action associated with the specified |command_id| and optional
		/// |event_flags|.
		/// </summary>
		[NativeName("execute_command")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern void ExecuteCommand(cef_menu_model_t* menu_model, int command_id, CefEventFlags event_flags);

		/// <summary>
		/// void (*)(_cef_menu_model_delegate_t* self, _cef_menu_model_t* menu_model, const cef_point_t* screen_point)*
		/// </summary>
		public void* mouse_outside_menu;

		/// <summary>
		/// Called when the user moves the mouse outside the menu and over the owning
		/// window.
		/// </summary>
		[NativeName("mouse_outside_menu")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern void MouseOutsideMenu(cef_menu_model_t* menu_model, [Immutable]cef_point_t* screen_point);

		/// <summary>
		/// void (*)(_cef_menu_model_delegate_t* self, _cef_menu_model_t* menu_model, int is_rtl)*
		/// </summary>
		public void* unhandled_open_submenu;

		/// <summary>
		/// Called on unhandled open submenu keyboard commands. |is_rtl| will be true
		/// (1) if the menu is displaying a right-to-left language.
		/// </summary>
		[NativeName("unhandled_open_submenu")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern void UnhandledOpenSubmenu(cef_menu_model_t* menu_model, int is_rtl);

		/// <summary>
		/// void (*)(_cef_menu_model_delegate_t* self, _cef_menu_model_t* menu_model, int is_rtl)*
		/// </summary>
		public void* unhandled_close_submenu;

		/// <summary>
		/// Called on unhandled close submenu keyboard commands. |is_rtl| will be true
		/// (1) if the menu is displaying a right-to-left language.
		/// </summary>
		[NativeName("unhandled_close_submenu")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern void UnhandledCloseSubmenu(cef_menu_model_t* menu_model, int is_rtl);

		/// <summary>
		/// void (*)(_cef_menu_model_delegate_t* self, _cef_menu_model_t* menu_model)*
		/// </summary>
		public void* menu_will_show;

		/// <summary>
		/// The menu is about to show.
		/// </summary>
		[NativeName("menu_will_show")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern void MenuWillShow(cef_menu_model_t* menu_model);

		/// <summary>
		/// void (*)(_cef_menu_model_delegate_t* self, _cef_menu_model_t* menu_model)*
		/// </summary>
		public void* menu_closed;

		/// <summary>
		/// The menu has closed.
		/// </summary>
		[NativeName("menu_closed")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern void MenuClosed(cef_menu_model_t* menu_model);

		/// <summary>
		/// int (*)(_cef_menu_model_delegate_t* self, _cef_menu_model_t* menu_model, cef_string_t* label)*
		/// </summary>
		public void* format_label;

		/// <summary>
		/// Optionally modify a menu item label. Return true (1) if |label| was
		/// modified.
		/// </summary>
		[NativeName("format_label")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern int FormatLabel(cef_menu_model_t* menu_model, cef_string_t* label);
	}
}

