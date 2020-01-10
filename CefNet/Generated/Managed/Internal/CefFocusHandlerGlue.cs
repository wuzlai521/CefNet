﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: Generated/Native/Types/cef_focus_handler_t.cs
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
	sealed partial class CefFocusHandlerGlue: CefFocusHandler, ICefFocusHandlerPrivate
	{
		private WebViewGlue _implementation;

		public CefFocusHandlerGlue(WebViewGlue impl)
		{
			_implementation = impl;
		}

		bool ICefFocusHandlerPrivate.AvoidOnTakeFocus()
		{
			return _implementation.AvoidOnTakeFocus();
		}

		public override void OnTakeFocus(CefBrowser browser, bool next)
		{
			_implementation.OnTakeFocus(browser, next);
		}

		bool ICefFocusHandlerPrivate.AvoidOnSetFocus()
		{
			return _implementation.AvoidOnSetFocus();
		}

		public override bool OnSetFocus(CefBrowser browser, CefFocusSource source)
		{
			return _implementation.OnSetFocus(browser, source);
		}

		bool ICefFocusHandlerPrivate.AvoidOnGotFocus()
		{
			return _implementation.AvoidOnGotFocus();
		}

		public override void OnGotFocus(CefBrowser browser)
		{
			_implementation.OnGotFocus(browser);
		}

	}
}
