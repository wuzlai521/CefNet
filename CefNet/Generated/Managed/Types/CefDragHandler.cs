﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: Generated/Native/Types/cef_drag_handler_t.cs
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
	/// Implement this structure to handle events related to dragging. The functions
	/// of this structure will be called on the UI thread.
	/// </summary>
	/// <remarks>
	/// Role: Handler
	/// </remarks>
	public unsafe partial class CefDragHandler : CefBaseRefCounted<cef_drag_handler_t>, ICefDragHandlerPrivate
	{
		private static readonly OnDragEnterDelegate fnOnDragEnter = OnDragEnterImpl;

		private static readonly OnDraggableRegionsChangedDelegate fnOnDraggableRegionsChanged = OnDraggableRegionsChangedImpl;

		internal static unsafe CefDragHandler Create(IntPtr instance)
		{
			return new CefDragHandler((cef_drag_handler_t*)instance);
		}

		public CefDragHandler()
		{
			cef_drag_handler_t* self = this.NativeInstance;
			self->on_drag_enter = (void*)Marshal.GetFunctionPointerForDelegate(fnOnDragEnter);
			self->on_draggable_regions_changed = (void*)Marshal.GetFunctionPointerForDelegate(fnOnDraggableRegionsChanged);
		}

		public CefDragHandler(cef_drag_handler_t* instance)
			: base((cef_base_ref_counted_t*)instance)
		{
		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		extern bool ICefDragHandlerPrivate.AvoidOnDragEnter();

		/// <summary>
		/// Called when an external drag event enters the browser window. |dragData|
		/// contains the drag event data and |mask| represents the type of drag
		/// operation. Return false (0) for default drag handling behavior or true (1)
		/// to cancel the drag event.
		/// </summary>
		public unsafe virtual bool OnDragEnter(CefBrowser browser, CefDragData dragData, CefDragOperationsMask mask)
		{
			return default;
		}

		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate int OnDragEnterDelegate(cef_drag_handler_t* self, cef_browser_t* browser, cef_drag_data_t* dragData, CefDragOperationsMask mask);

		// int (*)(_cef_drag_handler_t* self, _cef_browser_t* browser, _cef_drag_data_t* dragData, cef_drag_operations_mask_t mask)*
		private static unsafe int OnDragEnterImpl(cef_drag_handler_t* self, cef_browser_t* browser, cef_drag_data_t* dragData, CefDragOperationsMask mask)
		{
			var instance = GetInstance((IntPtr)self) as CefDragHandler;
			if (instance == null || ((ICefDragHandlerPrivate)instance).AvoidOnDragEnter())
			{
				ReleaseIfNonNull((cef_base_ref_counted_t*)browser);
				ReleaseIfNonNull((cef_base_ref_counted_t*)dragData);
				return default;
			}
			return instance.OnDragEnter(CefBrowser.Wrap(CefBrowser.Create, browser), CefDragData.Wrap(CefDragData.Create, dragData), mask) ? 1 : 0;
		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		extern bool ICefDragHandlerPrivate.AvoidOnDraggableRegionsChanged();

		/// <summary>
		/// Called whenever draggable regions for the browser window change. These can
		/// be specified using the &apos;-webkit-app-region: drag/no-drag&apos; CSS-property. If
		/// draggable regions are never defined in a document this function will also
		/// never be called. If the last draggable region is removed from a document
		/// this function will be called with an NULL vector.
		/// </summary>
		public unsafe virtual void OnDraggableRegionsChanged(CefBrowser browser, CefFrame frame, CefDraggableRegion[] regions)
		{
		}

		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate void OnDraggableRegionsChangedDelegate(cef_drag_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, UIntPtr regionsCount, cef_draggable_region_t* regions);

		// void (*)(_cef_drag_handler_t* self, _cef_browser_t* browser, _cef_frame_t* frame, size_t regionsCount, const cef_draggable_region_t* regions)*
		private static unsafe void OnDraggableRegionsChangedImpl(cef_drag_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, UIntPtr regionsCount, cef_draggable_region_t* regions)
		{
			var instance = GetInstance((IntPtr)self) as CefDragHandler;
			if (instance == null || ((ICefDragHandlerPrivate)instance).AvoidOnDraggableRegionsChanged())
			{
				ReleaseIfNonNull((cef_base_ref_counted_t*)browser);
				ReleaseIfNonNull((cef_base_ref_counted_t*)frame);
				return;
			}
			CefDraggableRegion[] obj_regions = new CefDraggableRegion[(int)regionsCount];
			for (int i = 0; i < obj_regions.Length; i++)
			{
				obj_regions[i] = *(CefDraggableRegion*)(regions + i);
			}
			instance.OnDraggableRegionsChanged(CefBrowser.Wrap(CefBrowser.Create, browser), CefFrame.Wrap(CefFrame.Create, frame), obj_regions);
		}
	}
}
