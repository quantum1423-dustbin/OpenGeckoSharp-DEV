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
// Generated by IDLImporter from file nsIFeedPerson.idl
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
    /// An nsIFeedPerson represents an author or contributor of a feed.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("29cbd45f-f2d3-4b28-b557-3ab7a61ecde4")]
	public interface nsIFeedPerson : nsIFeedElementBase
	{
		
		/// <summary>
        /// The attributes found on the element. Most interfaces provide convenience
        /// accessors for their standard fields, so this useful only when looking for
        /// an extension.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsISAXAttributes GetAttributesAttribute();
		
		/// <summary>
        /// The attributes found on the element. Most interfaces provide convenience
        /// accessors for their standard fields, so this useful only when looking for
        /// an extension.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetAttributesAttribute([MarshalAs(UnmanagedType.Interface)] nsISAXAttributes aAttributes);
		
		/// <summary>
        /// The baseURI for the Entry or Feed.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIURI GetBaseURIAttribute();
		
		/// <summary>
        /// The baseURI for the Entry or Feed.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetBaseURIAttribute([MarshalAs(UnmanagedType.Interface)] nsIURI aBaseURI);
		
		/// <summary>
        /// The name of the person.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aName);
		
		/// <summary>
        /// The name of the person.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aName);
		
		/// <summary>
        /// An email address associated with the person.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetEmailAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aEmail);
		
		/// <summary>
        /// An email address associated with the person.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetEmailAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aEmail);
		
		/// <summary>
        /// A URI associated with the person (e.g. a homepage).
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURI GetUriAttribute();
		
		/// <summary>
        /// A URI associated with the person (e.g. a homepage).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetUriAttribute([MarshalAs(UnmanagedType.Interface)] nsIURI aUri);
	}
}
