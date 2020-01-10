﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: Generated/Native/Types/cef_key_event_t.cs
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
	/// Structure representing keyboard event information.
	/// </summary>
	/// <remarks>
	/// Role: Proxy
	/// </remarks>
	public unsafe partial struct CefKeyEvent
	{
		private cef_key_event_t _instance;

		/// <summary>
		/// The type of keyboard event.
		/// </summary>
		public CefKeyEventType Type
		{
			get
			{
				return _instance.type;
			}
			set
			{
				_instance.type = value;
			}
		}

		/// <summary>
		/// Bit flags describing any pressed modifier keys. See
		/// cef_event_flags_t for values.
		/// </summary>
		public uint Modifiers
		{
			get
			{
				return _instance.modifiers;
			}
			set
			{
				_instance.modifiers = value;
			}
		}

		/// <summary>
		/// The Windows key code for the key event. This value is used by the DOM
		/// specification. Sometimes it comes directly from the event (i.e. on
		/// Windows) and sometimes it&apos;s determined using a mapping function. See
		/// WebCore/platform/chromium/KeyboardCodes.h for the list of values.
		/// </summary>
		public int WindowsKeyCode
		{
			get
			{
				return _instance.windows_key_code;
			}
			set
			{
				_instance.windows_key_code = value;
			}
		}

		/// <summary>
		/// The actual key code genenerated by the platform.
		/// </summary>
		public int NativeKeyCode
		{
			get
			{
				return _instance.native_key_code;
			}
			set
			{
				_instance.native_key_code = value;
			}
		}

		/// <summary>
		/// Indicates whether the event is considered a &quot;system key&quot; event (see
		/// http://msdn.microsoft.com/en-us/library/ms646286(VS.85).aspx for details).
		/// This value will always be false on non-Windows platforms.
		/// </summary>
		public bool IsSystemKey
		{
			get
			{
				return _instance.is_system_key != 0;
			}
			set
			{
				_instance.is_system_key = value ? 1 : 0;
			}
		}

		/// <summary>
		/// The character generated by the keystroke.
		/// </summary>
		public char Character
		{
			get
			{
				return _instance.character;
			}
			set
			{
				_instance.character = value;
			}
		}

		/// <summary>
		/// Same as |character| but unmodified by any concurrently-held modifiers
		/// (except shift). This is useful for working out shortcut keys.
		/// </summary>
		public char UnmodifiedCharacter
		{
			get
			{
				return _instance.unmodified_character;
			}
			set
			{
				_instance.unmodified_character = value;
			}
		}

		/// <summary>
		/// True if the focus is currently on an editable field on the page. This is
		/// useful for determining if standard key events should be intercepted.
		/// </summary>
		public bool FocusOnEditableField
		{
			get
			{
				return _instance.focus_on_editable_field != 0;
			}
			set
			{
				_instance.focus_on_editable_field = value ? 1 : 0;
			}
		}

		public static implicit operator CefKeyEvent(cef_key_event_t instance)
		{
			return new CefKeyEvent { _instance = instance };
		}

		public static implicit operator cef_key_event_t(CefKeyEvent instance)
		{
			return instance._instance;
		}
	}
}
