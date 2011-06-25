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
// Generated by IDLImporter from file nsIHttpAuthManager.idl
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
    /// nsIHttpAuthManager
    ///
    /// This service provides access to cached HTTP authentication
    /// user credentials (domain, username, password) for sites
    /// visited during the current browser session.
    ///
    /// This interface exists to provide other HTTP stacks with the
    /// ability to share HTTP authentication credentials with Necko.
    /// This is currently used by the Java plugin (version 1.5 and
    /// higher) to avoid duplicate authentication prompts when the
    /// Java client fetches content from a HTTP site that the user
    /// has already logged into.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("7ce8e9d1-8b4b-4883-a307-66fe12a50153")]
	public interface nsIHttpAuthManager
	{
		
		/// <summary>
        /// Lookup auth identity.
        ///
        /// @param aScheme
        /// the URL scheme (e.g., "http").  NOTE: for proxy authentication,
        /// this should be "http" (this includes authentication for SSL
        /// tunneling).
        /// @param aHost
        /// the host of the server issuing a challenge (ASCII only).
        /// @param aPort
        /// the port of the server issuing a challenge.
        /// @param aAuthType
        /// optional string identifying auth type used (e.g., "basic")
        /// @param aRealm
        /// optional string identifying auth realm.
        /// @param aPath
        /// optional string identifying auth path. empty for proxy auth.
        /// @param aUserDomain
        /// return value containing user domain.
        /// @param aUserName
        /// return value containing user name.
        /// @param aUserPassword
        /// return value containing user password.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetAuthIdentity([MarshalAs(UnmanagedType.LPStruct)] nsAString aScheme, [MarshalAs(UnmanagedType.LPStruct)] nsAString aHost, int aPort, [MarshalAs(UnmanagedType.LPStruct)] nsAString aAuthType, [MarshalAs(UnmanagedType.LPStruct)] nsAString aRealm, [MarshalAs(UnmanagedType.LPStruct)] nsAString aPath, [MarshalAs(UnmanagedType.LPStruct)] nsAString aUserDomain, [MarshalAs(UnmanagedType.LPStruct)] nsAString aUserName, [MarshalAs(UnmanagedType.LPStruct)] nsAString aUserPassword);
		
		/// <summary>
        /// Store auth identity.
        ///
        /// @param aScheme
        /// the URL scheme (e.g., "http").  NOTE: for proxy authentication,
        /// this should be "http" (this includes authentication for SSL
        /// tunneling).
        /// @param aHost
        /// the host of the server issuing a challenge (ASCII only).
        /// @param aPort
        /// the port of the server issuing a challenge.
        /// @param aAuthType
        /// optional string identifying auth type used (e.g., "basic")
        /// @param aRealm
        /// optional string identifying auth realm.
        /// @param aPath
        /// optional string identifying auth path. empty for proxy auth.
        /// @param aUserDomain
        /// optional string containing user domain.
        /// @param aUserName
        /// optional string containing user name.
        /// @param aUserPassword
        /// optional string containing user password.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetAuthIdentity([MarshalAs(UnmanagedType.LPStruct)] nsAString aScheme, [MarshalAs(UnmanagedType.LPStruct)] nsAString aHost, int aPort, [MarshalAs(UnmanagedType.LPStruct)] nsAString aAuthType, [MarshalAs(UnmanagedType.LPStruct)] nsAString aRealm, [MarshalAs(UnmanagedType.LPStruct)] nsAString aPath, [MarshalAs(UnmanagedType.LPStruct)] nsAString aUserDomain, [MarshalAs(UnmanagedType.LPStruct)] nsAString aUserName, [MarshalAs(UnmanagedType.LPStruct)] nsAString aUserPassword);
		
		/// <summary>
        /// Clear all auth cache.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ClearAll();
	}
}
