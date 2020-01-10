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
	/// Describes how to interpret the alpha component of a pixel.
	/// </summary>
	public enum CefAlphaType
	{
		/// <summary>
		/// No transparency. The alpha component is ignored.
		/// </summary>
		Opaque = 0,

		/// <summary>
		/// Transparency with pre-multiplied alpha component.
		/// </summary>
		Premultiplied = 1,

		/// <summary>
		/// Transparency with post-multiplied alpha component.
		/// </summary>
		Postmultiplied = 2,
	}
}

