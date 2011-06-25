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
// Generated by IDLImporter from file xpccomponents.idl
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
    /// interface of Components.classes
    /// (interesting stuff only reflected into JavaScript) </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("978ff520-d26c-11d2-9842-006008962422")]
	public interface nsIXPCComponents_Classes
	{
	}
	
	/// <summary>
    /// interface of Components.classesByID
    /// (interesting stuff only reflected into JavaScript) </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("336a9590-4d19-11d3-9893-006008962422")]
	public interface nsIXPCComponents_ClassesByID
	{
	}
	
	/// <summary>
    /// interface of Components.results
    /// (interesting stuff only reflected into JavaScript) </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("2fc229a0-5860-11d3-9899-006008962422")]
	public interface nsIXPCComponents_Results
	{
	}
	
	/// <summary>
    /// interface of Components.ID
    /// (interesting stuff only reflected into JavaScript) </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("7994a6e0-e028-11d3-8f5d-0010a4e73d9a")]
	public interface nsIXPCComponents_ID
	{
	}
	
	/// <summary>
    /// interface of Components.Exception
    /// (interesting stuff only reflected into JavaScript) </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("5bf039c0-e028-11d3-8f5d-0010a4e73d9a")]
	public interface nsIXPCComponents_Exception
	{
	}
	
	/// <summary>
    /// interface of Components.Constructor
    /// (interesting stuff only reflected into JavaScript) </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("88655640-e028-11d3-8f5d-0010a4e73d9a")]
	public interface nsIXPCComponents_Constructor
	{
	}
	
	/// <summary>
    /// interface of object returned by Components.Constructor
    /// (additional interesting stuff only reflected into JavaScript) </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("c814ca20-e0dc-11d3-8f5f-0010a4e73d9a")]
	public interface nsIXPCConstructor
	{
		
		/// <summary>
        /// interface of object returned by Components.Constructor
        /// (additional interesting stuff only reflected into JavaScript) </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIJSCID GetClassIDAttribute();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIJSIID GetInterfaceIDAttribute();
		
		[return: MarshalAs(UnmanagedType.LPStr)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetInitializerAttribute();
	}
	
	/// <summary>
    /// interface of object returned by Components.utils.Sandbox. </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("4f8ae0dc-d266-4a32-875b-6a9de71a8ce9")]
	public interface nsIXPCComponents_utils_Sandbox
	{
	}
	
	/// <summary>
    /// interface of Components.utils </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("c1d616fa-1875-49ba-b7b8-5861dab31a42")]
	public interface nsIXPCComponents_Utils
	{
		
		/// <summary>
        ///reportError is designed to be called from JavaScript only.
        ///
        /// It will report a JS Error object to the JS console, and return. It
        /// is meant for use in exception handler blocks which want to "eat"
        /// an exception, but still want to report it to the console.
        ///
        /// It must be called with one param, usually an object which was caught by
        /// an exception handler.  If it is not a JS error object, the parameter
        /// is converted to a string and reported as a new error.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ReportError();
		
		/// <summary>
        ///lookupMethod is designed to be called from JavaScript only.
        ///
        /// It returns a method looking only at the idl interfaces and
        /// ignores any overrides or resolvers that might be in place for
        /// a given scriptable wrapped native.
        /// It must be called with two params: an object and a method name.
        /// It returns a function object or throws an exception on error.
        /// This method exists only to solve mozilla browser problems
        /// when chrome attempts to lookup and call methods in content
        /// and *must* not get confused by method properties that have been
        /// replaced in the content JS code. This method is not recommended for
        /// any other use.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void LookupMethod();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIXPCComponents_utils_Sandbox GetSandboxAttribute();
		
		/// <summary>
        ///, obj </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void EvalInSandbox([MarshalAs(UnmanagedType.LPStruct)] nsAString source);
		
		/// <summary>
        ///, [optional] in JSObject targetObj </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Import([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String registryLocation);
		
		/// <summary>
        ///in JSObject obj </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		xpcIJSWeakReference GetWeakReference();
		
		/// <summary>
        /// To be called from JS only.
        ///
        /// Force an immediate garbage collection cycle.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ForceGC();
		
		/// <summary>
        ///in JSObject obj </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetGlobalForObject();
	}
	
	/// <summary>
    /// interface of JavaScript's 'Components' object </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("155809f1-71f1-47c5-be97-d812ba560405")]
	public interface nsIXPCComponents
	{
		
		/// <summary>
        /// interface of JavaScript's 'Components' object </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIScriptableInterfaces GetInterfacesAttribute();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIScriptableInterfacesByID GetInterfacesByIDAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetClassesAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetClassesByIDAttribute();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIStackFrame GetStackAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetResultsAttribute();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIComponentManager GetManagerAttribute();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIXPCComponents_Utils GetUtilsAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetIDAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetExceptionAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetConstructorAttribute();
		
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsSuccessCode(int result);
		
		/// <summary>
        ///DEPRECATED: use Components.utils.lookupMethod instead.
        /// (But are you sure you really want this method any more?
        /// See http://developer-test.mozilla.org/en/docs/XPCNativeWrapper )
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void LookupMethod();
		
		/// <summary>
        ///DEPRECATED: use Components.utils.reportError instead. </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ReportError();
	}
}
