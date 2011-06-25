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
// Generated by IDLImporter from file nsIWebBrowserStream.idl
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
    /// This interface provides a way to stream data to the web browser. This allows
    /// loading of data from sources which can not be accessed using URIs and
    /// nsIWebNavigation.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("86d02f0e-219b-4cfc-9c88-bd98d2cce0b8")]
	public interface nsIWebBrowserStream
	{
		
		/// <summary>
        /// Prepare to load a stream of data. When this function returns successfully,
        /// it must be paired by a call to closeStream.
        ///
        /// @param aBaseURI
        /// The base URI of the data. Must not be null. Relative
        /// URIs will be resolved relative to this URI.
        /// @param aContentType
        /// ASCII string giving the content type of the data. If rendering
        /// content of this type is not supported, this method fails.
        /// This string may include a charset declaration, for example:
        /// text/html;charset=ISO-8859-1
        ///
        /// @throw NS_ERROR_NOT_AVAILABLE
        /// The requested content type is not supported.
        /// @throw NS_ERROR_IN_PROGRESS
        /// openStream was called twice without an intermediate closeStream.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OpenStream([MarshalAs(UnmanagedType.Interface)] nsIURI aBaseURI, [MarshalAs(UnmanagedType.LPStruct)] nsAString aContentType);
		
		/// <summary>
        /// Append data to this stream.
        /// @param aData The data to append
        /// @param aLen  Length of the data to append.
        ///
        /// @note To append more than 4 GB of data, call this method multiple times.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AppendToStream(System.IntPtr aData, uint aLen);
		
		/// <summary>
        /// Notifies the browser that all the data has been appended. This may notify
        /// the user that the browser is "done loading" in some form.
        ///
        /// @throw NS_ERROR_UNEXPECTED
        /// This method was called without a preceding openStream.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CloseStream();
	}
}
