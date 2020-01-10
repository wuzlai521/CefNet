﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: include/capi/cef_print_handler_capi.h
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
	/// Implement this structure to handle printing on Linux. Each browser will have
	/// only one print job in progress at a time. The functions of this structure
	/// will be called on the browser process UI thread.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct cef_print_handler_t
	{
		/// <summary>
		/// Base structure.
		/// </summary>
		public cef_base_ref_counted_t @base;

		/// <summary>
		/// void (*)(_cef_print_handler_t* self, _cef_browser_t* browser)*
		/// </summary>
		public void* on_print_start;

		/// <summary>
		/// Called when printing has started for the specified |browser|. This function
		/// will be called before the other OnPrint*() functions and irrespective of
		/// how printing was initiated (e.g. cef_browser_host_t::print(), JavaScript
		/// window.print() or PDF extension print button).
		/// </summary>
		[NativeName("on_print_start")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern void OnPrintStart(cef_browser_t* browser);

		/// <summary>
		/// void (*)(_cef_print_handler_t* self, _cef_browser_t* browser, _cef_print_settings_t* settings, int get_defaults)*
		/// </summary>
		public void* on_print_settings;

		/// <summary>
		/// Synchronize |settings| with client state. If |get_defaults| is true (1)
		/// then populate |settings| with the default print settings. Do not keep a
		/// reference to |settings| outside of this callback.
		/// </summary>
		[NativeName("on_print_settings")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern void OnPrintSettings(cef_browser_t* browser, cef_print_settings_t* settings, int get_defaults);

		/// <summary>
		/// int (*)(_cef_print_handler_t* self, _cef_browser_t* browser, int has_selection, _cef_print_dialog_callback_t* callback)*
		/// </summary>
		public void* on_print_dialog;

		/// <summary>
		/// Show the print dialog. Execute |callback| once the dialog is dismissed.
		/// Return true (1) if the dialog will be displayed or false (0) to cancel the
		/// printing immediately.
		/// </summary>
		[NativeName("on_print_dialog")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern int OnPrintDialog(cef_browser_t* browser, int has_selection, cef_print_dialog_callback_t* callback);

		/// <summary>
		/// int (*)(_cef_print_handler_t* self, _cef_browser_t* browser, const cef_string_t* document_name, const cef_string_t* pdf_file_path, _cef_print_job_callback_t* callback)*
		/// </summary>
		public void* on_print_job;

		/// <summary>
		/// Send the print job to the printer. Execute |callback| once the job is
		/// completed. Return true (1) if the job will proceed or false (0) to cancel
		/// the job immediately.
		/// </summary>
		[NativeName("on_print_job")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern int OnPrintJob(cef_browser_t* browser, [Immutable]cef_string_t* document_name, [Immutable]cef_string_t* pdf_file_path, cef_print_job_callback_t* callback);

		/// <summary>
		/// void (*)(_cef_print_handler_t* self, _cef_browser_t* browser)*
		/// </summary>
		public void* on_print_reset;

		/// <summary>
		/// Reset client state related to printing.
		/// </summary>
		[NativeName("on_print_reset")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern void OnPrintReset(cef_browser_t* browser);

		/// <summary>
		/// cef_size_t (*)(_cef_print_handler_t* self, int device_units_per_inch)*
		/// </summary>
		public void* get_pdf_paper_size;

		/// <summary>
		/// Return the PDF paper size in device units. Used in combination with
		/// cef_browser_host_t::print_to_pdf().
		/// </summary>
		[NativeName("get_pdf_paper_size")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern cef_size_t GetPdfPaperSize(int device_units_per_inch);
	}
}

