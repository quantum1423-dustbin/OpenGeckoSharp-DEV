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
// Generated by IDLImporter from file nsIKeyModule.idl
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
    /// An opaque key object.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("4b31f4ed-9424-4710-b946-79b7e33cf3a8")]
	public interface nsIKeyObject
	{
		
		/// <summary>
        /// for freeing the key memory when destroyed.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void InitKey(short aAlgorithm, System.IntPtr aKey);
		
		/// <summary>
        /// Return a pointer to the underlying key object
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetKeyObj();
		
		/// <summary>
        /// Will return NS_ERROR_NOT_INITIALIZED if initKey hasn't been run
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		short GetType();
	}
	
	/// <summary>nsIKeyObjectFactory </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("264eb54d-e20d-49a0-890c-1a5986ea81c4")]
	public interface nsIKeyObjectFactory
	{
		
		/// <summary>Member LookupKeyByName </summary>
		/// <param name='aName'> </param>
		/// <returns>A nsIKeyObject</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIKeyObject LookupKeyByName([MarshalAs(UnmanagedType.LPStruct)] nsAString aName);
		
		/// <summary>Member UnwrapKey </summary>
		/// <param name='aAlgorithm'> </param>
		/// <param name='aWrappedKey'> </param>
		/// <param name='aWrappedKeyLen'> </param>
		/// <returns>A nsIKeyObject</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIKeyObject UnwrapKey(short aAlgorithm, System.IntPtr aWrappedKey, uint aWrappedKeyLen);
		
		/// <summary>
        /// This is not FIPS compliant and should not be used.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIKeyObject KeyFromString(short aAlgorithm, [MarshalAs(UnmanagedType.LPStruct)] nsAString aKey);
	}
}
