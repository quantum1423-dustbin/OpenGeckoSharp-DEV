// --------------------------------------------------------------------------------------------
// Version: MPL 1.1/GPL 2.0/LGPL 2.1
// 
// The contents of this file are subject to the Mozilla Public License Version
// 1.1 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
// http://www.mozilla.org/MPL/
// 
// Software distributed under the License is distributed on an "AS IS" basis,
// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License
// for the specific language governing rights and limitations under the
// License.
// 
// <remarks>
// Generated by IDLImporter from file nsITokenPasswordDialogs.idl
// 
// You should use these interfaces when you access the COM objects defined in the mentioned
// IDL/IDH file.
// </remarks>
// --------------------------------------------------------------------------------------------
namespace Skybound.Gecko
{
	using System;
	using System.Runtime.InteropServices;
	using System.Runtime.InteropServices.ComTypes;
	using System.Runtime.CompilerServices;
	using System.Windows.Forms;
	
	
	/// <summary>
    /// nsITokenPasswordDialogs
    /// This is the interface for setting and changing password
    /// on a PKCS11 token.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("be26b580-1dd1-11b2-9946-c598d0d07727")]
	public interface nsITokenPasswordDialogs
	{
		
		/// <summary>
        /// setPassword - sets the password/PIN on the named token.
        /// The canceled output value should be set to TRUE when
        /// the user (or implementation) cancels the operation.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPassword([MarshalAs(UnmanagedType.Interface)] nsIInterfaceRequestor ctx, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.CustomMarshalers.WStringMarshaler")] string tokenName, [MarshalAs(UnmanagedType.Bool)] out bool canceled);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetPassword([MarshalAs(UnmanagedType.Interface)] nsIInterfaceRequestor ctx, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.CustomMarshalers.WStringMarshaler")] string tokenName, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.CustomMarshalers.WStringMarshaler")] out string password, [MarshalAs(UnmanagedType.Bool)] out bool canceled);
	}
}
