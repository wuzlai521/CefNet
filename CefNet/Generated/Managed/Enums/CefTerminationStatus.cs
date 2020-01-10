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
	/// Process termination status values.
	/// </summary>
	public enum CefTerminationStatus
	{
		/// <summary>
		/// Non-zero exit status.
		/// </summary>
		AbnormalTermination = 0,

		/// <summary>
		/// SIGKILL or task manager kill.
		/// </summary>
		ProcessWasKilled = 1,

		/// <summary>
		/// Segmentation fault.
		/// </summary>
		ProcessCrashed = 2,

		/// <summary>
		/// Out of memory. Some platforms may use TS_PROCESS_CRASHED instead.
		/// </summary>
		ProcessOom = 3,
	}
}

