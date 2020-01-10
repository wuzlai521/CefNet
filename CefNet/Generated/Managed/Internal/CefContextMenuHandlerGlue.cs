﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: Generated/Native/Types/cef_context_menu_handler_t.cs
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

namespace CefNet.Internal
{
	sealed partial class CefContextMenuHandlerGlue: CefContextMenuHandler, ICefContextMenuHandlerPrivate
	{
		private WebViewGlue _implementation;

		public CefContextMenuHandlerGlue(WebViewGlue impl)
		{
			_implementation = impl;
		}

		bool ICefContextMenuHandlerPrivate.AvoidOnBeforeContextMenu()
		{
			return _implementation.AvoidOnBeforeContextMenu();
		}

		public override void OnBeforeContextMenu(CefBrowser browser, CefFrame frame, CefContextMenuParams @params, CefMenuModel model)
		{
			_implementation.OnBeforeContextMenu(browser, frame, @params, model);
		}

		bool ICefContextMenuHandlerPrivate.AvoidRunContextMenu()
		{
			return _implementation.AvoidRunContextMenu();
		}

		public override bool RunContextMenu(CefBrowser browser, CefFrame frame, CefContextMenuParams @params, CefMenuModel model, CefRunContextMenuCallback callback)
		{
			return _implementation.RunContextMenu(browser, frame, @params, model, callback);
		}

		bool ICefContextMenuHandlerPrivate.AvoidOnContextMenuCommand()
		{
			return _implementation.AvoidOnContextMenuCommand();
		}

		public override bool OnContextMenuCommand(CefBrowser browser, CefFrame frame, CefContextMenuParams @params, int commandId, CefEventFlags eventFlags)
		{
			return _implementation.OnContextMenuCommand(browser, frame, @params, commandId, eventFlags);
		}

		bool ICefContextMenuHandlerPrivate.AvoidOnContextMenuDismissed()
		{
			return _implementation.AvoidOnContextMenuDismissed();
		}

		public override void OnContextMenuDismissed(CefBrowser browser, CefFrame frame)
		{
			_implementation.OnContextMenuDismissed(browser, frame);
		}

	}
}
