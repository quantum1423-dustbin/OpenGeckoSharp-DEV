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
// Generated by IDLImporter from file nsIExceptionService.idl
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
    /// into nsIExceptions
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("0577744c-c1d2-47f2-8bcc-ce7a9e5a88fc")]
	public interface nsIExceptionProvider
	{
		
		/// <summary>
        ///Gets an nsIException or returns NULL if not possible. </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIException GetException(int result, [MarshalAs(UnmanagedType.Interface)] nsIException defaultException);
	}
	
	/// <summary>
    /// to get a script error manager for your current thread.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("efc9d00b-231c-4feb-852c-ac017266a415")]
	public interface nsIExceptionManager
	{
		
		/// <summary>
        ///Sets (or clears with nsnull) the current error on the this thread. </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetCurrentException([MarshalAs(UnmanagedType.Interface)] nsIException error);
		
		/// <summary>
        ///Gets the current error for the current thread, or NULL if no error </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIException GetCurrentException();
		
		/// <summary>
        ///Gets an exception from a registered exception provider..
        ///        This has no effect on the "current exception" </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIException GetExceptionFromProvider(int rc, [MarshalAs(UnmanagedType.Interface)] nsIException defaultException);
	}
	
	/// <summary>
    /// safe manner, or to get an ExceptionManager for your specific thread.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("35A88F54-F267-4414-92A7-191F6454AB52")]
	public interface nsIExceptionService : nsIExceptionManager
	{
		
		/// <summary>
        ///Sets (or clears with nsnull) the current error on the this thread. </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetCurrentException([MarshalAs(UnmanagedType.Interface)] nsIException error);
		
		/// <summary>
        ///Gets the current error for the current thread, or NULL if no error </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIException GetCurrentException();
		
		/// <summary>
        ///Gets an exception from a registered exception provider..
        ///        This has no effect on the "current exception" </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIException GetExceptionFromProvider(int rc, [MarshalAs(UnmanagedType.Interface)] nsIException defaultException);
		
		/// <summary>
        ///Obtains an exception manager for the current thread. </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIExceptionManager GetCurrentExceptionManagerAttribute();
		
		/// <summary>
        ///Installs an "exception provider" which is capable of
        ///        translating an nsresult into an exception.  This enables
        ///        error providers to return simple nsresults and only provide
        ///        rich errors when specifically requested. It also has the
        ///        advantage of allowing code like the DOM to handle all errors
        ///        in a single function rather than at each XPCOM entry point.
        ///        NOTE: This interface must be thread-safe - it will be called
        ///        on whatever thread needs the error translation performed. </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RegisterExceptionProvider([MarshalAs(UnmanagedType.Interface)] nsIExceptionProvider provider, uint moduleCode);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void UnregisterExceptionProvider([MarshalAs(UnmanagedType.Interface)] nsIExceptionProvider provider, uint moduleCode);
	}
}
