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
// Generated by IDLImporter from file nsICollation.idl
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
	
	
	/// <summary>nsICollationFactory </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("04971e14-d6b3-4ada-8cbb-c3a13842b349")]
	public interface nsICollationFactory
	{
		
		/// <summary>
        /// Create the collation for a given locale.
        ///
        /// Use NULL as the locale parameter to use the user's locale preference
        /// from the operating system.
        ///
        /// @param locale
        /// The locale for which to create the collation or null to use
        /// user preference.
        /// @return A collation for the given locale.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsICollation CreateCollation([MarshalAs(UnmanagedType.Interface)] nsILocale locale);
	}
	
	/// <summary>nsICollation </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("b0132cc0-3786-4557-9874-910d7def5f93")]
	public interface nsICollation
	{
		
		/// <summary>
        /// init this interface to a specified locale (should only be called by collation factory)
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Initialize([MarshalAs(UnmanagedType.Interface)] nsILocale locale);
		
		/// <summary>
        /// result is same as strcmp
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int CompareString(int strength, [MarshalAs(UnmanagedType.LPStruct)] nsAString string1, [MarshalAs(UnmanagedType.LPStruct)] nsAString string2);
		
		/// <summary>
        /// returns newly allocated key, and its band its byte length
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AllocateRawSortKey(int strength, [MarshalAs(UnmanagedType.LPStruct)] nsAString stringIn, out System.IntPtr key, out uint outLen);
		
		/// <summary>
        /// length is a byte length, result is same as strcmp
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int CompareRawSortKey(System.IntPtr key1, uint len1, System.IntPtr key2, uint len2);
	}
}
