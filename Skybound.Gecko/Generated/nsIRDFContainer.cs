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
// Generated by IDLImporter from file nsIRDFContainer.idl
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
    /// A wrapper for manipulating RDF containers
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("D4214E90-FB94-11D2-BDD8-00104BDE6048")]
	public interface nsIRDFContainer
	{
		
		/// <summary>
        /// A wrapper for manipulating RDF containers
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIRDFDataSource GetDataSourceAttribute();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIRDFResource GetResourceAttribute();
		
		/// <summary>
        /// Initialize the container wrapper to the specified resource
        /// using the specified datasource for context.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Init([MarshalAs(UnmanagedType.Interface)] nsIRDFDataSource aDataSource, [MarshalAs(UnmanagedType.Interface)] nsIRDFResource aContainer);
		
		/// <summary>
        /// Return the number of elements in the container. Note that this
        /// may not always be accurate due to aggregation.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetCount();
		
		/// <summary>
        /// Return an enumerator that can be used to enumerate the contents
        /// of the container in ascending order.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISimpleEnumerator GetElements();
		
		/// <summary>
        /// Append an element to the container, assigning it the next
        /// available ordinal.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AppendElement([MarshalAs(UnmanagedType.Interface)] nsIRDFNode aElement);
		
		/// <summary>
        /// Remove the first occurence of the specified element from the
        /// container. If aRenumber is 'true', then the underlying RDF graph
        /// will be 're-numbered' to account for the removal.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveElement([MarshalAs(UnmanagedType.Interface)] nsIRDFNode aElement, [MarshalAs(UnmanagedType.Bool)] bool aRenumber);
		
		/// <summary>
        /// Insert aElement at the specified index. If aRenumber is 'true', then
        /// the underlying RDF graph will be 're-numbered' to accomodate the new
        /// element.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void InsertElementAt([MarshalAs(UnmanagedType.Interface)] nsIRDFNode aElement, int aIndex, [MarshalAs(UnmanagedType.Bool)] bool aRenumber);
		
		/// <summary>
        /// Remove the element at the specified index. If aRenumber is 'true', then
        /// the underlying RDF graph will be 're-numbered' to account for the
        /// removal.
        ///
        /// @return the element that was removed.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIRDFNode RemoveElementAt(int aIndex, [MarshalAs(UnmanagedType.Bool)] bool aRenumber);
		
		/// <summary>
        /// Determine the index of an element in the container.
        ///
        /// @return The index of the specified element in the container. If
        /// the element is not contained in the container, this function
        /// returns '-1'.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int IndexOf([MarshalAs(UnmanagedType.Interface)] nsIRDFNode aElement);
	}
}
