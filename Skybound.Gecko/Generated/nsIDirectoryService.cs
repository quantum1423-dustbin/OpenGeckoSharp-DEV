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
// Generated by IDLImporter from file nsIDirectoryService.idl
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
    /// nsIDirectoryServiceProvider
    ///
    /// Used by Directory Service to get file locations.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("bbf8cab0-d43a-11d3-8cc2-00609792278c")]
	public interface nsIDirectoryServiceProvider
	{
		
		/// <summary>
        /// getFile
        ///
        /// Directory Service calls this when it gets the first request for
        /// a prop or on every request if the prop is not persistent.
        ///
        /// @param prop         The symbolic name of the file.
        /// @param persistent   TRUE - The returned file will be cached by Directory
        /// Service. Subsequent requests for this prop will
        /// bypass the provider and use the cache.
        /// FALSE - The provider will be asked for this prop
        /// each time it is requested.
        ///
        /// @return             The file represented by the property.
        ///
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIFile GetFile([MarshalAs(UnmanagedType.LPStr)] string prop, [MarshalAs(UnmanagedType.Bool)] out bool persistent);
	}
	
	/// <summary>
    /// nsIDirectoryServiceProvider2
    ///
    /// An extension of nsIDirectoryServiceProvider which allows
    /// multiple files to be returned for the given key.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("2f977d4b-5485-11d4-87e2-0010a4e75ef2")]
	public interface nsIDirectoryServiceProvider2 : nsIDirectoryServiceProvider
	{
		
		/// <summary>
        /// getFile
        ///
        /// Directory Service calls this when it gets the first request for
        /// a prop or on every request if the prop is not persistent.
        ///
        /// @param prop         The symbolic name of the file.
        /// @param persistent   TRUE - The returned file will be cached by Directory
        /// Service. Subsequent requests for this prop will
        /// bypass the provider and use the cache.
        /// FALSE - The provider will be asked for this prop
        /// each time it is requested.
        ///
        /// @return             The file represented by the property.
        ///
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIFile GetFile([MarshalAs(UnmanagedType.LPStr)] string prop, [MarshalAs(UnmanagedType.Bool)] out bool persistent);
		
		/// <summary>
        /// getFiles
        ///
        /// Directory Service calls this when it gets a request for
        /// a prop and the requested type is nsISimpleEnumerator.
        ///
        /// @param prop         The symbolic name of the file list.
        ///
        /// @return             An enumerator for a list of file locations.
        /// The elements in the enumeration are nsIFile
        /// @returnCode         NS_SUCCESS_AGGREGATE_RESULT if this result should be
        /// aggregated with other "lower" providers.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISimpleEnumerator GetFiles([MarshalAs(UnmanagedType.LPStr)] string prop);
	}
	
	/// <summary>
    /// nsIDirectoryService
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("57a66a60-d43a-11d3-8cc2-00609792278c")]
	public interface nsIDirectoryService
	{
		
		/// <summary>
        /// init
        ///
        /// Must be called. Used internally by XPCOM initialization.
        ///
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Init();
		
		/// <summary>
        /// registerProvider
        ///
        /// Register a provider with the service.
        ///
        /// @param prov            The service will keep a strong reference
        /// to this object. It will be released when
        /// the service is released.
        ///
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RegisterProvider([MarshalAs(UnmanagedType.Interface)] nsIDirectoryServiceProvider prov);
		
		/// <summary>
        /// unregisterProvider
        ///
        /// Unregister a provider with the service.
        ///
        /// @param prov
        ///
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void UnregisterProvider([MarshalAs(UnmanagedType.Interface)] nsIDirectoryServiceProvider prov);
	}
}
