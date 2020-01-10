﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: include/internal/cef_types.h
// --------------------------------------------------------------------------------------------﻿
// DO NOT MODIFY! THIS IS AUTOGENERATED FILE!
// --------------------------------------------------------------------------------------------

using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using CefNet.WinApi;

namespace CefNet
{
	/// <summary>
	/// Supported SSL content status flags. See content/public/common/ssl_status.h
	/// for more information.
	/// </summary>
	public enum CefSSLContentStatus
	{
		NormalContent = 0,

		DisplayedInsecureContent = 1 << 0,

		RanInsecureContent = 1 << 1,
	}
}

