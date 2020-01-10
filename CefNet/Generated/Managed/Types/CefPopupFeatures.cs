﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: Generated/Native/Types/cef_popup_features_t.cs
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
	/// Popup window features.
	/// </summary>
	/// <remarks>
	/// Role: Proxy
	/// </remarks>
	public unsafe partial struct CefPopupFeatures
	{
		private cef_popup_features_t _instance;

		public int X
		{
			get
			{
				return _instance.x;
			}
			set
			{
				_instance.x = value;
			}
		}

		public int XSet
		{
			get
			{
				return _instance.xSet;
			}
			set
			{
				_instance.xSet = value;
			}
		}

		public int Y
		{
			get
			{
				return _instance.y;
			}
			set
			{
				_instance.y = value;
			}
		}

		public int YSet
		{
			get
			{
				return _instance.ySet;
			}
			set
			{
				_instance.ySet = value;
			}
		}

		public int Width
		{
			get
			{
				return _instance.width;
			}
			set
			{
				_instance.width = value;
			}
		}

		public int WidthSet
		{
			get
			{
				return _instance.widthSet;
			}
			set
			{
				_instance.widthSet = value;
			}
		}

		public int Height
		{
			get
			{
				return _instance.height;
			}
			set
			{
				_instance.height = value;
			}
		}

		public int HeightSet
		{
			get
			{
				return _instance.heightSet;
			}
			set
			{
				_instance.heightSet = value;
			}
		}

		public int MenuBarVisible
		{
			get
			{
				return _instance.menuBarVisible;
			}
			set
			{
				_instance.menuBarVisible = value;
			}
		}

		public int StatusBarVisible
		{
			get
			{
				return _instance.statusBarVisible;
			}
			set
			{
				_instance.statusBarVisible = value;
			}
		}

		public int ToolBarVisible
		{
			get
			{
				return _instance.toolBarVisible;
			}
			set
			{
				_instance.toolBarVisible = value;
			}
		}

		public int ScrollbarsVisible
		{
			get
			{
				return _instance.scrollbarsVisible;
			}
			set
			{
				_instance.scrollbarsVisible = value;
			}
		}

		public static implicit operator CefPopupFeatures(cef_popup_features_t instance)
		{
			return new CefPopupFeatures { _instance = instance };
		}

		public static implicit operator cef_popup_features_t(CefPopupFeatures instance)
		{
			return instance._instance;
		}
	}
}
