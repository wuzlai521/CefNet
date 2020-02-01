﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: include/capi/cef_browser_capi.h
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
	/// Structure used to represent the browser process aspects of a browser window.
	/// The functions of this structure can only be called in the browser process.
	/// They may be called on any thread in that process unless otherwise indicated
	/// in the comments.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct cef_browser_host_t
	{
		/// <summary>
		/// Base structure.
		/// </summary>
		public cef_base_ref_counted_t @base;

		/// <summary>
		/// _cef_browser_t* (*)(_cef_browser_host_t* self)*
		/// </summary>
		public void* get_browser;

		/// <summary>
		/// Returns the hosted browser object.
		/// </summary>
		[NativeName("get_browser")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern cef_browser_t* GetBrowser();

		/// <summary>
		/// void (*)(_cef_browser_host_t* self, int force_close)*
		/// </summary>
		public void* close_browser;

		/// <summary>
		/// Request that the browser close. The JavaScript &apos;onbeforeunload&apos; event will
		/// be fired. If |force_close| is false (0) the event handler, if any, will be
		/// allowed to prompt the user and the user can optionally cancel the close. If
		/// |force_close| is true (1) the prompt will not be displayed and the close
		/// will proceed. Results in a call to cef_life_span_handler_t::do_close() if
		/// the event handler allows the close or if |force_close| is true (1). See
		/// cef_life_span_handler_t::do_close() documentation for additional usage
		/// information.
		/// </summary>
		[NativeName("close_browser")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern void CloseBrowser(int force_close);

		/// <summary>
		/// int (*)(_cef_browser_host_t* self)*
		/// </summary>
		public void* try_close_browser;

		/// <summary>
		/// Helper for closing a browser. Call this function from the top-level window
		/// close handler. Internally this calls CloseBrowser(false (0)) if the close
		/// has not yet been initiated. This function returns false (0) while the close
		/// is pending and true (1) after the close has completed. See close_browser()
		/// and cef_life_span_handler_t::do_close() documentation for additional usage
		/// information. This function must be called on the browser process UI thread.
		/// </summary>
		[NativeName("try_close_browser")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern int TryCloseBrowser();

		/// <summary>
		/// void (*)(_cef_browser_host_t* self, int focus)*
		/// </summary>
		public void* set_focus;

		/// <summary>
		/// Set whether the browser is focused.
		/// </summary>
		[NativeName("set_focus")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern void SetFocus(int focus);

		/// <summary>
		/// HWND (*)(_cef_browser_host_t* self)*
		/// </summary>
		public void* get_window_handle;

		/// <summary>
		/// Retrieve the window handle for this browser. If this browser is wrapped in
		/// a cef_browser_view_t this function should be called on the browser process
		/// UI thread and it will return the handle for the top-level native window.
		/// </summary>
		[NativeName("get_window_handle")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern IntPtr GetWindowHandle();

		/// <summary>
		/// HWND (*)(_cef_browser_host_t* self)*
		/// </summary>
		public void* get_opener_window_handle;

		/// <summary>
		/// Retrieve the window handle of the browser that opened this browser. Will
		/// return NULL for non-popup windows or if this browser is wrapped in a
		/// cef_browser_view_t. This function can be used in combination with custom
		/// handling of modal windows.
		/// </summary>
		[NativeName("get_opener_window_handle")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern IntPtr GetOpenerWindowHandle();

		/// <summary>
		/// int (*)(_cef_browser_host_t* self)*
		/// </summary>
		public void* has_view;

		/// <summary>
		/// Returns true (1) if this browser is wrapped in a cef_browser_view_t.
		/// </summary>
		[NativeName("has_view")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern int HasView();

		/// <summary>
		/// _cef_client_t* (*)(_cef_browser_host_t* self)*
		/// </summary>
		public void* get_client;

		/// <summary>
		/// Returns the client for this browser.
		/// </summary>
		[NativeName("get_client")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern cef_client_t* GetClient();

		/// <summary>
		/// _cef_request_context_t* (*)(_cef_browser_host_t* self)*
		/// </summary>
		public void* get_request_context;

		/// <summary>
		/// Returns the request context for this browser.
		/// </summary>
		[NativeName("get_request_context")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern cef_request_context_t* GetRequestContext();

		/// <summary>
		/// double (*)(_cef_browser_host_t* self)*
		/// </summary>
		public void* get_zoom_level;

		/// <summary>
		/// Get the current zoom level. The default zoom level is 0.0. This function
		/// can only be called on the UI thread.
		/// </summary>
		[NativeName("get_zoom_level")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern double GetZoomLevel();

		/// <summary>
		/// void (*)(_cef_browser_host_t* self, double zoomLevel)*
		/// </summary>
		public void* set_zoom_level;

		/// <summary>
		/// Change the zoom level to the specified value. Specify 0.0 to reset the zoom
		/// level. If called on the UI thread the change will be applied immediately.
		/// Otherwise, the change will be applied asynchronously on the UI thread.
		/// </summary>
		[NativeName("set_zoom_level")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern void SetZoomLevel(double zoomLevel);

		/// <summary>
		/// void (*)(_cef_browser_host_t* self, cef_file_dialog_mode_t mode, const cef_string_t* title, const cef_string_t* default_file_path, cef_string_list_t accept_filters, int selected_accept_filter, _cef_run_file_dialog_callback_t* callback)*
		/// </summary>
		public void* run_file_dialog;

		/// <summary>
		/// Call to run a file chooser dialog. Only a single file chooser dialog may be
		/// pending at any given time. |mode| represents the type of dialog to display.
		/// |title| to the title to be used for the dialog and may be NULL to show the
		/// default title (&quot;Open&quot; or &quot;Save&quot; depending on the mode). |default_file_path|
		/// is the path with optional directory and/or file name component that will be
		/// initially selected in the dialog. |accept_filters| are used to restrict the
		/// selectable file types and may any combination of (a) valid lower-cased MIME
		/// types (e.g. &quot;text/*&quot; or &quot;image/*&quot;), (b) individual file extensions (e.g.
		/// &quot;.txt&quot; or &quot;.png&quot;), or (c) combined description and file extension delimited
		/// using &quot;|&quot; and &quot;;&quot; (e.g. &quot;Image Types|.png;.gif;.jpg&quot;).
		/// |selected_accept_filter| is the 0-based index of the filter that will be
		/// selected by default. |callback| will be executed after the dialog is
		/// dismissed or immediately if another dialog is already pending. The dialog
		/// will be initiated asynchronously on the UI thread.
		/// </summary>
		[NativeName("run_file_dialog")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern void RunFileDialog(CefFileDialogMode mode, [Immutable]cef_string_t* title, [Immutable]cef_string_t* default_file_path, cef_string_list_t accept_filters, int selected_accept_filter, cef_run_file_dialog_callback_t* callback);

		/// <summary>
		/// void (*)(_cef_browser_host_t* self, const cef_string_t* url)*
		/// </summary>
		public void* start_download;

		/// <summary>
		/// Download the file at |url| using cef_download_handler_t.
		/// </summary>
		[NativeName("start_download")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern void StartDownload([Immutable]cef_string_t* url);

		/// <summary>
		/// void (*)(_cef_browser_host_t* self, const cef_string_t* image_url, int is_favicon, uint32 max_image_size, int bypass_cache, _cef_download_image_callback_t* callback)*
		/// </summary>
		public void* download_image;

		/// <summary>
		/// Download |image_url| and execute |callback| on completion with the images
		/// received from the renderer. If |is_favicon| is true (1) then cookies are
		/// not sent and not accepted during download. Images with density independent
		/// pixel (DIP) sizes larger than |max_image_size| are filtered out from the
		/// image results. Versions of the image at different scale factors may be
		/// downloaded up to the maximum scale factor supported by the system. If there
		/// are no image results 
		/// &lt;
		/// = |max_image_size| then the smallest image is resized
		/// to |max_image_size| and is the only result. A |max_image_size| of 0 means
		/// unlimited. If |bypass_cache| is true (1) then |image_url| is requested from
		/// the server even if it is present in the browser cache.
		/// </summary>
		[NativeName("download_image")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern void DownloadImage([Immutable]cef_string_t* image_url, int is_favicon, uint max_image_size, int bypass_cache, cef_download_image_callback_t* callback);

		/// <summary>
		/// void (*)(_cef_browser_host_t* self)*
		/// </summary>
		public void* print;

		/// <summary>
		/// Print the current browser contents.
		/// </summary>
		[NativeName("print")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern void Print();

		/// <summary>
		/// void (*)(_cef_browser_host_t* self, const cef_string_t* path, const const _cef_pdf_print_settings_t* settings, _cef_pdf_print_callback_t* callback)*
		/// </summary>
		public void* print_to_pdf;

		/// <summary>
		/// Print the current browser contents to the PDF file specified by |path| and
		/// execute |callback| on completion. The caller is responsible for deleting
		/// |path| when done. For PDF printing to work on Linux you must implement the
		/// cef_print_handler_t::GetPdfPaperSize function.
		/// </summary>
		[NativeName("print_to_pdf")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern void PrintToPdf([Immutable]cef_string_t* path, [Immutable]cef_pdf_print_settings_t* settings, cef_pdf_print_callback_t* callback);

		/// <summary>
		/// void (*)(_cef_browser_host_t* self, int identifier, const cef_string_t* searchText, int forward, int matchCase, int findNext)*
		/// </summary>
		public void* find;

		/// <summary>
		/// Search for |searchText|. |identifier| must be a unique ID and these IDs
		/// must strictly increase so that newer requests always have greater IDs than
		/// older requests. If |identifier| is zero or less than the previous ID value
		/// then it will be automatically assigned a new valid ID. |forward| indicates
		/// whether to search forward or backward within the page. |matchCase|
		/// indicates whether the search should be case-sensitive. |findNext| indicates
		/// whether this is the first request or a follow-up. The cef_find_handler_t
		/// instance, if any, returned via cef_client_t::GetFindHandler will be called
		/// to report find results.
		/// </summary>
		[NativeName("find")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern void Find(int identifier, [Immutable]cef_string_t* searchText, int forward, int matchCase, int findNext);

		/// <summary>
		/// void (*)(_cef_browser_host_t* self, int clearSelection)*
		/// </summary>
		public void* stop_finding;

		/// <summary>
		/// Cancel all searches that are currently going on.
		/// </summary>
		[NativeName("stop_finding")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern void StopFinding(int clearSelection);

		/// <summary>
		/// void (*)(_cef_browser_host_t* self, const const _cef_window_info_t* windowInfo, _cef_client_t* client, const const _cef_browser_settings_t* settings, const cef_point_t* inspect_element_at)*
		/// </summary>
		public void* show_dev_tools;

		/// <summary>
		/// Open developer tools (DevTools) in its own browser. The DevTools browser
		/// will remain associated with this browser. If the DevTools browser is
		/// already open then it will be focused, in which case the |windowInfo|,
		/// |client| and |settings| parameters will be ignored. If |inspect_element_at|
		/// is non-NULL then the element at the specified (x,y) location will be
		/// inspected. The |windowInfo| parameter will be ignored if this browser is
		/// wrapped in a cef_browser_view_t.
		/// </summary>
		[NativeName("show_dev_tools")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern void ShowDevTools([Immutable]cef_window_info_t* windowInfo, cef_client_t* client, [Immutable]cef_browser_settings_t* settings, [Immutable]cef_point_t* inspect_element_at);

		/// <summary>
		/// void (*)(_cef_browser_host_t* self)*
		/// </summary>
		public void* close_dev_tools;

		/// <summary>
		/// Explicitly close the associated DevTools browser, if any.
		/// </summary>
		[NativeName("close_dev_tools")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern void CloseDevTools();

		/// <summary>
		/// int (*)(_cef_browser_host_t* self)*
		/// </summary>
		public void* has_dev_tools;

		/// <summary>
		/// Returns true (1) if this browser currently has an associated DevTools
		/// browser. Must be called on the browser process UI thread.
		/// </summary>
		[NativeName("has_dev_tools")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern int HasDevTools();

		/// <summary>
		/// void (*)(_cef_browser_host_t* self, _cef_navigation_entry_visitor_t* visitor, int current_only)*
		/// </summary>
		public void* get_navigation_entries;

		/// <summary>
		/// Retrieve a snapshot of current navigation entries as values sent to the
		/// specified visitor. If |current_only| is true (1) only the current
		/// navigation entry will be sent, otherwise all navigation entries will be
		/// sent.
		/// </summary>
		[NativeName("get_navigation_entries")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern void GetNavigationEntries(cef_navigation_entry_visitor_t* visitor, int current_only);

		/// <summary>
		/// void (*)(_cef_browser_host_t* self, int disabled)*
		/// </summary>
		public void* set_mouse_cursor_change_disabled;

		/// <summary>
		/// Set whether mouse cursor change is disabled.
		/// </summary>
		[MethodImpl(MethodImplOptions.ForwardRef)]
		[NativeName("set_mouse_cursor_change_disabled")]
		public unsafe extern void SetMouseCursorChangeDisabled(int disabled);

		/// <summary>
		/// int (*)(_cef_browser_host_t* self)*
		/// </summary>
		public void* is_mouse_cursor_change_disabled;

		/// <summary>
		/// Returns true (1) if mouse cursor change is disabled.
		/// </summary>
		[MethodImpl(MethodImplOptions.ForwardRef)]
		[NativeName("is_mouse_cursor_change_disabled")]
		public unsafe extern int IsMouseCursorChangeDisabled();

		/// <summary>
		/// void (*)(_cef_browser_host_t* self, const cef_string_t* word)*
		/// </summary>
		public void* replace_misspelling;

		/// <summary>
		/// If a misspelled word is currently selected in an editable node calling this
		/// function will replace it with the specified |word|.
		/// </summary>
		[NativeName("replace_misspelling")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern void ReplaceMisspelling([Immutable]cef_string_t* word);

		/// <summary>
		/// void (*)(_cef_browser_host_t* self, const cef_string_t* word)*
		/// </summary>
		public void* add_word_to_dictionary;

		/// <summary>
		/// Add the specified |word| to the spelling dictionary.
		/// </summary>
		[NativeName("add_word_to_dictionary")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern void AddWordToDictionary([Immutable]cef_string_t* word);

		/// <summary>
		/// int (*)(_cef_browser_host_t* self)*
		/// </summary>
		public void* is_window_rendering_disabled;

		/// <summary>
		/// Returns true (1) if window rendering is disabled.
		/// </summary>
		[MethodImpl(MethodImplOptions.ForwardRef)]
		[NativeName("is_window_rendering_disabled")]
		public unsafe extern int IsWindowRenderingDisabled();

		/// <summary>
		/// void (*)(_cef_browser_host_t* self)*
		/// </summary>
		public void* was_resized;

		/// <summary>
		/// Notify the browser that the widget has been resized. The browser will first
		/// call cef_render_handler_t::GetViewRect to get the new size and then call
		/// cef_render_handler_t::OnPaint asynchronously with the updated regions. This
		/// function is only used when window rendering is disabled.
		/// </summary>
		[NativeName("was_resized")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern void WasResized();

		/// <summary>
		/// void (*)(_cef_browser_host_t* self, int hidden)*
		/// </summary>
		public void* was_hidden;

		/// <summary>
		/// Notify the browser that it has been hidden or shown. Layouting and
		/// cef_render_handler_t::OnPaint notification will stop when the browser is
		/// hidden. This function is only used when window rendering is disabled.
		/// </summary>
		[NativeName("was_hidden")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern void WasHidden(int hidden);

		/// <summary>
		/// void (*)(_cef_browser_host_t* self)*
		/// </summary>
		public void* notify_screen_info_changed;

		/// <summary>
		/// Send a notification to the browser that the screen info has changed. The
		/// browser will then call cef_render_handler_t::GetScreenInfo to update the
		/// screen information with the new values. This simulates moving the webview
		/// window from one display to another, or changing the properties of the
		/// current display. This function is only used when window rendering is
		/// disabled.
		/// </summary>
		[MethodImpl(MethodImplOptions.ForwardRef)]
		[NativeName("notify_screen_info_changed")]
		public unsafe extern void NotifyScreenInfoChanged();

		/// <summary>
		/// void (*)(_cef_browser_host_t* self, cef_paint_element_type_t type)*
		/// </summary>
		public void* invalidate;

		/// <summary>
		/// Invalidate the view. The browser will call cef_render_handler_t::OnPaint
		/// asynchronously. This function is only used when window rendering is
		/// disabled.
		/// </summary>
		[NativeName("invalidate")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern void Invalidate(CefPaintElementType type);

		/// <summary>
		/// void (*)(_cef_browser_host_t* self)*
		/// </summary>
		public void* send_external_begin_frame;

		/// <summary>
		/// Issue a BeginFrame request to Chromium.  Only valid when
		/// cef_window_tInfo::external_begin_frame_enabled is set to true (1).
		/// </summary>
		[NativeName("send_external_begin_frame")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern void SendExternalBeginFrame();

		/// <summary>
		/// void (*)(_cef_browser_host_t* self, const const _cef_key_event_t* event)*
		/// </summary>
		public void* send_key_event;

		/// <summary>
		/// Send a key event to the browser.
		/// </summary>
		[NativeName("send_key_event")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern void SendKeyEvent([Immutable]cef_key_event_t* @event);

		/// <summary>
		/// void (*)(_cef_browser_host_t* self, const const _cef_mouse_event_t* event, cef_mouse_button_type_t type, int mouseUp, int clickCount)*
		/// </summary>
		public void* send_mouse_click_event;

		/// <summary>
		/// Send a mouse click event to the browser. The |x| and |y| coordinates are
		/// relative to the upper-left corner of the view.
		/// </summary>
		[NativeName("send_mouse_click_event")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern void SendMouseClickEvent([Immutable]cef_mouse_event_t* @event, CefMouseButtonType type, int mouseUp, int clickCount);

		/// <summary>
		/// void (*)(_cef_browser_host_t* self, const const _cef_mouse_event_t* event, int mouseLeave)*
		/// </summary>
		public void* send_mouse_move_event;

		/// <summary>
		/// Send a mouse move event to the browser. The |x| and |y| coordinates are
		/// relative to the upper-left corner of the view.
		/// </summary>
		[NativeName("send_mouse_move_event")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern void SendMouseMoveEvent([Immutable]cef_mouse_event_t* @event, int mouseLeave);

		/// <summary>
		/// void (*)(_cef_browser_host_t* self, const const _cef_mouse_event_t* event, int deltaX, int deltaY)*
		/// </summary>
		public void* send_mouse_wheel_event;

		/// <summary>
		/// Send a mouse wheel event to the browser. The |x| and |y| coordinates are
		/// relative to the upper-left corner of the view. The |deltaX| and |deltaY|
		/// values represent the movement delta in the X and Y directions respectively.
		/// In order to scroll inside select popups with window rendering disabled
		/// cef_render_handler_t::GetScreenPoint should be implemented properly.
		/// </summary>
		[NativeName("send_mouse_wheel_event")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern void SendMouseWheelEvent([Immutable]cef_mouse_event_t* @event, int deltaX, int deltaY);

		/// <summary>
		/// void (*)(_cef_browser_host_t* self, const const _cef_touch_event_t* event)*
		/// </summary>
		public void* send_touch_event;

		/// <summary>
		/// Send a touch event to the browser for a windowless browser.
		/// </summary>
		[NativeName("send_touch_event")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern void SendTouchEvent([Immutable]cef_touch_event_t* @event);

		/// <summary>
		/// void (*)(_cef_browser_host_t* self, int setFocus)*
		/// </summary>
		public void* send_focus_event;

		/// <summary>
		/// Send a focus event to the browser.
		/// </summary>
		[NativeName("send_focus_event")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern void SendFocusEvent(int setFocus);

		/// <summary>
		/// void (*)(_cef_browser_host_t* self)*
		/// </summary>
		public void* send_capture_lost_event;

		/// <summary>
		/// Send a capture lost event to the browser.
		/// </summary>
		[NativeName("send_capture_lost_event")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern void SendCaptureLostEvent();

		/// <summary>
		/// void (*)(_cef_browser_host_t* self)*
		/// </summary>
		public void* notify_move_or_resize_started;

		/// <summary>
		/// Notify the browser that the window hosting it is about to be moved or
		/// resized. This function is only used on Windows and Linux.
		/// </summary>
		[MethodImpl(MethodImplOptions.ForwardRef)]
		[NativeName("notify_move_or_resize_started")]
		public unsafe extern void NotifyMoveOrResizeStarted();

		/// <summary>
		/// int (*)(_cef_browser_host_t* self)*
		/// </summary>
		public void* get_windowless_frame_rate;

		/// <summary>
		/// Returns the maximum rate in frames per second (fps) that
		/// cef_render_handler_t:: OnPaint will be called for a windowless browser. The
		/// actual fps may be lower if the browser cannot generate frames at the
		/// requested rate. The minimum value is 1 and the maximum value is 60 (default
		/// 30). This function can only be called on the UI thread.
		/// </summary>
		[NativeName("get_windowless_frame_rate")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern int GetWindowlessFrameRate();

		/// <summary>
		/// void (*)(_cef_browser_host_t* self, int frame_rate)*
		/// </summary>
		public void* set_windowless_frame_rate;

		/// <summary>
		/// Set the maximum rate in frames per second (fps) that cef_render_handler_t::
		/// OnPaint will be called for a windowless browser. The actual fps may be
		/// lower if the browser cannot generate frames at the requested rate. The
		/// minimum value is 1 and the maximum value is 60 (default 30). Can also be
		/// set at browser creation via cef_browser_tSettings.windowless_frame_rate.
		/// </summary>
		[NativeName("set_windowless_frame_rate")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern void SetWindowlessFrameRate(int frame_rate);

		/// <summary>
		/// void (*)(_cef_browser_host_t* self, const cef_string_t* text, size_t underlinesCount, const cef_composition_underline_t* underlines, const cef_range_t* replacement_range, const cef_range_t* selection_range)*
		/// </summary>
		public void* ime_set_composition;

		/// <summary>
		/// Begins a new composition or updates the existing composition. Blink has a
		/// special node (a composition node) that allows the input function to change
		/// text without affecting other DOM nodes. |text| is the optional text that
		/// will be inserted into the composition node. |underlines| is an optional set
		/// of ranges that will be underlined in the resulting text.
		/// |replacement_range| is an optional range of the existing text that will be
		/// replaced. |selection_range| is an optional range of the resulting text that
		/// will be selected after insertion or replacement. The |replacement_range|
		/// value is only used on OS X.
		/// This function may be called multiple times as the composition changes. When
		/// the client is done making changes the composition should either be canceled
		/// or completed. To cancel the composition call ImeCancelComposition. To
		/// complete the composition call either ImeCommitText or
		/// ImeFinishComposingText. Completion is usually signaled when:
		/// A. The client receives a WM_IME_COMPOSITION message with a GCS_RESULTSTR
		/// flag (on Windows), or;
		/// B. The client receives a &quot;commit&quot; signal of GtkIMContext (on Linux), or;
		/// C. insertText of NSTextInput is called (on Mac).
		/// This function is only used when window rendering is disabled.
		/// </summary>
		[NativeName("ime_set_composition")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern void ImeSetComposition([Immutable]cef_string_t* text, UIntPtr underlinesCount, [Immutable]cef_composition_underline_t* underlines, [Immutable]cef_range_t* replacement_range, [Immutable]cef_range_t* selection_range);

		/// <summary>
		/// void (*)(_cef_browser_host_t* self, const cef_string_t* text, const cef_range_t* replacement_range, int relative_cursor_pos)*
		/// </summary>
		public void* ime_commit_text;

		/// <summary>
		/// Completes the existing composition by optionally inserting the specified
		/// |text| into the composition node. |replacement_range| is an optional range
		/// of the existing text that will be replaced. |relative_cursor_pos| is where
		/// the cursor will be positioned relative to the current cursor position. See
		/// comments on ImeSetComposition for usage. The |replacement_range| and
		/// |relative_cursor_pos| values are only used on OS X. This function is only
		/// used when window rendering is disabled.
		/// </summary>
		[NativeName("ime_commit_text")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern void ImeCommitText([Immutable]cef_string_t* text, [Immutable]cef_range_t* replacement_range, int relative_cursor_pos);

		/// <summary>
		/// void (*)(_cef_browser_host_t* self, int keep_selection)*
		/// </summary>
		public void* ime_finish_composing_text;

		/// <summary>
		/// Completes the existing composition by applying the current composition node
		/// contents. If |keep_selection| is false (0) the current selection, if any,
		/// will be discarded. See comments on ImeSetComposition for usage. This
		/// function is only used when window rendering is disabled.
		/// </summary>
		[NativeName("ime_finish_composing_text")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern void ImeFinishComposingText(int keep_selection);

		/// <summary>
		/// void (*)(_cef_browser_host_t* self)*
		/// </summary>
		public void* ime_cancel_composition;

		/// <summary>
		/// Cancels the existing composition and discards the composition node contents
		/// without applying them. See comments on ImeSetComposition for usage. This
		/// function is only used when window rendering is disabled.
		/// </summary>
		[NativeName("ime_cancel_composition")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern void ImeCancelComposition();

		/// <summary>
		/// void (*)(_cef_browser_host_t* self, _cef_drag_data_t* drag_data, const const _cef_mouse_event_t* event, cef_drag_operations_mask_t allowed_ops)*
		/// </summary>
		public void* drag_target_drag_enter;

		/// <summary>
		/// Call this function when the user drags the mouse into the web view (before
		/// calling DragTargetDragOver/DragTargetLeave/DragTargetDrop). |drag_data|
		/// should not contain file contents as this type of data is not allowed to be
		/// dragged into the web view. File contents can be removed using
		/// cef_drag_data_t::ResetFileContents (for example, if |drag_data| comes from
		/// cef_render_handler_t::StartDragging). This function is only used when
		/// window rendering is disabled.
		/// </summary>
		[NativeName("drag_target_drag_enter")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern void DragTargetDragEnter(cef_drag_data_t* drag_data, [Immutable]cef_mouse_event_t* @event, CefDragOperationsMask allowed_ops);

		/// <summary>
		/// void (*)(_cef_browser_host_t* self, const const _cef_mouse_event_t* event, cef_drag_operations_mask_t allowed_ops)*
		/// </summary>
		public void* drag_target_drag_over;

		/// <summary>
		/// Call this function each time the mouse is moved across the web view during
		/// a drag operation (after calling DragTargetDragEnter and before calling
		/// DragTargetDragLeave/DragTargetDrop). This function is only used when window
		/// rendering is disabled.
		/// </summary>
		[NativeName("drag_target_drag_over")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern void DragTargetDragOver([Immutable]cef_mouse_event_t* @event, CefDragOperationsMask allowed_ops);

		/// <summary>
		/// void (*)(_cef_browser_host_t* self)*
		/// </summary>
		public void* drag_target_drag_leave;

		/// <summary>
		/// Call this function when the user drags the mouse out of the web view (after
		/// calling DragTargetDragEnter). This function is only used when window
		/// rendering is disabled.
		/// </summary>
		[NativeName("drag_target_drag_leave")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern void DragTargetDragLeave();

		/// <summary>
		/// void (*)(_cef_browser_host_t* self, const const _cef_mouse_event_t* event)*
		/// </summary>
		public void* drag_target_drop;

		/// <summary>
		/// Call this function when the user completes the drag operation by dropping
		/// the object onto the web view (after calling DragTargetDragEnter). The
		/// object being dropped is |drag_data|, given as an argument to the previous
		/// DragTargetDragEnter call. This function is only used when window rendering
		/// is disabled.
		/// </summary>
		[NativeName("drag_target_drop")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern void DragTargetDrop([Immutable]cef_mouse_event_t* @event);

		/// <summary>
		/// void (*)(_cef_browser_host_t* self, int x, int y, cef_drag_operations_mask_t op)*
		/// </summary>
		public void* drag_source_ended_at;

		/// <summary>
		/// Call this function when the drag operation started by a
		/// cef_render_handler_t::StartDragging call has ended either in a drop or by
		/// being cancelled. |x| and |y| are mouse coordinates relative to the upper-
		/// left corner of the view. If the web view is both the drag source and the
		/// drag target then all DragTarget* functions should be called before
		/// DragSource* mthods. This function is only used when window rendering is
		/// disabled.
		/// </summary>
		[NativeName("drag_source_ended_at")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern void DragSourceEndedAt(int x, int y, CefDragOperationsMask op);

		/// <summary>
		/// void (*)(_cef_browser_host_t* self)*
		/// </summary>
		public void* drag_source_system_drag_ended;

		/// <summary>
		/// Call this function when the drag operation started by a
		/// cef_render_handler_t::StartDragging call has completed. This function may
		/// be called immediately without first calling DragSourceEndedAt to cancel a
		/// drag operation. If the web view is both the drag source and the drag target
		/// then all DragTarget* functions should be called before DragSource* mthods.
		/// This function is only used when window rendering is disabled.
		/// </summary>
		[MethodImpl(MethodImplOptions.ForwardRef)]
		[NativeName("drag_source_system_drag_ended")]
		public unsafe extern void DragSourceSystemDragEnded();

		/// <summary>
		/// _cef_navigation_entry_t* (*)(_cef_browser_host_t* self)*
		/// </summary>
		public void* get_visible_navigation_entry;

		/// <summary>
		/// Returns the current visible navigation entry for this browser. This
		/// function can only be called on the UI thread.
		/// </summary>
		[MethodImpl(MethodImplOptions.ForwardRef)]
		[NativeName("get_visible_navigation_entry")]
		public unsafe extern cef_navigation_entry_t* GetVisibleNavigationEntry();

		/// <summary>
		/// void (*)(_cef_browser_host_t* self, cef_state_t accessibility_state)*
		/// </summary>
		public void* set_accessibility_state;

		/// <summary>
		/// Set accessibility state for all frames. |accessibility_state| may be
		/// default, enabled or disabled. If |accessibility_state| is STATE_DEFAULT
		/// then accessibility will be disabled by default and the state may be further
		/// controlled with the &quot;force-renderer-accessibility&quot; and &quot;disable-renderer-
		/// accessibility&quot; command-line switches. If |accessibility_state| is
		/// STATE_ENABLED then accessibility will be enabled. If |accessibility_state|
		/// is STATE_DISABLED then accessibility will be completely disabled.
		/// For windowed browsers accessibility will be enabled in Complete mode (which
		/// corresponds to kAccessibilityModeComplete in Chromium). In this mode all
		/// platform accessibility objects will be created and managed by Chromium&apos;s
		/// internal implementation. The client needs only to detect the screen reader
		/// and call this function appropriately. For example, on macOS the client can
		/// handle the 
		/// &quot;
		/// AXEnhancedUserStructure&quot; accessibility attribute to detect
		/// VoiceOver state changes and on Windows the client can handle WM_GETOBJECT
		/// with OBJID_CLIENT to detect accessibility readers.
		/// For windowless browsers accessibility will be enabled in TreeOnly mode
		/// (which corresponds to kAccessibilityModeWebContentsOnly in Chromium). In
		/// this mode renderer accessibility is enabled, the full tree is computed, and
		/// events are passed to CefAccessibiltyHandler, but platform accessibility
		/// objects are not created. The client may implement platform accessibility
		/// objects using CefAccessibiltyHandler callbacks if desired.
		/// </summary>
		[NativeName("set_accessibility_state")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern void SetAccessibilityState(CefState accessibility_state);

		/// <summary>
		/// void (*)(_cef_browser_host_t* self, int enabled, const cef_size_t* min_size, const cef_size_t* max_size)*
		/// </summary>
		public void* set_auto_resize_enabled;

		/// <summary>
		/// Enable notifications of auto resize via
		/// cef_display_handler_t::OnAutoResize. Notifications are disabled by default.
		/// |min_size| and |max_size| define the range of allowed sizes.
		/// </summary>
		[NativeName("set_auto_resize_enabled")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern void SetAutoResizeEnabled(int enabled, [Immutable]cef_size_t* min_size, [Immutable]cef_size_t* max_size);

		/// <summary>
		/// _cef_extension_t* (*)(_cef_browser_host_t* self)*
		/// </summary>
		public void* get_extension;

		/// <summary>
		/// Returns the extension hosted in this browser or NULL if no extension is
		/// hosted. See cef_request_context_t::LoadExtension for details.
		/// </summary>
		[NativeName("get_extension")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern cef_extension_t* GetExtension();

		/// <summary>
		/// int (*)(_cef_browser_host_t* self)*
		/// </summary>
		public void* is_background_host;

		/// <summary>
		/// Returns true (1) if this browser is hosting an extension background script.
		/// Background hosts do not have a window and are not displayable. See
		/// cef_request_context_t::LoadExtension for details.
		/// </summary>
		[NativeName("is_background_host")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern int IsBackgroundHost();

		/// <summary>
		/// void (*)(_cef_browser_host_t* self, int mute)*
		/// </summary>
		public void* set_audio_muted;

		/// <summary>
		/// Set whether the browser&apos;s audio is muted.
		/// </summary>
		[NativeName("set_audio_muted")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern void SetAudioMuted(int mute);

		/// <summary>
		/// int (*)(_cef_browser_host_t* self)*
		/// </summary>
		public void* is_audio_muted;

		/// <summary>
		/// Returns true (1) if the browser&apos;s audio is muted.  This function can only
		/// be called on the UI thread.
		/// </summary>
		[NativeName("is_audio_muted")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern int IsAudioMuted();
	}
}

