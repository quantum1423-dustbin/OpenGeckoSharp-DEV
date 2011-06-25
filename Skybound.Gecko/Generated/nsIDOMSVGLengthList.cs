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
// Generated by IDLImporter from file nsIDOMSVGLengthList.idl
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
	
	
	/// <summary>nsIDOMSVGLengthList </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("a8760fcd-3de5-446a-a009-5cf877e7a4df")]
	public interface nsIDOMSVGLengthList
	{
		
		/// <summary>Member GetNumberOfItemsAttribute </summary>
		/// <returns>A System.UInt32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetNumberOfItemsAttribute();
		
		/// <summary>Member Clear </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Clear();
		
		/// <summary>
        /// raises(nsIDOMDOMException);
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMSVGLength Initialize([MarshalAs(UnmanagedType.Interface)] nsIDOMSVGLength newItem);
		
		/// <summary>
        /// raises(nsIDOMDOMException, nsIDOMSVGException);
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMSVGLength GetItem(uint index);
		
		/// <summary>
        /// raises(nsIDOMDOMException);
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMSVGLength InsertItemBefore([MarshalAs(UnmanagedType.Interface)] nsIDOMSVGLength newItem, uint index);
		
		/// <summary>
        /// raises(nsIDOMDOMException, nsIDOMSVGException);
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMSVGLength ReplaceItem([MarshalAs(UnmanagedType.Interface)] nsIDOMSVGLength newItem, uint index);
		
		/// <summary>
        /// raises(nsIDOMDOMException, nsIDOMSVGException);
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMSVGLength RemoveItem(uint index);
		
		/// <summary>
        /// raises(nsIDOMDOMException);
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMSVGLength AppendItem([MarshalAs(UnmanagedType.Interface)] nsIDOMSVGLength newItem);
	}
}
