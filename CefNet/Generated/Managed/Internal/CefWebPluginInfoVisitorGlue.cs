﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: Generated/Native/Types/cef_web_plugin_info_visitor_t.cs
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
	sealed partial class CefWebPluginInfoVisitorGlue: CefWebPluginInfoVisitor, ICefWebPluginInfoVisitorPrivate
	{
		private WebViewGlue _implementation;

		public CefWebPluginInfoVisitorGlue(WebViewGlue impl)
		{
			_implementation = impl;
		}

		bool ICefWebPluginInfoVisitorPrivate.AvoidVisit()
		{
			return _implementation.AvoidVisit();
		}

		public override bool Visit(CefWebPluginInfo info, int count, int total)
		{
			return _implementation.Visit(info, count, total);
		}

	}
}
