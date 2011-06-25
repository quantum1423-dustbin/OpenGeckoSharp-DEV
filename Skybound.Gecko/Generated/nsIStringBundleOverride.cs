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
// Generated by IDLImporter from file nsIStringBundleOverride.idl
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
    /// to be implemented by an embeddor that wants to override some strings
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("965eb278-5678-456b-82a7-20a0c86a803c")]
	public interface nsIStringBundleOverride
	{
		
		/// <summary>
        /// get the override value for a particular key in a particular
        /// string bundle
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetStringFromName([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String url, [MarshalAs(UnmanagedType.LPStruct)] nsAString key, [MarshalAs(UnmanagedType.LPStruct)] nsAString retval);
		
		/// <summary>
        /// get all override keys for a given string bundle
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISimpleEnumerator EnumerateKeysInBundle([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String url);
	}
}
