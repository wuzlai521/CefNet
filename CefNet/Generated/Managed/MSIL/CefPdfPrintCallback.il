﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: Generated/Managed/Types/CefPdfPrintCallback.cs
// --------------------------------------------------------------------------------------------﻿
// DO NOT MODIFY! THIS IS AUTOGENERATED FILE!
// --------------------------------------------------------------------------------------------

.namespace CefNet
{
	.class public CefPdfPrintCallback
	{

		.method private final hidebysig newslot virtual instance bool CefNet.Internal.ICefPdfPrintCallbackPrivate.AvoidOnPdfPrintFinished()
		{
			.override method instance bool CefNet.Internal.ICefPdfPrintCallbackPrivate::AvoidOnPdfPrintFinished()
			.maxstack 2
			ldarg.0
			ldvirtftn instance void CefNet.CefPdfPrintCallback::OnPdfPrintFinished(string, bool)
			ldftn instance void CefNet.CefPdfPrintCallback::OnPdfPrintFinished(string, bool)
			ceq
			ret
		}

	}
}
