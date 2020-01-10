﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: Generated/Native/Types/cef_menu_model_t.cs
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
	/// Supports creation and modification of menus. See cef_menu_id_t for the
	/// command ids that have default implementations. All user-defined command ids
	/// should be between MENU_ID_USER_FIRST and MENU_ID_USER_LAST. The functions of
	/// this structure can only be accessed on the browser process the UI thread.
	/// </summary>
	/// <remarks>
	/// Role: Proxy
	/// </remarks>
	public unsafe partial class CefMenuModel : CefBaseRefCounted<cef_menu_model_t>
	{
		internal static unsafe CefMenuModel Create(IntPtr instance)
		{
			return new CefMenuModel((cef_menu_model_t*)instance);
		}

		public CefMenuModel(cef_menu_model_t* instance)
			: base((cef_base_ref_counted_t*)instance)
		{
		}

		/// <summary>
		/// Gets a value indicating whether this menu is a submenu.
		/// </summary>
		public unsafe virtual bool IsSubMenu
		{
			get
			{
				return NativeInstance->IsSubMenu() != 0;
			}
		}

		/// <summary>
		/// Gets the number of items in this menu.
		/// </summary>
		public unsafe virtual int Count
		{
			get
			{
				return NativeInstance->GetCount();
			}
		}

		/// <summary>
		/// Clears the menu. Returns true (1) on success.
		/// </summary>
		public unsafe virtual bool Clear()
		{
			return NativeInstance->Clear() != 0;
		}

		/// <summary>
		/// Add a separator to the menu. Returns true (1) on success.
		/// </summary>
		public unsafe virtual bool AddSeparator()
		{
			return NativeInstance->AddSeparator() != 0;
		}

		/// <summary>
		/// Add an item to the menu. Returns true (1) on success.
		/// </summary>
		public unsafe virtual bool AddItem(int commandId, string label)
		{
			fixed (char* s1 = label)
			{
				var cstr1 = new cef_string_t { Str = s1, Length = label != null ? label.Length : 0 };
				return NativeInstance->AddItem(commandId, &cstr1) != 0;
			}
		}

		/// <summary>
		/// Add a check item to the menu. Returns true (1) on success.
		/// </summary>
		public unsafe virtual bool AddCheckItem(int commandId, string label)
		{
			fixed (char* s1 = label)
			{
				var cstr1 = new cef_string_t { Str = s1, Length = label != null ? label.Length : 0 };
				return NativeInstance->AddCheckItem(commandId, &cstr1) != 0;
			}
		}

		/// <summary>
		/// Add a radio item to the menu. Only a single item with the specified
		/// |group_id| can be checked at a time. Returns true (1) on success.
		/// </summary>
		public unsafe virtual bool AddRadioItem(int commandId, string label, int groupId)
		{
			fixed (char* s1 = label)
			{
				var cstr1 = new cef_string_t { Str = s1, Length = label != null ? label.Length : 0 };
				return NativeInstance->AddRadioItem(commandId, &cstr1, groupId) != 0;
			}
		}

		/// <summary>
		/// Add a sub-menu to the menu. The new sub-menu is returned.
		/// </summary>
		public unsafe virtual CefMenuModel AddSubMenu(int commandId, string label)
		{
			fixed (char* s1 = label)
			{
				var cstr1 = new cef_string_t { Str = s1, Length = label != null ? label.Length : 0 };
				return CefMenuModel.Wrap(CefMenuModel.Create, NativeInstance->AddSubMenu(commandId, &cstr1));
			}
		}

		/// <summary>
		/// Insert a separator in the menu at the specified |index|. Returns true (1)
		/// on success.
		/// </summary>
		public unsafe virtual bool InsertSeparatorAt(int index)
		{
			return NativeInstance->InsertSeparatorAt(index) != 0;
		}

		/// <summary>
		/// Insert an item in the menu at the specified |index|. Returns true (1) on
		/// success.
		/// </summary>
		public unsafe virtual bool InsertItemAt(int index, int commandId, string label)
		{
			fixed (char* s2 = label)
			{
				var cstr2 = new cef_string_t { Str = s2, Length = label != null ? label.Length : 0 };
				return NativeInstance->InsertItemAt(index, commandId, &cstr2) != 0;
			}
		}

		/// <summary>
		/// Insert a check item in the menu at the specified |index|. Returns true (1)
		/// on success.
		/// </summary>
		public unsafe virtual bool InsertCheckItemAt(int index, int commandId, string label)
		{
			fixed (char* s2 = label)
			{
				var cstr2 = new cef_string_t { Str = s2, Length = label != null ? label.Length : 0 };
				return NativeInstance->InsertCheckItemAt(index, commandId, &cstr2) != 0;
			}
		}

		/// <summary>
		/// Insert a radio item in the menu at the specified |index|. Only a single
		/// item with the specified |group_id| can be checked at a time. Returns true
		/// (1) on success.
		/// </summary>
		public unsafe virtual bool InsertRadioItemAt(int index, int commandId, string label, int groupId)
		{
			fixed (char* s2 = label)
			{
				var cstr2 = new cef_string_t { Str = s2, Length = label != null ? label.Length : 0 };
				return NativeInstance->InsertRadioItemAt(index, commandId, &cstr2, groupId) != 0;
			}
		}

		/// <summary>
		/// Insert a sub-menu in the menu at the specified |index|. The new sub-menu is
		/// returned.
		/// </summary>
		public unsafe virtual CefMenuModel InsertSubMenuAt(int index, int commandId, string label)
		{
			fixed (char* s2 = label)
			{
				var cstr2 = new cef_string_t { Str = s2, Length = label != null ? label.Length : 0 };
				return CefMenuModel.Wrap(CefMenuModel.Create, NativeInstance->InsertSubMenuAt(index, commandId, &cstr2));
			}
		}

		/// <summary>
		/// Removes the item with the specified |command_id|. Returns true (1) on
		/// success.
		/// </summary>
		public unsafe virtual bool Remove(int commandId)
		{
			return NativeInstance->Remove(commandId) != 0;
		}

		/// <summary>
		/// Removes the item at the specified |index|. Returns true (1) on success.
		/// </summary>
		public unsafe virtual bool RemoveAt(int index)
		{
			return NativeInstance->RemoveAt(index) != 0;
		}

		/// <summary>
		/// Returns the index associated with the specified |command_id| or -1 if not
		/// found due to the command id not existing in the menu.
		/// </summary>
		public unsafe virtual int GetIndexOf(int commandId)
		{
			return NativeInstance->GetIndexOf(commandId);
		}

		/// <summary>
		/// Returns the command id at the specified |index| or -1 if not found due to
		/// invalid range or the index being a separator.
		/// </summary>
		public unsafe virtual int GetCommandIdAt(int index)
		{
			return NativeInstance->GetCommandIdAt(index);
		}

		/// <summary>
		/// Sets the command id at the specified |index|. Returns true (1) on success.
		/// </summary>
		public unsafe virtual bool SetCommandIdAt(int index, int commandId)
		{
			return NativeInstance->SetCommandIdAt(index, commandId) != 0;
		}

		/// <summary>
		/// Returns the label for the specified |command_id| or NULL if not found.
		/// The resulting string must be freed by calling cef_string_userfree_free().
		/// </summary>
		public unsafe virtual string GetLabel(int commandId)
		{
			return CefString.ReadAndFree(NativeInstance->GetLabel(commandId));
		}

		/// <summary>
		/// Returns the label at the specified |index| or NULL if not found due to
		/// invalid range or the index being a separator.
		/// The resulting string must be freed by calling cef_string_userfree_free().
		/// </summary>
		public unsafe virtual string GetLabelAt(int index)
		{
			return CefString.ReadAndFree(NativeInstance->GetLabelAt(index));
		}

		/// <summary>
		/// Sets the label for the specified |command_id|. Returns true (1) on success.
		/// </summary>
		public unsafe virtual bool SetLabel(int commandId, string label)
		{
			fixed (char* s1 = label)
			{
				var cstr1 = new cef_string_t { Str = s1, Length = label != null ? label.Length : 0 };
				return NativeInstance->SetLabel(commandId, &cstr1) != 0;
			}
		}

		/// <summary>
		/// Set the label at the specified |index|. Returns true (1) on success.
		/// </summary>
		public unsafe virtual bool SetLabelAt(int index, string label)
		{
			fixed (char* s1 = label)
			{
				var cstr1 = new cef_string_t { Str = s1, Length = label != null ? label.Length : 0 };
				return NativeInstance->SetLabelAt(index, &cstr1) != 0;
			}
		}

		/// <summary>
		/// Returns the item type for the specified |command_id|.
		/// </summary>
		public unsafe virtual CefMenuItemType GetType(int commandId)
		{
			return NativeInstance->GetType(commandId);
		}

		/// <summary>
		/// Returns the item type at the specified |index|.
		/// </summary>
		public unsafe virtual CefMenuItemType GetTypeAt(int index)
		{
			return NativeInstance->GetTypeAt(index);
		}

		/// <summary>
		/// Returns the group id for the specified |command_id| or -1 if invalid.
		/// </summary>
		public unsafe virtual int GetGroupId(int commandId)
		{
			return NativeInstance->GetGroupId(commandId);
		}

		/// <summary>
		/// Returns the group id at the specified |index| or -1 if invalid.
		/// </summary>
		public unsafe virtual int GetGroupIdAt(int index)
		{
			return NativeInstance->GetGroupIdAt(index);
		}

		/// <summary>
		/// Sets the group id for the specified |command_id|. Returns true (1) on
		/// success.
		/// </summary>
		public unsafe virtual bool SetGroupId(int commandId, int groupId)
		{
			return NativeInstance->SetGroupId(commandId, groupId) != 0;
		}

		/// <summary>
		/// Sets the group id at the specified |index|. Returns true (1) on success.
		/// </summary>
		public unsafe virtual bool SetGroupIdAt(int index, int groupId)
		{
			return NativeInstance->SetGroupIdAt(index, groupId) != 0;
		}

		/// <summary>
		/// Returns the submenu for the specified |command_id| or NULL if invalid.
		/// </summary>
		public unsafe virtual CefMenuModel GetSubMenu(int commandId)
		{
			return CefMenuModel.Wrap(CefMenuModel.Create, NativeInstance->GetSubMenu(commandId));
		}

		/// <summary>
		/// Returns the submenu at the specified |index| or NULL if invalid.
		/// </summary>
		public unsafe virtual CefMenuModel GetSubMenuAt(int index)
		{
			return CefMenuModel.Wrap(CefMenuModel.Create, NativeInstance->GetSubMenuAt(index));
		}

		/// <summary>
		/// Returns true (1) if the specified |command_id| is visible.
		/// </summary>
		public unsafe virtual bool IsVisible(int commandId)
		{
			return NativeInstance->IsVisible(commandId) != 0;
		}

		/// <summary>
		/// Returns true (1) if the specified |index| is visible.
		/// </summary>
		public unsafe virtual bool IsVisibleAt(int index)
		{
			return NativeInstance->IsVisibleAt(index) != 0;
		}

		/// <summary>
		/// Change the visibility of the specified |command_id|. Returns true (1) on
		/// success.
		/// </summary>
		public unsafe virtual bool SetVisible(int commandId, bool visible)
		{
			return NativeInstance->SetVisible(commandId, visible ? 1 : 0) != 0;
		}

		/// <summary>
		/// Change the visibility at the specified |index|. Returns true (1) on
		/// success.
		/// </summary>
		public unsafe virtual bool SetVisibleAt(int index, bool visible)
		{
			return NativeInstance->SetVisibleAt(index, visible ? 1 : 0) != 0;
		}

		/// <summary>
		/// Returns true (1) if the specified |command_id| is enabled.
		/// </summary>
		public unsafe virtual bool IsEnabled(int commandId)
		{
			return NativeInstance->IsEnabled(commandId) != 0;
		}

		/// <summary>
		/// Returns true (1) if the specified |index| is enabled.
		/// </summary>
		public unsafe virtual bool IsEnabledAt(int index)
		{
			return NativeInstance->IsEnabledAt(index) != 0;
		}

		/// <summary>
		/// Change the enabled status of the specified |command_id|. Returns true (1)
		/// on success.
		/// </summary>
		public unsafe virtual bool SetEnabled(int commandId, int enabled)
		{
			return NativeInstance->SetEnabled(commandId, enabled) != 0;
		}

		/// <summary>
		/// Change the enabled status at the specified |index|. Returns true (1) on
		/// success.
		/// </summary>
		public unsafe virtual bool SetEnabledAt(int index, bool enabled)
		{
			return NativeInstance->SetEnabledAt(index, enabled ? 1 : 0) != 0;
		}

		/// <summary>
		/// Returns true (1) if the specified |command_id| is checked. Only applies to
		/// check and radio items.
		/// </summary>
		public unsafe virtual bool IsChecked(int commandId)
		{
			return NativeInstance->IsChecked(commandId) != 0;
		}

		/// <summary>
		/// Returns true (1) if the specified |index| is checked. Only applies to check
		/// and radio items.
		/// </summary>
		public unsafe virtual bool IsCheckedAt(int index)
		{
			return NativeInstance->IsCheckedAt(index) != 0;
		}

		/// <summary>
		/// Check the specified |command_id|. Only applies to check and radio items.
		/// Returns true (1) on success.
		/// </summary>
		public unsafe virtual bool SetChecked(int commandId, int @checked)
		{
			return NativeInstance->SetChecked(commandId, @checked) != 0;
		}

		/// <summary>
		/// Check the specified |index|. Only applies to check and radio items. Returns
		/// true (1) on success.
		/// </summary>
		public unsafe virtual bool SetCheckedAt(int index, bool @checked)
		{
			return NativeInstance->SetCheckedAt(index, @checked ? 1 : 0) != 0;
		}

		/// <summary>
		/// Returns true (1) if the specified |command_id| has a keyboard accelerator
		/// assigned.
		/// </summary>
		public unsafe virtual bool HasAccelerator(int commandId)
		{
			return NativeInstance->HasAccelerator(commandId) != 0;
		}

		/// <summary>
		/// Returns true (1) if the specified |index| has a keyboard accelerator
		/// assigned.
		/// </summary>
		public unsafe virtual bool HasAcceleratorAt(int index)
		{
			return NativeInstance->HasAcceleratorAt(index) != 0;
		}

		/// <summary>
		/// Set the keyboard accelerator for the specified |command_id|. |key_code| can
		/// be any virtual key or character value. Returns true (1) on success.
		/// </summary>
		public unsafe virtual bool SetAccelerator(int commandId, int keyCode, bool shiftPressed, bool ctrlPressed, bool altPressed)
		{
			return NativeInstance->SetAccelerator(commandId, keyCode, shiftPressed ? 1 : 0, ctrlPressed ? 1 : 0, altPressed ? 1 : 0) != 0;
		}

		/// <summary>
		/// Set the keyboard accelerator at the specified |index|. |key_code| can be
		/// any virtual key or character value. Returns true (1) on success.
		/// </summary>
		public unsafe virtual bool SetAcceleratorAt(int index, int keyCode, bool shiftPressed, bool ctrlPressed, bool altPressed)
		{
			return NativeInstance->SetAcceleratorAt(index, keyCode, shiftPressed ? 1 : 0, ctrlPressed ? 1 : 0, altPressed ? 1 : 0) != 0;
		}

		/// <summary>
		/// Remove the keyboard accelerator for the specified |command_id|. Returns
		/// true (1) on success.
		/// </summary>
		public unsafe virtual bool RemoveAccelerator(int commandId)
		{
			return NativeInstance->RemoveAccelerator(commandId) != 0;
		}

		/// <summary>
		/// Remove the keyboard accelerator at the specified |index|. Returns true (1)
		/// on success.
		/// </summary>
		public unsafe virtual bool RemoveAcceleratorAt(int index)
		{
			return NativeInstance->RemoveAcceleratorAt(index) != 0;
		}

		/// <summary>
		/// Retrieves the keyboard accelerator for the specified |command_id|. Returns
		/// true (1) on success.
		/// </summary>
		public unsafe virtual bool GetAccelerator(int commandId, ref int keyCode, ref int shiftPressed, ref int ctrlPressed, ref int altPressed)
		{
			fixed (int* p1 = &keyCode)
			fixed (int* p2 = &shiftPressed)
			fixed (int* p3 = &ctrlPressed)
			fixed (int* p4 = &altPressed)
			{
				return NativeInstance->GetAccelerator(commandId, p1, p2, p3, p4) != 0;
			}
		}

		/// <summary>
		/// Retrieves the keyboard accelerator for the specified |index|. Returns true
		/// (1) on success.
		/// </summary>
		public unsafe virtual bool GetAcceleratorAt(int index, ref int keyCode, ref int shiftPressed, ref int ctrlPressed, ref int altPressed)
		{
			fixed (int* p1 = &keyCode)
			fixed (int* p2 = &shiftPressed)
			fixed (int* p3 = &ctrlPressed)
			fixed (int* p4 = &altPressed)
			{
				return NativeInstance->GetAcceleratorAt(index, p1, p2, p3, p4) != 0;
			}
		}

		/// <summary>
		/// Set the explicit color for |command_id| and |color_type| to |color|.
		/// Specify a |color| value of 0 to remove the explicit color. If no explicit
		/// color or default color is set for |color_type| then the system color will
		/// be used. Returns true (1) on success.
		/// </summary>
		public unsafe virtual bool SetColor(int commandId, CefMenuColorType colorType, CefColor color)
		{
			return NativeInstance->SetColor(commandId, colorType, color) != 0;
		}

		/// <summary>
		/// Set the explicit color for |command_id| and |index| to |color|. Specify a
		/// |color| value of 0 to remove the explicit color. Specify an |index| value
		/// of -1 to set the default color for items that do not have an explicit color
		/// set. If no explicit color or default color is set for |color_type| then the
		/// system color will be used. Returns true (1) on success.
		/// </summary>
		public unsafe virtual bool SetColorAt(int index, CefMenuColorType colorType, CefColor color)
		{
			return NativeInstance->SetColorAt(index, colorType, color) != 0;
		}

		/// <summary>
		/// Returns in |color| the color that was explicitly set for |command_id| and
		/// |color_type|. If a color was not set then 0 will be returned in |color|.
		/// Returns true (1) on success.
		/// </summary>
		public unsafe virtual bool GetColor(int commandId, CefMenuColorType colorType, ref CefColor color)
		{
			fixed (CefColor* p2 = &color)
			{
				return NativeInstance->GetColor(commandId, colorType, (cef_color_t*)p2) != 0;
			}
		}

		/// <summary>
		/// Returns in |color| the color that was explicitly set for |command_id| and
		/// |color_type|. Specify an |index| value of -1 to return the default color in
		/// |color|. If a color was not set then 0 will be returned in |color|. Returns
		/// true (1) on success.
		/// </summary>
		public unsafe virtual bool GetColorAt(int index, CefMenuColorType colorType, ref CefColor color)
		{
			fixed (CefColor* p2 = &color)
			{
				return NativeInstance->GetColorAt(index, colorType, (cef_color_t*)p2) != 0;
			}
		}

		/// <summary>
		/// Sets the font list for the specified |command_id|. If |font_list| is NULL
		/// the system font will be used. Returns true (1) on success. The format is
		/// &quot;
		/// &lt;FONT
		/// _FAMILY_LIST&gt;,[STYLES]
		/// &lt;SIZE
		/// &gt;&quot;, where: - FONT_FAMILY_LIST is a comma-
		/// separated list of font family names, - STYLES is an optional space-
		/// separated list of style names (case-sensitive
		/// &quot;Bold&quot; and &quot;Italic&quot; are supported), and
		/// - SIZE is an integer font size in pixels with the suffix &quot;px&quot;.
		/// Here are examples of valid font description strings: - &quot;Arial, Helvetica,
		/// Bold Italic 14px&quot; - &quot;Arial, 14px&quot;
		/// </summary>
		public unsafe virtual bool SetFontList(int commandId, string fontList)
		{
			fixed (char* s1 = fontList)
			{
				var cstr1 = new cef_string_t { Str = s1, Length = fontList != null ? fontList.Length : 0 };
				return NativeInstance->SetFontList(commandId, &cstr1) != 0;
			}
		}

		/// <summary>
		/// Sets the font list for the specified |index|. Specify an |index| value of
		/// -1 to set the default font. If |font_list| is NULL the system font will be
		/// used. Returns true (1) on success. The format is
		/// &quot;
		/// &lt;FONT
		/// _FAMILY_LIST&gt;,[STYLES]
		/// &lt;SIZE
		/// &gt;&quot;, where: - FONT_FAMILY_LIST is a comma-
		/// separated list of font family names, - STYLES is an optional space-
		/// separated list of style names (case-sensitive
		/// &quot;Bold&quot; and &quot;Italic&quot; are supported), and
		/// - SIZE is an integer font size in pixels with the suffix &quot;px&quot;.
		/// Here are examples of valid font description strings: - &quot;Arial, Helvetica,
		/// Bold Italic 14px&quot; - &quot;Arial, 14px&quot;
		/// </summary>
		public unsafe virtual bool SetFontListAt(int index, string fontList)
		{
			fixed (char* s1 = fontList)
			{
				var cstr1 = new cef_string_t { Str = s1, Length = fontList != null ? fontList.Length : 0 };
				return NativeInstance->SetFontListAt(index, &cstr1) != 0;
			}
		}
	}
}
