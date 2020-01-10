﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: Generated/Native/Types/cef_render_process_handler_t.cs
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
	/// Structure used to implement render process callbacks. The functions of this
	/// structure will be called on the render process main thread (TID_RENDERER)
	/// unless otherwise indicated.
	/// </summary>
	/// <remarks>
	/// Role: Handler
	/// </remarks>
	public unsafe partial class CefRenderProcessHandler : CefBaseRefCounted<cef_render_process_handler_t>, ICefRenderProcessHandlerPrivate
	{
		private static readonly OnRenderThreadCreatedDelegate fnOnRenderThreadCreated = OnRenderThreadCreatedImpl;

		private static readonly OnWebKitInitializedDelegate fnOnWebKitInitialized = OnWebKitInitializedImpl;

		private static readonly OnBrowserCreatedDelegate fnOnBrowserCreated = OnBrowserCreatedImpl;

		private static readonly OnBrowserDestroyedDelegate fnOnBrowserDestroyed = OnBrowserDestroyedImpl;

		private static readonly GetLoadHandlerDelegate fnGetLoadHandler = GetLoadHandlerImpl;

		private static readonly OnContextCreatedDelegate fnOnContextCreated = OnContextCreatedImpl;

		private static readonly OnContextReleasedDelegate fnOnContextReleased = OnContextReleasedImpl;

		private static readonly OnUncaughtExceptionDelegate fnOnUncaughtException = OnUncaughtExceptionImpl;

		private static readonly OnFocusedNodeChangedDelegate fnOnFocusedNodeChanged = OnFocusedNodeChangedImpl;

		private static readonly OnProcessMessageReceivedDelegate fnOnProcessMessageReceived = OnProcessMessageReceivedImpl;

		internal static unsafe CefRenderProcessHandler Create(IntPtr instance)
		{
			return new CefRenderProcessHandler((cef_render_process_handler_t*)instance);
		}

		public CefRenderProcessHandler()
		{
			cef_render_process_handler_t* self = this.NativeInstance;
			self->on_render_thread_created = (void*)Marshal.GetFunctionPointerForDelegate(fnOnRenderThreadCreated);
			self->on_web_kit_initialized = (void*)Marshal.GetFunctionPointerForDelegate(fnOnWebKitInitialized);
			self->on_browser_created = (void*)Marshal.GetFunctionPointerForDelegate(fnOnBrowserCreated);
			self->on_browser_destroyed = (void*)Marshal.GetFunctionPointerForDelegate(fnOnBrowserDestroyed);
			self->get_load_handler = (void*)Marshal.GetFunctionPointerForDelegate(fnGetLoadHandler);
			self->on_context_created = (void*)Marshal.GetFunctionPointerForDelegate(fnOnContextCreated);
			self->on_context_released = (void*)Marshal.GetFunctionPointerForDelegate(fnOnContextReleased);
			self->on_uncaught_exception = (void*)Marshal.GetFunctionPointerForDelegate(fnOnUncaughtException);
			self->on_focused_node_changed = (void*)Marshal.GetFunctionPointerForDelegate(fnOnFocusedNodeChanged);
			self->on_process_message_received = (void*)Marshal.GetFunctionPointerForDelegate(fnOnProcessMessageReceived);
		}

		public CefRenderProcessHandler(cef_render_process_handler_t* instance)
			: base((cef_base_ref_counted_t*)instance)
		{
		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		extern bool ICefRenderProcessHandlerPrivate.AvoidOnRenderThreadCreated();

		/// <summary>
		/// Called after the render process main thread has been created. |extra_info|
		/// is a read-only value originating from
		/// cef_browser_process_handler_t::on_render_process_thread_created(). Do not
		/// keep a reference to |extra_info| outside of this function.
		/// </summary>
		public unsafe virtual void OnRenderThreadCreated(CefListValue extraInfo)
		{
		}

		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate void OnRenderThreadCreatedDelegate(cef_render_process_handler_t* self, cef_list_value_t* extra_info);

		// void (*)(_cef_render_process_handler_t* self, _cef_list_value_t* extra_info)*
		private static unsafe void OnRenderThreadCreatedImpl(cef_render_process_handler_t* self, cef_list_value_t* extra_info)
		{
			var instance = GetInstance((IntPtr)self) as CefRenderProcessHandler;
			if (instance == null || ((ICefRenderProcessHandlerPrivate)instance).AvoidOnRenderThreadCreated())
			{
				ReleaseIfNonNull((cef_base_ref_counted_t*)extra_info);
				return;
			}
			instance.OnRenderThreadCreated(CefListValue.Wrap(CefListValue.Create, extra_info));
		}

		/// <summary>
		/// Called after WebKit has been initialized.
		/// </summary>
		public unsafe virtual void OnWebKitInitialized()
		{
		}

		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate void OnWebKitInitializedDelegate(cef_render_process_handler_t* self);

		// void (*)(_cef_render_process_handler_t* self)*
		private static unsafe void OnWebKitInitializedImpl(cef_render_process_handler_t* self)
		{
			var instance = GetInstance((IntPtr)self) as CefRenderProcessHandler;
			if (instance == null)
			{
				return;
			}
			instance.OnWebKitInitialized();
		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		extern bool ICefRenderProcessHandlerPrivate.AvoidOnBrowserCreated();

		/// <summary>
		/// Called after a browser has been created. When browsing cross-origin a new
		/// browser will be created before the old browser with the same identifier is
		/// destroyed. |extra_info| is a read-only value originating from
		/// cef_browser_host_t::cef_browser_host_create_browser(),
		/// cef_browser_host_t::cef_browser_host_create_browser_sync(),
		/// cef_life_span_handler_t::on_before_popup() or
		/// cef_browser_view_t::cef_browser_view_create().
		/// </summary>
		public unsafe virtual void OnBrowserCreated(CefBrowser browser, CefDictionaryValue extraInfo)
		{
		}

		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate void OnBrowserCreatedDelegate(cef_render_process_handler_t* self, cef_browser_t* browser, cef_dictionary_value_t* extra_info);

		// void (*)(_cef_render_process_handler_t* self, _cef_browser_t* browser, _cef_dictionary_value_t* extra_info)*
		private static unsafe void OnBrowserCreatedImpl(cef_render_process_handler_t* self, cef_browser_t* browser, cef_dictionary_value_t* extra_info)
		{
			var instance = GetInstance((IntPtr)self) as CefRenderProcessHandler;
			if (instance == null || ((ICefRenderProcessHandlerPrivate)instance).AvoidOnBrowserCreated())
			{
				ReleaseIfNonNull((cef_base_ref_counted_t*)browser);
				ReleaseIfNonNull((cef_base_ref_counted_t*)extra_info);
				return;
			}
			instance.OnBrowserCreated(CefBrowser.Wrap(CefBrowser.Create, browser), CefDictionaryValue.Wrap(CefDictionaryValue.Create, extra_info));
		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		extern bool ICefRenderProcessHandlerPrivate.AvoidOnBrowserDestroyed();

		/// <summary>
		/// Called before a browser is destroyed.
		/// </summary>
		public unsafe virtual void OnBrowserDestroyed(CefBrowser browser)
		{
		}

		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate void OnBrowserDestroyedDelegate(cef_render_process_handler_t* self, cef_browser_t* browser);

		// void (*)(_cef_render_process_handler_t* self, _cef_browser_t* browser)*
		private static unsafe void OnBrowserDestroyedImpl(cef_render_process_handler_t* self, cef_browser_t* browser)
		{
			var instance = GetInstance((IntPtr)self) as CefRenderProcessHandler;
			if (instance == null || ((ICefRenderProcessHandlerPrivate)instance).AvoidOnBrowserDestroyed())
			{
				ReleaseIfNonNull((cef_base_ref_counted_t*)browser);
				return;
			}
			instance.OnBrowserDestroyed(CefBrowser.Wrap(CefBrowser.Create, browser));
		}

		/// <summary>
		/// Return the handler for browser load status events.
		/// </summary>
		public unsafe virtual CefLoadHandler GetLoadHandler()
		{
			return default;
		}

		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate cef_load_handler_t* GetLoadHandlerDelegate(cef_render_process_handler_t* self);

		// _cef_load_handler_t* (*)(_cef_render_process_handler_t* self)*
		private static unsafe cef_load_handler_t* GetLoadHandlerImpl(cef_render_process_handler_t* self)
		{
			var instance = GetInstance((IntPtr)self) as CefRenderProcessHandler;
			if (instance == null)
			{
				return default;
			}
			CefLoadHandler rv = instance.GetLoadHandler();
			if (rv == null)
				return null;
			return (rv != null) ? rv.GetNativeInstance() : null;
		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		extern bool ICefRenderProcessHandlerPrivate.AvoidOnContextCreated();

		/// <summary>
		/// Called immediately after the V8 context for a frame has been created. To
		/// retrieve the JavaScript &apos;window&apos; object use the
		/// cef_v8context_t::get_global() function. V8 handles can only be accessed
		/// from the thread on which they are created. A task runner for posting tasks
		/// on the associated thread can be retrieved via the
		/// cef_v8context_t::get_task_runner() function.
		/// </summary>
		public unsafe virtual void OnContextCreated(CefBrowser browser, CefFrame frame, CefV8Context context)
		{
		}

		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate void OnContextCreatedDelegate(cef_render_process_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, cef_v8context_t* context);

		// void (*)(_cef_render_process_handler_t* self, _cef_browser_t* browser, _cef_frame_t* frame, _cef_v8context_t* context)*
		private static unsafe void OnContextCreatedImpl(cef_render_process_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, cef_v8context_t* context)
		{
			var instance = GetInstance((IntPtr)self) as CefRenderProcessHandler;
			if (instance == null || ((ICefRenderProcessHandlerPrivate)instance).AvoidOnContextCreated())
			{
				ReleaseIfNonNull((cef_base_ref_counted_t*)browser);
				ReleaseIfNonNull((cef_base_ref_counted_t*)frame);
				ReleaseIfNonNull((cef_base_ref_counted_t*)context);
				return;
			}
			instance.OnContextCreated(CefBrowser.Wrap(CefBrowser.Create, browser), CefFrame.Wrap(CefFrame.Create, frame), CefV8Context.Wrap(CefV8Context.Create, context));
		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		extern bool ICefRenderProcessHandlerPrivate.AvoidOnContextReleased();

		/// <summary>
		/// Called immediately before the V8 context for a frame is released. No
		/// references to the context should be kept after this function is called.
		/// </summary>
		public unsafe virtual void OnContextReleased(CefBrowser browser, CefFrame frame, CefV8Context context)
		{
		}

		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate void OnContextReleasedDelegate(cef_render_process_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, cef_v8context_t* context);

		// void (*)(_cef_render_process_handler_t* self, _cef_browser_t* browser, _cef_frame_t* frame, _cef_v8context_t* context)*
		private static unsafe void OnContextReleasedImpl(cef_render_process_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, cef_v8context_t* context)
		{
			var instance = GetInstance((IntPtr)self) as CefRenderProcessHandler;
			if (instance == null || ((ICefRenderProcessHandlerPrivate)instance).AvoidOnContextReleased())
			{
				ReleaseIfNonNull((cef_base_ref_counted_t*)browser);
				ReleaseIfNonNull((cef_base_ref_counted_t*)frame);
				ReleaseIfNonNull((cef_base_ref_counted_t*)context);
				return;
			}
			instance.OnContextReleased(CefBrowser.Wrap(CefBrowser.Create, browser), CefFrame.Wrap(CefFrame.Create, frame), CefV8Context.Wrap(CefV8Context.Create, context));
		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		extern bool ICefRenderProcessHandlerPrivate.AvoidOnUncaughtException();

		/// <summary>
		/// Called for global uncaught exceptions in a frame. Execution of this
		/// callback is disabled by default. To enable set
		/// CefSettings.uncaught_exception_stack_size &gt; 0.
		/// </summary>
		public unsafe virtual void OnUncaughtException(CefBrowser browser, CefFrame frame, CefV8Context context, CefV8Exception exception, CefV8StackTrace stackTrace)
		{
		}

		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate void OnUncaughtExceptionDelegate(cef_render_process_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, cef_v8context_t* context, cef_v8exception_t* exception, cef_v8stack_trace_t* stackTrace);

		// void (*)(_cef_render_process_handler_t* self, _cef_browser_t* browser, _cef_frame_t* frame, _cef_v8context_t* context, _cef_v8exception_t* exception, _cef_v8stack_trace_t* stackTrace)*
		private static unsafe void OnUncaughtExceptionImpl(cef_render_process_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, cef_v8context_t* context, cef_v8exception_t* exception, cef_v8stack_trace_t* stackTrace)
		{
			var instance = GetInstance((IntPtr)self) as CefRenderProcessHandler;
			if (instance == null || ((ICefRenderProcessHandlerPrivate)instance).AvoidOnUncaughtException())
			{
				ReleaseIfNonNull((cef_base_ref_counted_t*)browser);
				ReleaseIfNonNull((cef_base_ref_counted_t*)frame);
				ReleaseIfNonNull((cef_base_ref_counted_t*)context);
				ReleaseIfNonNull((cef_base_ref_counted_t*)exception);
				ReleaseIfNonNull((cef_base_ref_counted_t*)stackTrace);
				return;
			}
			instance.OnUncaughtException(CefBrowser.Wrap(CefBrowser.Create, browser), CefFrame.Wrap(CefFrame.Create, frame), CefV8Context.Wrap(CefV8Context.Create, context), CefV8Exception.Wrap(CefV8Exception.Create, exception), CefV8StackTrace.Wrap(CefV8StackTrace.Create, stackTrace));
		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		extern bool ICefRenderProcessHandlerPrivate.AvoidOnFocusedNodeChanged();

		/// <summary>
		/// Called when a new node in the the browser gets focus. The |node| value may
		/// be NULL if no specific node has gained focus. The node object passed to
		/// this function represents a snapshot of the DOM at the time this function is
		/// executed. DOM objects are only valid for the scope of this function. Do not
		/// keep references to or attempt to access any DOM objects outside the scope
		/// of this function.
		/// </summary>
		public unsafe virtual void OnFocusedNodeChanged(CefBrowser browser, CefFrame frame, CefDOMNode node)
		{
		}

		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate void OnFocusedNodeChangedDelegate(cef_render_process_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, cef_domnode_t* node);

		// void (*)(_cef_render_process_handler_t* self, _cef_browser_t* browser, _cef_frame_t* frame, _cef_domnode_t* node)*
		private static unsafe void OnFocusedNodeChangedImpl(cef_render_process_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, cef_domnode_t* node)
		{
			var instance = GetInstance((IntPtr)self) as CefRenderProcessHandler;
			if (instance == null || ((ICefRenderProcessHandlerPrivate)instance).AvoidOnFocusedNodeChanged())
			{
				ReleaseIfNonNull((cef_base_ref_counted_t*)browser);
				ReleaseIfNonNull((cef_base_ref_counted_t*)frame);
				ReleaseIfNonNull((cef_base_ref_counted_t*)node);
				return;
			}
			instance.OnFocusedNodeChanged(CefBrowser.Wrap(CefBrowser.Create, browser), CefFrame.Wrap(CefFrame.Create, frame), CefDOMNode.Wrap(CefDOMNode.Create, node));
		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		extern bool ICefRenderProcessHandlerPrivate.AvoidOnProcessMessageReceived();

		/// <summary>
		/// Called when a new message is received from a different process. Return true
		/// (1) if the message was handled or false (0) otherwise. Do not keep a
		/// reference to or attempt to access the message outside of this callback.
		/// </summary>
		public unsafe virtual bool OnProcessMessageReceived(CefBrowser browser, CefFrame frame, CefProcessId sourceProcess, CefProcessMessage message)
		{
			return default;
		}

		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate int OnProcessMessageReceivedDelegate(cef_render_process_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, CefProcessId source_process, cef_process_message_t* message);

		// int (*)(_cef_render_process_handler_t* self, _cef_browser_t* browser, _cef_frame_t* frame, cef_process_id_t source_process, _cef_process_message_t* message)*
		private static unsafe int OnProcessMessageReceivedImpl(cef_render_process_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, CefProcessId source_process, cef_process_message_t* message)
		{
			var instance = GetInstance((IntPtr)self) as CefRenderProcessHandler;
			if (instance == null || ((ICefRenderProcessHandlerPrivate)instance).AvoidOnProcessMessageReceived())
			{
				ReleaseIfNonNull((cef_base_ref_counted_t*)browser);
				ReleaseIfNonNull((cef_base_ref_counted_t*)frame);
				ReleaseIfNonNull((cef_base_ref_counted_t*)message);
				return default;
			}
			return instance.OnProcessMessageReceived(CefBrowser.Wrap(CefBrowser.Create, browser), CefFrame.Wrap(CefFrame.Create, frame), source_process, CefProcessMessage.Wrap(CefProcessMessage.Create, message)) ? 1 : 0;
		}
	}
}
