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
// Generated by IDLImporter from file nsISAXContentHandler.idl
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
    /// Receive notification of the logical content of a document.
    ///
    /// This is the main interface that most SAX applications implement: if
    /// the application needs to be informed of basic parsing events, it
    /// implements this interface and registers an instance with the SAX
    /// parser.  The parser uses the instance to report basic
    /// document-related events like the start and end of elements and
    /// character data.
    ///
    /// The order of events in this interface is very important, and
    /// mirrors the order of information in the document itself.  For
    /// example, all of an element's content (character data, processing
    /// instructions, and/or subelements) will appear, in order, between
    /// the startElement event and the corresponding endElement event.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("2a99c757-dfee-4806-bff3-f721440412e0")]
	public interface nsISAXContentHandler
	{
		
		/// <summary>
        /// Receive notification of the beginning of a document.
        ///
        /// The SAX parser will invoke this method only once, before any
        /// other event callbacks.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void StartDocument();
		
		/// <summary>
        /// Receive notification of the end of a document.
        ///
        /// There is an apparent contradiction between the documentation for
        /// this method and the documentation for ErrorHandler.fatalError().
        /// Until this ambiguity is resolved in a future major release,
        /// clients should make no assumptions about whether endDocument()
        /// will or will not be invoked when the parser has reported a
        /// fatalError() or thrown an exception.
        ///
        /// The SAX parser will invoke this method only once, and it will be
        /// the last method invoked during the parse.  The parser shall not
        /// invoke this method until it has either abandoned parsing (because
        /// of an unrecoverable error) or reached the end of input.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void EndDocument();
		
		/// <summary>
        /// Receive notification of the beginning of an element.
        ///
        /// The Parser will invoke this method at the beginning of every
        /// element in the XML document; there will be a corresponding
        /// endElement event for every startElement event (even when the
        /// element is empty). All of the element's content will be reported,
        /// in order, before the corresponding endElement event.
        ///
        /// This event allows up to three name components for each element:
        ///
        /// 1.) the Namespace URI;
        /// 2.) the local name; and
        /// 3.) the qualified (prefixed) name.
        ///
        /// Any or all of these may be provided, depending on the values of
        /// the http://xml.org/sax/features/namespaces and the
        /// http://xml.org/sax/features/namespace-prefixes properties:
        ///
        /// The Namespace URI and local name are required when the namespaces
        /// property is true (the default), and are optional when the
        /// namespaces property is false (if one is specified, both must be);
        ///
        /// The qualified name is required when the namespace-prefixes
        /// property is true, and is optional when the namespace-prefixes
        /// property is false (the default).
        ///
        /// Note that the attribute list provided will contain only
        /// attributes with explicit values (specified or defaulted):
        /// #IMPLIED attributes will be omitted.  The attribute list will
        /// contain attributes used for Namespace declarations (xmlns*
        /// attributes) only if the
        /// http://xml.org/sax/features/namespace-prefixes property is true
        /// (it is false by default, and support for a true value is
        /// optional).
        ///
        /// @param uri the Namespace URI, or the empty string if the
        /// element has no Namespace URI or if Namespace
        /// processing is not being performed
        /// @param localName the local name (without prefix), or the
        /// empty string if Namespace processing is not being
        /// performed
        /// @param qName the qualified name (with prefix), or the
        /// empty string if qualified names are not available
        /// @param atts the attributes attached to the element.  If
        /// there are no attributes, it shall be an empty
        /// SAXAttributes object.  The value of this object after
        /// startElement returns is undefined
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void StartElement([MarshalAs(UnmanagedType.LPStruct)] nsAString uri, [MarshalAs(UnmanagedType.LPStruct)] nsAString localName, [MarshalAs(UnmanagedType.LPStruct)] nsAString qName, [MarshalAs(UnmanagedType.Interface)] nsISAXAttributes attributes);
		
		/// <summary>
        /// Receive notification of the end of an element.
        ///
        /// The SAX parser will invoke this method at the end of every
        /// element in the XML document; there will be a corresponding
        /// startElement event for every endElement event (even when the
        /// element is empty).
        ///
        /// For information on the names, see startElement.
        ///
        /// @param uri the Namespace URI, or the empty string if the
        /// element has no Namespace URI or if Namespace
        /// processing is not being performed
        /// @param localName the local name (without prefix), or the
        /// empty string if Namespace processing is not being
        /// performed
        /// @param qName the qualified XML name (with prefix), or the
        /// empty string if qualified names are not available
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void EndElement([MarshalAs(UnmanagedType.LPStruct)] nsAString uri, [MarshalAs(UnmanagedType.LPStruct)] nsAString localName, [MarshalAs(UnmanagedType.LPStruct)] nsAString qName);
		
		/// <summary>
        /// Receive notification of character data.
        ///
        /// The Parser will call this method to report each chunk of
        /// character data.  SAX parsers may return all contiguous character
        /// data in a single chunk, or they may split it into several chunks;
        /// however, all of the characters in any single event must come from
        /// the same external entity so that the Locator provides useful
        /// information.
        ///
        /// Note that some parsers will report whitespace in element
        /// content using the ignorableWhitespace method rather than this one
        /// (validating parsers must do so).
        ///
        /// @param value the characters from the XML document
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Characters([MarshalAs(UnmanagedType.LPStruct)] nsAString value);
		
		/// <summary>
        /// Receive notification of a processing instruction.
        ///
        /// The Parser will invoke this method once for each processing
        /// instruction found: note that processing instructions may occur
        /// before or after the main document element.
        ///
        /// A SAX parser must never report an XML declaration (XML 1.0,
        /// section 2.8) or a text declaration (XML 1.0, section 4.3.1) using
        /// this method.
        ///
        /// @param target the processing instruction target
        /// @param data the processing instruction data, or null if
        /// none was supplied.  The data does not include any
        /// whitespace separating it from the target
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ProcessingInstruction([MarshalAs(UnmanagedType.LPStruct)] nsAString target, [MarshalAs(UnmanagedType.LPStruct)] nsAString data);
		
		/// <summary>
        /// Receive notification of ignorable whitespace in element content.
        ///
        /// Validating Parsers must use this method to report each chunk of
        /// whitespace in element content (see the W3C XML 1.0
        /// recommendation, section 2.10): non-validating parsers may also
        /// use this method if they are capable of parsing and using content
        /// models.
        ///
        /// SAX parsers may return all contiguous whitespace in a single
        /// chunk, or they may split it into several chunks; however, all of
        /// the characters in any single event must come from the same
        /// external entity, so that the Locator provides useful information.
        ///
        /// @param whitespace the characters from the XML document
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void IgnorableWhitespace([MarshalAs(UnmanagedType.LPStruct)] nsAString whitespace);
		
		/// <summary>
        /// Begin the scope of a prefix-URI Namespace mapping.
        ///
        /// The information from this event is not necessary for normal
        /// Namespace processing: the SAX XML reader will automatically
        /// replace prefixes for element and attribute names when the
        /// http://xml.org/sax/features/namespaces feature is
        /// true (the default).
        ///
        /// There are cases, however, when applications need to use prefixes
        /// in character data or in attribute values, where they cannot
        /// safely be expanded automatically; the start/endPrefixMapping
        /// event supplies the information to the application to expand
        /// prefixes in those contexts itself, if necessary.
        ///
        /// Note that start/endPrefixMapping events are not guaranteed to be
        /// properly nested relative to each other: all startPrefixMapping
        /// events will occur immediately before the corresponding
        /// startElement event, and all endPrefixMapping events will occur
        /// immediately after the corresponding endElement event, but their
        /// order is not otherwise guaranteed.
        ///
        /// There should never be start/endPrefixMapping events for the
        /// "xml" prefix, since it is predeclared and immutable.
        ///
        /// @param prefix The Namespace prefix being declared. An empty
        /// string is used for the default element namespace,
        /// which has no prefix.
        /// @param uri The Namespace URI the prefix is mapped to.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void StartPrefixMapping([MarshalAs(UnmanagedType.LPStruct)] nsAString prefix, [MarshalAs(UnmanagedType.LPStruct)] nsAString uri);
		
		/// <summary>
        /// End the scope of a prefix-URI mapping.
        ///
        /// See startPrefixMapping for details.  These events will always
        /// occur immediately after the corresponding endElement event, but
        /// the order of endPrefixMapping events is not otherwise guaranteed.
        ///
        /// @param prefix The prefix that was being mapped. This is the empty
        /// string when a default mapping scope ends.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void EndPrefixMapping([MarshalAs(UnmanagedType.LPStruct)] nsAString prefix);
	}
}
