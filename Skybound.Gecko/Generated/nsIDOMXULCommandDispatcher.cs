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
// Generated by IDLImporter from file nsIDOMXULCommandDispatcher.idl
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
	
	
	/// <summary>nsIDOMXULCommandDispatcher </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("f3c50361-14fe-11d3-bf87-00105a1b0627")]
	public interface nsIDOMXULCommandDispatcher
	{
		
		/// <summary>Member GetFocusedElementAttribute </summary>
		/// <returns>A nsIDOMElement</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMElement GetFocusedElementAttribute();
		
		/// <summary>Member SetFocusedElementAttribute </summary>
		/// <param name='aFocusedElement'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetFocusedElementAttribute([MarshalAs(UnmanagedType.Interface)] nsIDOMElement aFocusedElement);
		
		/// <summary>Member GetFocusedWindowAttribute </summary>
		/// <returns>A nsIDOMWindow</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMWindow GetFocusedWindowAttribute();
		
		/// <summary>Member SetFocusedWindowAttribute </summary>
		/// <param name='aFocusedWindow'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetFocusedWindowAttribute([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aFocusedWindow);
		
		/// <summary>Member AddCommandUpdater </summary>
		/// <param name='updater'> </param>
		/// <param name='events'> </param>
		/// <param name='targets'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddCommandUpdater([MarshalAs(UnmanagedType.Interface)] nsIDOMElement updater, [MarshalAs(UnmanagedType.LPStruct)] nsAString events, [MarshalAs(UnmanagedType.LPStruct)] nsAString targets);
		
		/// <summary>Member RemoveCommandUpdater </summary>
		/// <param name='updater'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveCommandUpdater([MarshalAs(UnmanagedType.Interface)] nsIDOMElement updater);
		
		/// <summary>Member UpdateCommands </summary>
		/// <param name='eventName'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void UpdateCommands([MarshalAs(UnmanagedType.LPStruct)] nsAString eventName);
		
		/// <summary>Member GetControllerForCommand </summary>
		/// <param name='command'> </param>
		/// <returns>A nsIController</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIController GetControllerForCommand([MarshalAs(UnmanagedType.LPStr)] string command);
		
		/// <summary>Member GetControllers </summary>
		/// <returns>A nsIControllers</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIControllers GetControllers();
		
		/// <summary>Member AdvanceFocus </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AdvanceFocus();
		
		/// <summary>Member RewindFocus </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RewindFocus();
		
		/// <summary>Member AdvanceFocusIntoSubtree </summary>
		/// <param name='elt'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AdvanceFocusIntoSubtree([MarshalAs(UnmanagedType.Interface)] nsIDOMElement elt);
		
		/// <summary>Member GetSuppressFocusScrollAttribute </summary>
		/// <returns>A System.Boolean</returns>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetSuppressFocusScrollAttribute();
		
		/// <summary>Member SetSuppressFocusScrollAttribute </summary>
		/// <param name='aSuppressFocusScroll'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetSuppressFocusScrollAttribute([MarshalAs(UnmanagedType.Bool)] bool aSuppressFocusScroll);
	}
}
