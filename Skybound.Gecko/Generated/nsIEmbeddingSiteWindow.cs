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
// Generated by IDLImporter from file nsIEmbeddingSiteWindow.idl
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
    /// The nsIEmbeddingSiteWindow is implemented by the embedder to provide
    /// Gecko with the means to call up to the host to resize the window,
    /// hide or show it and set/get its title.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("3E5432CD-9568-4bd1-8CBE-D50ABA110743")]
	public interface nsIEmbeddingSiteWindow
	{
		
		/// <summary>
        /// Sets the dimensions for the window; the position & size. The
        /// flags to indicate what the caller wants to set and whether the size
        /// refers to the inner or outer area. The inner area refers to just
        /// the embedded area, wheras the outer area can also include any
        /// surrounding chrome, window frame, title bar, and so on.
        ///
        /// @param flags  Combination of position, inner and outer size flags.
        /// @param x      Left hand corner of the outer area.
        /// @param y      Top corner of the outer area.
        /// @param cx     Width of the inner or outer area.
        /// @param cy     Height of the inner or outer area.
        ///
        /// @return <code>NS_OK</code> if operation was performed correctly;
        /// <code>NS_ERROR_UNEXPECTED</code> if window could not be
        /// destroyed;
        /// <code>NS_ERROR_INVALID_ARG</code> for bad flag combination
        /// or illegal dimensions.
        ///
        /// @see getDimensions
        /// @see DIM_FLAGS_POSITION
        /// @see DIM_FLAGS_SIZE_OUTER
        /// @see DIM_FLAGS_SIZE_INNER
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDimensions(uint flags, int x, int y, int cx, int cy);
		
		/// <summary>
        /// Gets the dimensions of the window. The caller may pass
        /// <CODE>nsnull</CODE> for any value it is uninterested in receiving.
        ///
        /// @param flags  Combination of position, inner and outer size flag .
        /// @param x      Left hand corner of the outer area; or <CODE>nsnull</CODE>.
        /// @param y      Top corner of the outer area; or <CODE>nsnull</CODE>.
        /// @param cx     Width of the inner or outer area; or <CODE>nsnull</CODE>.
        /// @param cy     Height of the inner or outer area; or <CODE>nsnull</CODE>.
        ///
        /// @see setDimensions
        /// @see DIM_FLAGS_POSITION
        /// @see DIM_FLAGS_SIZE_OUTER
        /// @see DIM_FLAGS_SIZE_INNER
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetDimensions(uint flags, out int x, out int y, out int cx, out int cy);
		
		/// <summary>
        /// Give the window focus.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetFocus();
		
		/// <summary>
        /// Visibility of the window.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetVisibilityAttribute();
		
		/// <summary>
        /// Visibility of the window.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetVisibilityAttribute([MarshalAs(UnmanagedType.Bool)] bool aVisibility);
		
		/// <summary>
        /// Title of the window.
        /// </summary>
		[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.CustomMarshalers.WStringMarshaler")]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetTitleAttribute();
		
		/// <summary>
        /// Title of the window.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetTitleAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.CustomMarshalers.WStringMarshaler")] string aTitle);
		
		/// <summary>
        /// Native window for the site's window. The implementor should copy the
        /// native window object into the address supplied by the caller. The
        /// type of the native window that the address refers to is  platform
        /// and OS specific as follows:
        ///
        /// <ul>
        /// <li>On Win32 it is an <CODE>HWND</CODE>.</li>
        /// <li>On MacOS this is a <CODE>WindowPtr</CODE>.</li>
        /// <li>On GTK this is a <CODE>GtkWidget*</CODE>.</li>
        /// </ul>
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetSiteWindowAttribute();
	}
}
