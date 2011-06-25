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
// Generated by IDLImporter from file mozITXTToHTMLConv.idl
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
    ///Description: Currently only functions to enhance plain text with HTML tags.
    ///  <p>
    ///  Wrapper class for various parsing routines, that convert plain text to HTML.
    ///  They try to recognize cites, URLs, plain text formattting like *bold* etc.
    ///  See <http://www.bucksch.org/1/projects/mozilla/16507/> for a description.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("77c0e42a-1dd2-11b2-8ebf-edc6606f2f4b")]
	public interface mozITXTToHTMLConv : nsIStreamConverter
	{
		
		/// <summary>
        /// Called to signify the beginning of an asynchronous request.
        ///
        /// @param aRequest request being observed
        /// @param aContext user defined context
        ///
        /// An exception thrown from onStartRequest has the side-effect of
        /// causing the request to be canceled.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void OnStartRequest([MarshalAs(UnmanagedType.Interface)] nsIRequest aRequest, [MarshalAs(UnmanagedType.Interface)] nsISupports aContext);
		
		/// <summary>
        /// Called to signify the end of an asynchronous request.  This
        /// call is always preceded by a call to onStartRequest.
        ///
        /// @param aRequest request being observed
        /// @param aContext user defined context
        /// @param aStatusCode reason for stopping (NS_OK if completed successfully)
        ///
        /// An exception thrown from onStopRequest is generally ignored.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void OnStopRequest([MarshalAs(UnmanagedType.Interface)] nsIRequest aRequest, [MarshalAs(UnmanagedType.Interface)] nsISupports aContext, int aStatusCode);
		
		/// <summary>
        /// Called when the next chunk of data (corresponding to the request) may
        /// be read without blocking the calling thread.  The onDataAvailable impl
        /// must read exactly |aCount| bytes of data before returning.
        ///
        /// @param aRequest request corresponding to the source of the data
        /// @param aContext user defined context
        /// @param aInputStream input stream containing the data chunk
        /// @param aOffset
        /// Number of bytes that were sent in previous onDataAvailable calls
        /// for this request. In other words, the sum of all previous count
        /// parameters.
        /// If that number is greater than or equal to 2^32, this parameter
        /// will be PR_UINT32_MAX (2^32 - 1).
        /// @param aCount number of bytes available in the stream
        ///
        /// NOTE: The aInputStream parameter must implement readSegments.
        ///
        /// An exception thrown from onDataAvailable has the side-effect of
        /// causing the request to be canceled.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void OnDataAvailable([MarshalAs(UnmanagedType.Interface)] nsIRequest aRequest, [MarshalAs(UnmanagedType.Interface)] nsISupports aContext, [MarshalAs(UnmanagedType.Interface)] nsIInputStream aInputStream, uint aOffset, uint aCount);
		
		/// <summary>
        /// <b>SYNCRONOUS VERSION</b>
        /// Converts a stream of one type, to a stream of another type.
        ///
        /// Use this method when you have a stream you want to convert.
        ///
        /// @param aFromStream   The stream representing the original/raw data.
        /// @param aFromType     The MIME type of aFromStream.
        /// @param aToType       The MIME type of the returned stream.
        /// @param aCtxt         Either an opaque context, or a converter specific context
        /// (implementation specific).
        /// @return              The converted stream. NOTE: The returned stream may not
        /// already be converted. An efficient stream converter
        /// implementation will converter data on demand rather than
        /// buffering the converted data until it is used.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIInputStream Convert([MarshalAs(UnmanagedType.Interface)] nsIInputStream aFromStream, [MarshalAs(UnmanagedType.LPStr)] string aFromType, [MarshalAs(UnmanagedType.LPStr)] string aToType, [MarshalAs(UnmanagedType.Interface)] nsISupports aCtxt);
		
		/// <summary>
        /// <b>ASYNCRONOUS VERSION</b>
        /// Converts data arriving via the converter's nsIStreamListener::OnDataAvailable()
        /// method from one type to another, pushing the converted data out to the caller
        /// via aListener::OnDataAvailable().
        ///
        /// Use this method when you want to proxy (and convert) nsIStreamListener callbacks
        /// asynchronously.
        ///
        /// @param aFromType     The MIME type of the original/raw data.
        /// @param aToType       The MIME type of the converted data.
        /// @param aListener     The listener who receives the converted data.
        /// @param aCtxt         Either an opaque context, or a converter specific context
        /// (implementation specific).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void AsyncConvertData([MarshalAs(UnmanagedType.LPStr)] string aFromType, [MarshalAs(UnmanagedType.LPStr)] string aToType, [MarshalAs(UnmanagedType.Interface)] nsIStreamListener aListener, [MarshalAs(UnmanagedType.Interface)] nsISupports aCtxt);
		
		/// <summary>
        ///@param text: plain text to scan. May be a line, paragraph (recommended)
        ///               or just a substring.<p>
        ///               Must be non-escaped, pure unicode.<p>
        ///               <em>Note:</em> ScanTXT(a, o) + ScanTXT(b, o) may be !=
        ///               Scan(a + b, o)
        ///  @param whattodo: Bitfield describing the modes of operation
        ///  @result      "<", ">" and "&" are escaped and HTML tags are inserted where
        ///               appropriate.
        /// </summary>
		[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.CustomMarshalers.WStringMarshaler")]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string ScanTXT([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.CustomMarshalers.WStringMarshaler")] string text, uint whattodo);
		
		/// <summary>
        ///Adds additional formatting to user edited text, that the user was too lazy
        ///  or "unknowledged" (DELETEME: is that a word?) to make.
        ///  <p>
        ///  <em>Note:</em> Don't use kGlyphSubstitution with this function. This option
        ///  generates tags, that are unuseable for UAs other than Mozilla. This would
        ///  be a data loss bug.
        ///  @param text: HTML source to scan. May be a line, paragraph (recommended)
        ///               or just a substring.<p>
        ///               Must be correct HTML. "<", ">" and "&" must be escaped,
        ///               other chars must be pure unicode.<p>
        ///               <em>Note:</em> ScanTXT(a, o) + ScanTXT(b, o) may be !=
        ///               Scan(a + b, o)
        ///  @param whattodo: Bitfield describing the modes of operation
        ///  @result      Additional HTML tags are inserted where appropriate.
        /// </summary>
		[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.CustomMarshalers.WStringMarshaler")]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string ScanHTML([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.CustomMarshalers.WStringMarshaler")] string text, uint whattodo);
		
		/// <summary>
        ///@param line: line in original msg, possibly starting starting with
        ///               txt quote tags like ">"
        ///  @param logLineStart: pos in line, where the real content (logical line)
        ///               begins, i.e. pos after all txt quote tags.
        ///               E.g. position of "t" in "> > text".
        ///               Initial value must be 0, unless line is not real line.
        ///  @return      Cite Level, i.e. number of txt quote tags found, i.e. number of
        ///               nested quotes.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint CiteLevelTXT([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.CustomMarshalers.WStringMarshaler")] string line, out uint logLineStart);
		
		/// <summary>
        ///@param a wide string to scan for the presence of a URL.
        /// @param aLength --> the length of the buffer to be scanned
        /// @param aPos --> the position in the buffer to start scanning for a url
        /// aStartPos --> index into the start of a url (-1 if no url found)
        /// aEndPos --> index of the last character in the url (-1 if no url found)
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void FindURLInPlaintext([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.CustomMarshalers.WStringMarshaler")] string text, int aLength, int aPos, out int aStartPos, out int aEndPos);
	}
}
