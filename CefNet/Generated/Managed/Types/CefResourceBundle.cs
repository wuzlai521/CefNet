﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: Generated/Native/Types/cef_resource_bundle_t.cs
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
	/// Structure used for retrieving resources from the resource bundle (*.pak)
	/// files loaded by CEF during startup or via the cef_resource_bundle_handler_t
	/// returned from cef_app_t::GetResourceBundleHandler. See CefSettings for
	/// additional options related to resource bundle loading. The functions of this
	/// structure may be called on any thread unless otherwise indicated.
	/// </summary>
	/// <remarks>
	/// Role: Proxy
	/// </remarks>
	public unsafe partial class CefResourceBundle : CefBaseRefCounted<cef_resource_bundle_t>
	{
		internal static unsafe CefResourceBundle Create(IntPtr instance)
		{
			return new CefResourceBundle((cef_resource_bundle_t*)instance);
		}

		public CefResourceBundle(cef_resource_bundle_t* instance)
			: base((cef_base_ref_counted_t*)instance)
		{
		}

		/// <summary>
		/// Returns the localized string for the specified |string_id| or an NULL
		/// string if the value is not found. Include cef_pack_strings.h for a listing
		/// of valid string ID values.
		/// The resulting string must be freed by calling cef_string_userfree_free().
		/// </summary>
		public unsafe virtual string GetLocalizedString(int stringId)
		{
			return CefString.ReadAndFree(NativeInstance->GetLocalizedString(stringId));
		}

		/// <summary>
		/// Retrieves the contents of the specified scale independent |resource_id|. If
		/// the value is found then |data| and |data_size| will be populated and this
		/// function will return true (1). If the value is not found then this function
		/// will return false (0). The returned |data| pointer will remain resident in
		/// memory and should not be freed. Include cef_pack_resources.h for a listing
		/// of valid resource ID values.
		/// </summary>
		public unsafe virtual bool GetDataResource(int resourceId, ref IntPtr data, ref long dataSize)
		{
			fixed (IntPtr* p1 = &data)
			{
				UIntPtr c2 = new UIntPtr((ulong)dataSize);
				var rv = NativeInstance->GetDataResource(resourceId, (void**)p1, &c2) != 0;
				dataSize = (long)c2;
				return rv;
			}
		}

		/// <summary>
		/// Retrieves the contents of the specified |resource_id| nearest the scale
		/// factor |scale_factor|. Use a |scale_factor| value of SCALE_FACTOR_NONE for
		/// scale independent resources or call GetDataResource instead. If the value
		/// is found then |data| and |data_size| will be populated and this function
		/// will return true (1). If the value is not found then this function will
		/// return false (0). The returned |data| pointer will remain resident in
		/// memory and should not be freed. Include cef_pack_resources.h for a listing
		/// of valid resource ID values.
		/// </summary>
		public unsafe virtual bool GetDataResourceForScale(int resourceId, CefScaleFactor scaleFactor, ref IntPtr data, ref long dataSize)
		{
			fixed (IntPtr* p2 = &data)
			{
				UIntPtr c3 = new UIntPtr((ulong)dataSize);
				var rv = NativeInstance->GetDataResourceForScale(resourceId, scaleFactor, (void**)p2, &c3) != 0;
				dataSize = (long)c3;
				return rv;
			}
		}
	}
}
