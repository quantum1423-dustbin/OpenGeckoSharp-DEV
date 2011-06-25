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
// Generated by IDLImporter from file nsIHttpChannelInternal.idl
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
    /// Dumping ground for http.  This interface will never be frozen.  If you are
    /// using any feature exposed by this interface, be aware that this interface
    /// will change and you will be broken.  You have been warned.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("9fb2a161-d075-4bf2-b07a-26bac650cc81")]
	public interface nsIHttpChannelInternal
	{
		
		/// <summary>
        /// An http channel can own a reference to the document URI
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURI GetDocumentURIAttribute();
		
		/// <summary>
        /// An http channel can own a reference to the document URI
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDocumentURIAttribute([MarshalAs(UnmanagedType.Interface)] nsIURI aDocumentURI);
		
		/// <summary>
        /// Get the major/minor version numbers for the request
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetRequestVersion(out uint major, out uint minor);
		
		/// <summary>
        /// Get the major/minor version numbers for the response
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetResponseVersion(out uint major, out uint minor);
		
		/// <summary>
        /// Helper method to set a cookie with a consumer-provided
        /// cookie header, _but_ using the channel's other information
        /// (URI's, prompters, date headers etc).
        ///
        /// @param aCookieHeader
        /// The cookie header to be parsed.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetCookie([MarshalAs(UnmanagedType.LPStr)] string aCookieHeader);
		
		/// <summary>
        /// Setup this channel as an application cache fallback channel.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetupFallbackChannel([MarshalAs(UnmanagedType.LPStr)] string aFallbackKey);
		
		/// <summary>
        /// Force relevant cookies to be sent with this load even if normally they
        /// wouldn't be.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetForceAllowThirdPartyCookieAttribute();
		
		/// <summary>
        /// Force relevant cookies to be sent with this load even if normally they
        /// wouldn't be.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetForceAllowThirdPartyCookieAttribute([MarshalAs(UnmanagedType.Bool)] bool aForceAllowThirdPartyCookie);
		
		/// <summary>
        /// Returns true iff the channel has been canceled.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetCanceledAttribute();
		
		/// <summary>
        /// Lets externalhandler tell the channel it is open on behalf of a download
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetChannelIsForDownloadAttribute();
		
		/// <summary>
        /// Lets externalhandler tell the channel it is open on behalf of a download
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetChannelIsForDownloadAttribute([MarshalAs(UnmanagedType.Bool)] bool aChannelIsForDownload);
	}
}
