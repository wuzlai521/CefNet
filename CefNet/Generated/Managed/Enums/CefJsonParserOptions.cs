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
	/// Options that can be passed to CefParseJSON.
	/// </summary>
	public enum CefJsonParserOptions
	{
		/// <summary>
		/// Parses the input strictly according to RFC 4627. See comments in Chromium&apos;s
		/// base/json/json_reader.h file for known limitations/deviations from the RFC.
		/// </summary>
		Rfc = 0,

		/// <summary>
		/// Allows commas to exist after the last element in structures.
		/// </summary>
		AllowTrailingCommas = 1 << 0,
	}
}

