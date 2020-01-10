﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: Generated/Native/Types/cef_delete_cookies_callback_t.cs
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
	sealed partial class CefDeleteCookiesCallbackGlue: CefDeleteCookiesCallback, ICefDeleteCookiesCallbackPrivate
	{
		private WebViewGlue _implementation;

		public CefDeleteCookiesCallbackGlue(WebViewGlue impl)
		{
			_implementation = impl;
		}

		bool ICefDeleteCookiesCallbackPrivate.AvoidOnComplete()
		{
			return _implementation.AvoidOnComplete();
		}

		public override void OnComplete(int numDeleted)
		{
			_implementation.OnComplete(numDeleted);
		}

	}
}
