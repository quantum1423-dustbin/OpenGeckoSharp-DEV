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
// Generated by IDLImporter from file nsIExternalSharingAppService.idl
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
	
	
	/// <summary>nsISharingHandlerApp </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("7111f769-53ec-41fd-b314-613661d5b6ba")]
	public interface nsISharingHandlerApp : nsIHandlerApp
	{
		
		/// <summary>
        /// Human readable name for the handler
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aName);
		
		/// <summary>
        /// Human readable name for the handler
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aName);
		
		/// <summary>
        /// Detailed description for this handler. Suitable for
        /// a tooltip or short informative sentence.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetDetailedDescriptionAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aDetailedDescription);
		
		/// <summary>
        /// Detailed description for this handler. Suitable for
        /// a tooltip or short informative sentence.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetDetailedDescriptionAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aDetailedDescription);
		
		/// <summary>
        /// Whether or not the given handler app is logically equivalent to the
        /// invokant (i.e. they represent the same app).
        ///
        /// Two apps are the same if they are both either local or web handlers
        /// and their executables/URI templates and command line parameters are
        /// the same.
        ///
        /// @param aHandlerApp the handler app to compare to the invokant
        ///
        /// @returns true if the two are logically equivalent, false otherwise
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool Equals([MarshalAs(UnmanagedType.Interface)] nsIHandlerApp aHandlerApp);
		
		/// <summary>
        /// Launches the application with the specified URI.
        ///
        /// @param aURI
        /// The URI to launch this application with
        ///
        /// @param aWindowContext
        ///
        /// Currently only relevant to web-handler apps.  If given, this
        /// represents the docshell to load the handler in and is passed
        /// through to nsIURILoader.openURI.  If this parameter is null or
        /// not present, the web handler app implementation will attempt to
        /// find/create a place to load the handler and do so.  As of this
        /// writing, it tries to load the web handler in a new window using
        /// nsIBrowserDOMWindow.openURI.  In the future, it may attempt to
        /// have a more comprehensive strategy which could include handing
        /// off to the system default browser (bug 394479).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void LaunchWithURI([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.Interface)] nsIInterfaceRequestor aWindowContext);
		
		/// <summary>Member Share </summary>
		/// <param name='data'> </param>
		/// <param name='title'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Share([MarshalAs(UnmanagedType.LPStruct)] nsAString data, [MarshalAs(UnmanagedType.LPStruct)] nsAString title);
	}
	
	/// <summary>nsIExternalSharingAppService </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("cf7d04e5-3892-482e-81bb-073dc1c83f76")]
	public interface nsIExternalSharingAppService
	{
		
		/// <summary>Member ShareWithDefault </summary>
		/// <param name='data'> </param>
		/// <param name='mime'> </param>
		/// <param name='title'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ShareWithDefault([MarshalAs(UnmanagedType.LPStruct)] nsAString data, [MarshalAs(UnmanagedType.LPStruct)] nsAString mime, [MarshalAs(UnmanagedType.LPStruct)] nsAString title);
		
		/// <summary>Member GetSharingApps </summary>
		/// <param name='aMIMEType'> </param>
		/// <param name='aLen'> </param>
		/// <returns>A nsISharingHandlerApp</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISharingHandlerApp GetSharingApps([MarshalAs(UnmanagedType.LPStruct)] nsAString aMIMEType, out uint aLen);
	}
}
