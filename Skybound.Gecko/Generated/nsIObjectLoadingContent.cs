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
// Generated by IDLImporter from file nsIObjectLoadingContent.idl
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
    /// This interface represents a content node that loads objects.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("9558649a-7255-4b00-afb4-1171e9cdcead")]
	public interface nsIObjectLoadingContent
	{
		
		/// <summary>
        /// The actual mime type (the one we got back from the network
        /// request) for the element.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetActualTypeAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aActualType);
		
		/// <summary>
        /// Gets the type of the content that's currently loaded. See
        /// the constants above for the list of possible values.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetDisplayedTypeAttribute();
		
		/// <summary>
        /// Gets the content type that corresponds to the give MIME type.  See the
        /// constants above for the list of possible values.  If nothing else fits,
        /// TYPE_NULL will be returned.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetContentTypeForMIMEType([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String aMimeType);
		
		/// <summary>
        /// Returns the plugin instance if it has already been instantiated. This
        /// will never instantiate the plugin and so is safe to call even when
        /// content script must not execute.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIPluginInstance GetPluginInstanceAttribute();
		
		/// <summary>
        /// Makes sure that a frame for this object exists, and that the plugin is
        /// instantiated. This method does nothing if the type is not #TYPE_PLUGIN.
        /// There is no guarantee that there will be a frame after this method is
        /// called; for example, the node may have a display:none style. If plugin
        /// instantiation is possible, it will be done synchronously by this method,
        /// and the plugin instance will be returned. A success return value does not
        /// necessarily mean that the instance is nonnull.
        ///
        /// This is a noscript method because it is internal and will go away once
        /// plugin loading moves to content.
        ///
        /// @note If there is an error instantiating the plugin, this method will
        /// trigger fallback to replacement content, and the type will change (and
        /// this method will return a failure code)
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIPluginInstance EnsureInstantiation();
		
		/// <summary>
        /// Tells the content about an associated object frame.
        /// This can be called multiple times for different frames.
        ///
        /// This is noscript because this is an internal method that will go away, and
        /// because nsIObjectFrame is unscriptable.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void HasNewFrame(System.IntPtr aFrame);
		
		/// <summary>
        /// Tells the object to paint directly in this location ignoring any
        /// positioning information that may have been provided otherwise
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetAbsoluteScreenPosition([MarshalAs(UnmanagedType.Interface)] nsIDOMElement element, [MarshalAs(UnmanagedType.Interface)] nsIDOMClientRect position, [MarshalAs(UnmanagedType.Interface)] nsIDOMClientRect clip);
		
		/// <summary>
        /// If this object is in going to be printed, this method
        /// returns the nsIObjectFrame object which should be used when
        /// printing the plugin. The returned nsIFrame is in the original document,
        /// not in the static clone.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetPrintFrame();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void PluginCrashed([MarshalAs(UnmanagedType.Interface)] nsIPluginTag pluginTag, [MarshalAs(UnmanagedType.LPStruct)] nsAString pluginDumpID, [MarshalAs(UnmanagedType.LPStruct)] nsAString browserDumpID, [MarshalAs(UnmanagedType.Bool)] bool submittedCrashReport);
	}
}
