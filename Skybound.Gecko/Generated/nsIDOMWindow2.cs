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
// Generated by IDLImporter from file nsIDOMWindow2.idl
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
	
	
	/// <summary>nsIDOMWindow2 </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("efff0d88-3b94-4375-bdeb-676a847ecd7d")]
	public interface nsIDOMWindow2 : nsIDOMWindow
	{
		
		/// <summary>
        /// Accessor for the document in this window.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMDocument GetDocumentAttribute();
		
		/// <summary>
        /// Accessor for this window's parent window, or the window itself if
        /// there is no parent, or if the parent is of different type
        /// (i.e. this does not cross chrome-content boundaries).
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMWindow GetParentAttribute();
		
		/// <summary>
        /// Accessor for the root of this hierarchy of windows. This root may
        /// be the window itself if there is no parent, or if the parent is
        /// of different type (i.e. this does not cross chrome-content
        /// boundaries).
        ///
        /// This property is "replaceable" in JavaScript </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMWindow GetTopAttribute();
		
		/// <summary>
        /// Accessor for the object that controls whether or not scrollbars
        /// are shown in this window.
        ///
        /// This attribute is "replaceable" in JavaScript
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMBarProp GetScrollbarsAttribute();
		
		/// <summary>
        /// Accessor for the child windows in this window.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMWindowCollection GetFramesAttribute();
		
		/// <summary>
        /// Set/Get the name of this window.
        ///
        /// This attribute is "replaceable" in JavaScript
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aName);
		
		/// <summary>
        /// Set/Get the name of this window.
        ///
        /// This attribute is "replaceable" in JavaScript
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aName);
		
		/// <summary>
        /// Set/Get the document scale factor as a multiplier on the default
        /// size. When setting this attribute, a NS_ERROR_NOT_IMPLEMENTED
        /// error may be returned by implementations not supporting
        /// zoom. Implementations not supporting zoom should return 1.0 all
        /// the time for the Get operation. 1.0 is equals normal size,
        /// i.e. no zoom.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new double GetTextZoomAttribute();
		
		/// <summary>
        /// Set/Get the document scale factor as a multiplier on the default
        /// size. When setting this attribute, a NS_ERROR_NOT_IMPLEMENTED
        /// error may be returned by implementations not supporting
        /// zoom. Implementations not supporting zoom should return 1.0 all
        /// the time for the Get operation. 1.0 is equals normal size,
        /// i.e. no zoom.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetTextZoomAttribute(double aTextZoom);
		
		/// <summary>
        /// Accessor for the current x scroll position in this window in
        /// pixels.
        ///
        /// This attribute is "replaceable" in JavaScript
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new int GetScrollXAttribute();
		
		/// <summary>
        /// Accessor for the current y scroll position in this window in
        /// pixels.
        ///
        /// This attribute is "replaceable" in JavaScript
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new int GetScrollYAttribute();
		
		/// <summary>
        /// Method for scrolling this window to an absolute pixel offset.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void ScrollTo(int xScroll, int yScroll);
		
		/// <summary>
        /// Method for scrolling this window to a pixel offset relative to
        /// the current scroll position.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void ScrollBy(int xScrollDif, int yScrollDif);
		
		/// <summary>
        /// Method for accessing this window's selection object.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsISelection GetSelection();
		
		/// <summary>
        /// Method for scrolling this window by a number of lines.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void ScrollByLines(int numLines);
		
		/// <summary>
        /// Method for scrolling this window by a number of pages.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void ScrollByPages(int numPages);
		
		/// <summary>
        /// Method for sizing this window to the content in the window.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SizeToContent();
		
		/// <summary>
        /// Get the window root for this window. This is useful for hooking
        /// up event listeners to this window and every other window nested
        /// in the window root.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMEventTarget GetWindowRootAttribute();
		
		/// <summary>
        /// Get the application cache object for this window.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMOfflineResourceList GetApplicationCacheAttribute();
		
		/// <summary>
        /// Deprecated, but can't remove yet since we don't want to change interfaces.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CreateBlobURL([MarshalAs(UnmanagedType.Interface)] nsIDOMBlob blob, [MarshalAs(UnmanagedType.LPStruct)] nsAString retval);
		
		/// <summary>Member RevokeBlobURL </summary>
		/// <param name='URL'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RevokeBlobURL([MarshalAs(UnmanagedType.LPStruct)] nsAString URL);
	}
}
