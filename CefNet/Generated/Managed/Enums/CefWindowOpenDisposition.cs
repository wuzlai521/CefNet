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
	/// The manner in which a link click should be opened. These constants match
	/// their equivalents in Chromium&apos;s window_open_disposition.h and should not be
	/// renumbered.
	/// </summary>
	public enum CefWindowOpenDisposition
	{
		Unknown = 0,

		CurrentTab = 1,

		SingletonTab = 2,

		NewForegroundTab = 3,

		NewBackgroundTab = 4,

		NewPopup = 5,

		NewWindow = 6,

		SaveToDisk = 7,

		OffTheRecord = 8,

		IgnoreAction = 9,
	}
}

