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
// Generated by IDLImporter from file nsILoginManagerIEMigrationHelper.idl
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
	
	
	/// <summary>nsILoginManagerIEMigrationHelper </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("8a59ea3d-b8d0-48af-a3e2-63e27a02cde7")]
	public interface nsILoginManagerIEMigrationHelper
	{
		
		/// <summary>
        /// Takes a login provided from nsIEProfileMigrator, migrates it to the
        /// current login manager format, and adds it to the list of stored logins.
        ///
        /// @param aLogin
        /// The login to be migrated.
        ///
        /// Note: In some cases, multiple logins may be created from a single input
        /// when the format is ambigious.
        ///
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void MigrateAndAddLogin([MarshalAs(UnmanagedType.Interface)] nsILoginInfo aLogin);
	}
}
