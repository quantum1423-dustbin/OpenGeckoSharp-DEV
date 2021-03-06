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
// Generated by IDLImporter from file nsIPluginStreamListener.idl
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
    /// The nsIPluginStreamListener interface defines the minimum set of functionality that
    /// the browser will support if it allows plugins. Plugins can call QueryInterface
    /// to determine if a plugin manager implements more specific APIs or other
    /// browser interfaces for the plugin to use (e.g. nsINetworkManager).
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("02C9DAD7-D9DD-4F36-BD5E-93CA404A31BC")]
	public interface nsIPluginStreamListener
	{
		
		/// <summary>
        /// Notify the observer that the URL has started to load.  This method is
        /// called only once, at the beginning of a URL load.<BR><BR>
        ///
        /// @param aPluginInfo  - plugin stream info
        /// @return             - the return value is currently ignored, in the future
        /// it may be used to cancel the URL load..
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnStartBinding([MarshalAs(UnmanagedType.Interface)] nsIPluginStreamInfo aPluginInfo);
		
		/// <summary>
        /// Notify the client that data is available in the input stream.  This
        /// method is called whenver data is written into the input stream by the
        /// networking library...<BR><BR>
        ///
        /// @param aPluginInfo  - plugin stream info
        /// @param aInputStream - the input stream containing the data. This stream can
        /// be either a blocking or non-blocking stream.
        /// @param aLength      - the amount of data that was just pushed into the stream.
        /// @return             - the return value is currently ignored.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnDataAvailable([MarshalAs(UnmanagedType.Interface)] nsIPluginStreamInfo aPluginInfo, [MarshalAs(UnmanagedType.Interface)] nsIInputStream aInputStream, uint aLength);
		
		/// <summary>
        /// Notify the client that data is available in the file.
        ///
        /// @param aPluginInfo - plugin stream info
        /// @param aFileName   - the name of the file containing the data
        /// @return            - the return value is currently ignored.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnFileAvailable([MarshalAs(UnmanagedType.Interface)] nsIPluginStreamInfo aPluginInfo, [MarshalAs(UnmanagedType.LPStr)] string aFileName);
		
		/// <summary>
        /// Notify the observer that the URL has finished loading.  This method is
        /// called once when the networking library has finished processing the
        /// URL transaction initiatied via the nsINetService::Open(...) call.<BR><BR>
        ///
        /// This method is called regardless of whether the URL loaded successfully.<BR><BR>
        ///
        /// @param aPluginInfo - plugin stream info
        /// @param aStatus     - reason why the stream has been terminated
        /// @return            - the return value is currently ignored.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnStopBinding([MarshalAs(UnmanagedType.Interface)] nsIPluginStreamInfo aPluginInfo, int aStatus);
		
		/// <summary>
        /// Gets the type of the stream
        ///
        /// @param aStreamType - the type of the stream
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetStreamTypeAttribute();
	}
}
