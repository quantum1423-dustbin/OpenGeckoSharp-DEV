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
// Generated by IDLImporter from file nsIDOMLSOutput.idl
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
	
	
	/// <summary>nsIDOMLSOutput </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("757e9971-8890-478d-a53a-07f9f6f6e0d3")]
	public interface nsIDOMLSOutput
	{
		
		/// <summary>
        /// this attribute may not be available.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISupports GetCharacterStreamAttribute();
		
		/// <summary>
        /// this attribute may not be available.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetCharacterStreamAttribute([MarshalAs(UnmanagedType.Interface)] nsISupports aCharacterStream);
		
		/// <summary>Member GetByteStreamAttribute </summary>
		/// <returns>A nsIOutputStream</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIOutputStream GetByteStreamAttribute();
		
		/// <summary>Member SetByteStreamAttribute </summary>
		/// <param name='aByteStream'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetByteStreamAttribute([MarshalAs(UnmanagedType.Interface)] nsIOutputStream aByteStream);
		
		/// <summary>Member GetSystemIdAttribute </summary>
		/// <param name='aSystemId'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetSystemIdAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aSystemId);
		
		/// <summary>Member SetSystemIdAttribute </summary>
		/// <param name='aSystemId'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetSystemIdAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aSystemId);
		
		/// <summary>Member GetEncodingAttribute </summary>
		/// <param name='aEncoding'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetEncodingAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aEncoding);
		
		/// <summary>Member SetEncodingAttribute </summary>
		/// <param name='aEncoding'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetEncodingAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aEncoding);
	}
}
