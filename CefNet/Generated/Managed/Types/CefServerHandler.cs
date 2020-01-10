﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: Generated/Native/Types/cef_server_handler_t.cs
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
	/// Implement this structure to handle HTTP server requests. A new thread will be
	/// created for each cef_server_t::CreateServer call (the &quot;dedicated server
	/// thread&quot;), and the functions of this structure will be called on that thread.
	/// It is therefore recommended to use a different cef_server_handler_t instance
	/// for each cef_server_t::CreateServer call to avoid thread safety issues in the
	/// cef_server_handler_t implementation.
	/// </summary>
	/// <remarks>
	/// Role: Handler
	/// </remarks>
	public unsafe partial class CefServerHandler : CefBaseRefCounted<cef_server_handler_t>, ICefServerHandlerPrivate
	{
		private static readonly OnServerCreatedDelegate fnOnServerCreated = OnServerCreatedImpl;

		private static readonly OnServerDestroyedDelegate fnOnServerDestroyed = OnServerDestroyedImpl;

		private static readonly OnClientConnectedDelegate fnOnClientConnected = OnClientConnectedImpl;

		private static readonly OnClientDisconnectedDelegate fnOnClientDisconnected = OnClientDisconnectedImpl;

		private static readonly OnHttpRequestDelegate fnOnHttpRequest = OnHttpRequestImpl;

		private static readonly OnWebSocketRequestDelegate fnOnWebSocketRequest = OnWebSocketRequestImpl;

		private static readonly OnWebSocketConnectedDelegate fnOnWebSocketConnected = OnWebSocketConnectedImpl;

		private static readonly OnWebSocketMessageDelegate fnOnWebSocketMessage = OnWebSocketMessageImpl;

		internal static unsafe CefServerHandler Create(IntPtr instance)
		{
			return new CefServerHandler((cef_server_handler_t*)instance);
		}

		public CefServerHandler()
		{
			cef_server_handler_t* self = this.NativeInstance;
			self->on_server_created = (void*)Marshal.GetFunctionPointerForDelegate(fnOnServerCreated);
			self->on_server_destroyed = (void*)Marshal.GetFunctionPointerForDelegate(fnOnServerDestroyed);
			self->on_client_connected = (void*)Marshal.GetFunctionPointerForDelegate(fnOnClientConnected);
			self->on_client_disconnected = (void*)Marshal.GetFunctionPointerForDelegate(fnOnClientDisconnected);
			self->on_http_request = (void*)Marshal.GetFunctionPointerForDelegate(fnOnHttpRequest);
			self->on_web_socket_request = (void*)Marshal.GetFunctionPointerForDelegate(fnOnWebSocketRequest);
			self->on_web_socket_connected = (void*)Marshal.GetFunctionPointerForDelegate(fnOnWebSocketConnected);
			self->on_web_socket_message = (void*)Marshal.GetFunctionPointerForDelegate(fnOnWebSocketMessage);
		}

		public CefServerHandler(cef_server_handler_t* instance)
			: base((cef_base_ref_counted_t*)instance)
		{
		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		extern bool ICefServerHandlerPrivate.AvoidOnServerCreated();

		/// <summary>
		/// Called when |server| is created. If the server was started successfully
		/// then cef_server_t::IsRunning will return true (1). The server will continue
		/// running until cef_server_t::Shutdown is called, after which time
		/// OnServerDestroyed will be called. If the server failed to start then
		/// OnServerDestroyed will be called immediately after this function returns.
		/// </summary>
		public unsafe virtual void OnServerCreated(CefServer server)
		{
		}

		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate void OnServerCreatedDelegate(cef_server_handler_t* self, cef_server_t* server);

		// void (*)(_cef_server_handler_t* self, _cef_server_t* server)*
		private static unsafe void OnServerCreatedImpl(cef_server_handler_t* self, cef_server_t* server)
		{
			var instance = GetInstance((IntPtr)self) as CefServerHandler;
			if (instance == null || ((ICefServerHandlerPrivate)instance).AvoidOnServerCreated())
			{
				ReleaseIfNonNull((cef_base_ref_counted_t*)server);
				return;
			}
			instance.OnServerCreated(CefServer.Wrap(CefServer.Create, server));
		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		extern bool ICefServerHandlerPrivate.AvoidOnServerDestroyed();

		/// <summary>
		/// Called when |server| is destroyed. The server thread will be stopped after
		/// this function returns. The client should release any references to |server|
		/// when this function is called. See OnServerCreated documentation for a
		/// description of server lifespan.
		/// </summary>
		public unsafe virtual void OnServerDestroyed(CefServer server)
		{
		}

		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate void OnServerDestroyedDelegate(cef_server_handler_t* self, cef_server_t* server);

		// void (*)(_cef_server_handler_t* self, _cef_server_t* server)*
		private static unsafe void OnServerDestroyedImpl(cef_server_handler_t* self, cef_server_t* server)
		{
			var instance = GetInstance((IntPtr)self) as CefServerHandler;
			if (instance == null || ((ICefServerHandlerPrivate)instance).AvoidOnServerDestroyed())
			{
				ReleaseIfNonNull((cef_base_ref_counted_t*)server);
				return;
			}
			instance.OnServerDestroyed(CefServer.Wrap(CefServer.Create, server));
		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		extern bool ICefServerHandlerPrivate.AvoidOnClientConnected();

		/// <summary>
		/// Called when a client connects to |server|. |connection_id| uniquely
		/// identifies the connection. Each call to this function will have a matching
		/// call to OnClientDisconnected.
		/// </summary>
		public unsafe virtual void OnClientConnected(CefServer server, int connectionId)
		{
		}

		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate void OnClientConnectedDelegate(cef_server_handler_t* self, cef_server_t* server, int connection_id);

		// void (*)(_cef_server_handler_t* self, _cef_server_t* server, int connection_id)*
		private static unsafe void OnClientConnectedImpl(cef_server_handler_t* self, cef_server_t* server, int connection_id)
		{
			var instance = GetInstance((IntPtr)self) as CefServerHandler;
			if (instance == null || ((ICefServerHandlerPrivate)instance).AvoidOnClientConnected())
			{
				ReleaseIfNonNull((cef_base_ref_counted_t*)server);
				return;
			}
			instance.OnClientConnected(CefServer.Wrap(CefServer.Create, server), connection_id);
		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		extern bool ICefServerHandlerPrivate.AvoidOnClientDisconnected();

		/// <summary>
		/// Called when a client disconnects from |server|. |connection_id| uniquely
		/// identifies the connection. The client should release any data associated
		/// with |connection_id| when this function is called and |connection_id|
		/// should no longer be passed to cef_server_t functions. Disconnects can
		/// originate from either the client or the server. For example, the server
		/// will disconnect automatically after a cef_server_t::SendHttpXXXResponse
		/// function is called.
		/// </summary>
		public unsafe virtual void OnClientDisconnected(CefServer server, int connectionId)
		{
		}

		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate void OnClientDisconnectedDelegate(cef_server_handler_t* self, cef_server_t* server, int connection_id);

		// void (*)(_cef_server_handler_t* self, _cef_server_t* server, int connection_id)*
		private static unsafe void OnClientDisconnectedImpl(cef_server_handler_t* self, cef_server_t* server, int connection_id)
		{
			var instance = GetInstance((IntPtr)self) as CefServerHandler;
			if (instance == null || ((ICefServerHandlerPrivate)instance).AvoidOnClientDisconnected())
			{
				ReleaseIfNonNull((cef_base_ref_counted_t*)server);
				return;
			}
			instance.OnClientDisconnected(CefServer.Wrap(CefServer.Create, server), connection_id);
		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		extern bool ICefServerHandlerPrivate.AvoidOnHttpRequest();

		/// <summary>
		/// Called when |server| receives an HTTP request. |connection_id| uniquely
		/// identifies the connection, |client_address| is the requesting IPv4 or IPv6
		/// client address including port number, and |request| contains the request
		/// contents (URL, function, headers and optional POST data). Call cef_server_t
		/// functions either synchronously or asynchronusly to send a response.
		/// </summary>
		public unsafe virtual void OnHttpRequest(CefServer server, int connectionId, string clientAddress, CefRequest request)
		{
		}

		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate void OnHttpRequestDelegate(cef_server_handler_t* self, cef_server_t* server, int connection_id, cef_string_t* client_address, cef_request_t* request);

		// void (*)(_cef_server_handler_t* self, _cef_server_t* server, int connection_id, const cef_string_t* client_address, _cef_request_t* request)*
		private static unsafe void OnHttpRequestImpl(cef_server_handler_t* self, cef_server_t* server, int connection_id, cef_string_t* client_address, cef_request_t* request)
		{
			var instance = GetInstance((IntPtr)self) as CefServerHandler;
			if (instance == null || ((ICefServerHandlerPrivate)instance).AvoidOnHttpRequest())
			{
				ReleaseIfNonNull((cef_base_ref_counted_t*)server);
				ReleaseIfNonNull((cef_base_ref_counted_t*)request);
				return;
			}
			instance.OnHttpRequest(CefServer.Wrap(CefServer.Create, server), connection_id, CefString.Read(client_address), CefRequest.Wrap(CefRequest.Create, request));
		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		extern bool ICefServerHandlerPrivate.AvoidOnWebSocketRequest();

		/// <summary>
		/// Called when |server| receives a WebSocket request. |connection_id| uniquely
		/// identifies the connection, |client_address| is the requesting IPv4 or IPv6
		/// client address including port number, and |request| contains the request
		/// contents (URL, function, headers and optional POST data). Execute
		/// |callback| either synchronously or asynchronously to accept or decline the
		/// WebSocket connection. If the request is accepted then OnWebSocketConnected
		/// will be called after the WebSocket has connected and incoming messages will
		/// be delivered to the OnWebSocketMessage callback. If the request is declined
		/// then the client will be disconnected and OnClientDisconnected will be
		/// called. Call the cef_server_t::SendWebSocketMessage function after
		/// receiving the OnWebSocketConnected callback to respond with WebSocket
		/// messages.
		/// </summary>
		public unsafe virtual void OnWebSocketRequest(CefServer server, int connectionId, string clientAddress, CefRequest request, CefCallback callback)
		{
		}

		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate void OnWebSocketRequestDelegate(cef_server_handler_t* self, cef_server_t* server, int connection_id, cef_string_t* client_address, cef_request_t* request, cef_callback_t* callback);

		// void (*)(_cef_server_handler_t* self, _cef_server_t* server, int connection_id, const cef_string_t* client_address, _cef_request_t* request, _cef_callback_t* callback)*
		private static unsafe void OnWebSocketRequestImpl(cef_server_handler_t* self, cef_server_t* server, int connection_id, cef_string_t* client_address, cef_request_t* request, cef_callback_t* callback)
		{
			var instance = GetInstance((IntPtr)self) as CefServerHandler;
			if (instance == null || ((ICefServerHandlerPrivate)instance).AvoidOnWebSocketRequest())
			{
				ReleaseIfNonNull((cef_base_ref_counted_t*)server);
				ReleaseIfNonNull((cef_base_ref_counted_t*)request);
				ReleaseIfNonNull((cef_base_ref_counted_t*)callback);
				return;
			}
			instance.OnWebSocketRequest(CefServer.Wrap(CefServer.Create, server), connection_id, CefString.Read(client_address), CefRequest.Wrap(CefRequest.Create, request), CefCallback.Wrap(CefCallback.Create, callback));
		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		extern bool ICefServerHandlerPrivate.AvoidOnWebSocketConnected();

		/// <summary>
		/// Called after the client has accepted the WebSocket connection for |server|
		/// and |connection_id| via the OnWebSocketRequest callback. See
		/// OnWebSocketRequest documentation for intended usage.
		/// </summary>
		public unsafe virtual void OnWebSocketConnected(CefServer server, int connectionId)
		{
		}

		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate void OnWebSocketConnectedDelegate(cef_server_handler_t* self, cef_server_t* server, int connection_id);

		// void (*)(_cef_server_handler_t* self, _cef_server_t* server, int connection_id)*
		private static unsafe void OnWebSocketConnectedImpl(cef_server_handler_t* self, cef_server_t* server, int connection_id)
		{
			var instance = GetInstance((IntPtr)self) as CefServerHandler;
			if (instance == null || ((ICefServerHandlerPrivate)instance).AvoidOnWebSocketConnected())
			{
				ReleaseIfNonNull((cef_base_ref_counted_t*)server);
				return;
			}
			instance.OnWebSocketConnected(CefServer.Wrap(CefServer.Create, server), connection_id);
		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		extern bool ICefServerHandlerPrivate.AvoidOnWebSocketMessage();

		/// <summary>
		/// Called when |server| receives an WebSocket message. |connection_id|
		/// uniquely identifies the connection, |data| is the message content and
		/// |data_size| is the size of |data| in bytes. Do not keep a reference to
		/// |data| outside of this function. See OnWebSocketRequest documentation for
		/// intended usage.
		/// </summary>
		public unsafe virtual void OnWebSocketMessage(CefServer server, int connectionId, IntPtr data, long dataSize)
		{
		}

		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate void OnWebSocketMessageDelegate(cef_server_handler_t* self, cef_server_t* server, int connection_id, void* data, UIntPtr data_size);

		// void (*)(_cef_server_handler_t* self, _cef_server_t* server, int connection_id, const void* data, size_t data_size)*
		private static unsafe void OnWebSocketMessageImpl(cef_server_handler_t* self, cef_server_t* server, int connection_id, void* data, UIntPtr data_size)
		{
			var instance = GetInstance((IntPtr)self) as CefServerHandler;
			if (instance == null || ((ICefServerHandlerPrivate)instance).AvoidOnWebSocketMessage())
			{
				ReleaseIfNonNull((cef_base_ref_counted_t*)server);
				return;
			}
			instance.OnWebSocketMessage(CefServer.Wrap(CefServer.Create, server), connection_id, unchecked((IntPtr)data), (long)data_size);
		}
	}
}
