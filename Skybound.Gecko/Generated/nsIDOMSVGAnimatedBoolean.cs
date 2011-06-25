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
// Generated by IDLImporter from file nsIDOMSVGAnimatedBoolean.idl
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
    /// The nsIDOMSVGAnimatedBoolean interface is the interface to an SVG
    /// animated boolean.
    ///
    /// For more information on this interface please see
    /// http://www.w3.org/TR/SVG11/types.html
    ///
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("7e325385-cc82-4763-bd14-e2c92edd5462")]
	public interface nsIDOMSVGAnimatedBoolean
	{
		
		/// <summary>
        /// The nsIDOMSVGAnimatedBoolean interface is the interface to an SVG
        /// animated boolean.
        ///
        /// For more information on this interface please see
        /// http://www.w3.org/TR/SVG11/types.html
        ///
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetBaseValAttribute();
		
		/// <summary>
        /// The nsIDOMSVGAnimatedBoolean interface is the interface to an SVG
        /// animated boolean.
        ///
        /// For more information on this interface please see
        /// http://www.w3.org/TR/SVG11/types.html
        ///
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetBaseValAttribute([MarshalAs(UnmanagedType.Bool)] bool aBaseVal);
		
		/// <summary>
        /// raises DOMException on setting
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetAnimValAttribute();
	}
}
