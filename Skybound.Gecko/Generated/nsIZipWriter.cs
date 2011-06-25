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
// Generated by IDLImporter from file nsIZipWriter.idl
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
    /// nsIZipWriter
    ///
    /// An interface for a zip archiver that can be used from script.
    ///
    /// The interface supports both a synchronous method of archiving data and a
    /// queueing system to allow operations to be prepared then run in sequence
    /// with notification after completion.
    ///
    /// Operations added to the queue do not get performed until performQueue is
    /// called at which point they will be performed in the order that they were
    /// added to the queue.
    ///
    /// Operations performed on the queue will throw any errors out to the
    /// observer.
    ///
    /// An attempt to perform a synchronous operation while the background queue
    /// is in progress will throw NS_ERROR_IN_PROGRESS.
    ///
    /// Entry names should use /'s as path separators and should not start with
    /// a /.
    ///
    /// It is not generally necessary to add directory entries in order to add file
    /// entries within them, however it is possible that some zip programs may
    /// experience problems what that.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("6d4ef074-206c-4649-9884-57bc355864d6")]
	public interface nsIZipWriter
	{
		
		/// <summary>
        /// Gets or sets the comment associated with the open zip file.
        ///
        /// @throws NS_ERROR_NOT_INITIALIZED if no zip file has been opened
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetCommentAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aComment);
		
		/// <summary>
        /// Gets or sets the comment associated with the open zip file.
        ///
        /// @throws NS_ERROR_NOT_INITIALIZED if no zip file has been opened
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetCommentAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aComment);
		
		/// <summary>
        /// Indicates that operations on the background queue are being performed.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetInQueueAttribute();
		
		/// <summary>
        /// The file that the zipwriter is writing to.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIFile GetFileAttribute();
		
		/// <summary>
        /// Opens a zip file.
        ///
        /// @param aFile the zip file to open
        /// @param aIoFlags the open flags for the zip file from prio.h
        ///
        /// @throws NS_ERROR_ALREADY_INITIALIZED if a zip file is already open
        /// @throws NS_ERROR_INVALID_ARG if aFile is null
        /// @throws NS_ERROR_FILE_NOT_FOUND if aFile does not exist and flags did
        /// not allow for creation
        /// @throws NS_ERROR_FILE_CORRUPTED if the file does not contain zip markers
        /// @throws <other-error> on failure to open zip file (most likely corrupt
        /// or unsupported form)
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Open([MarshalAs(UnmanagedType.Interface)] nsIFile aFile, int aIoFlags);
		
		/// <summary>
        /// Returns a nsIZipEntry describing a specified zip entry or null if there
        /// is no such entry in the zip file
        ///
        /// @param aZipEntry the path of the entry
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIZipEntry GetEntry([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String aZipEntry);
		
		/// <summary>
        /// Checks whether the zipfile contains an entry specified by zipEntry.
        ///
        /// @param aZipEntry the path of the entry
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool HasEntry([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String aZipEntry);
		
		/// <summary>
        /// Adds a new directory entry to the zip file. If aZipEntry does not end with
        /// "/" then it will be added.
        ///
        /// @param aZipEntry the path of the directory entry
        /// @param aModTime the modification time of the entry in microseconds
        /// @param aQueue adds the operation to the background queue. Will be
        /// performed when processQueue is called.
        ///
        /// @throws NS_ERROR_NOT_INITIALIZED if no zip file has been opened
        /// @throws NS_ERROR_FILE_ALREADY_EXISTS if the path already exists in the
        /// file
        /// @throws NS_ERROR_IN_PROGRESS if another operation is currently in progress
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddEntryDirectory([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String aZipEntry, uint aModTime, [MarshalAs(UnmanagedType.Bool)] bool aQueue);
		
		/// <summary>
        /// Adds a new file or directory to the zip file. If the specified file is
        /// a directory then this will be equivalent to a call to
        /// addEntryDirectory(aZipEntry, aFile.lastModifiedTime, aQueue)
        ///
        /// @param aZipEntry the path of the file entry
        /// @param aCompression the compression level, 0 is no compression, 9 is best
        /// @param aFile the file to get the data and modification time from
        /// @param aQueue adds the operation to the background queue. Will be
        /// performed when processQueue is called.
        ///
        /// @throws NS_ERROR_NOT_INITIALIZED if no zip file has been opened
        /// @throws NS_ERROR_FILE_ALREADY_EXISTS if the path already exists in the zip
        /// @throws NS_ERROR_IN_PROGRESS if another operation is currently in progress
        /// @throws NS_ERROR_FILE_NOT_FOUND if file does not exist
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddEntryFile([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String aZipEntry, int aCompression, [MarshalAs(UnmanagedType.Interface)] nsIFile aFile, [MarshalAs(UnmanagedType.Bool)] bool aQueue);
		
		/// <summary>
        /// Adds data from a channel to the zip file. If the operation is performed
        /// on the queue then the channel will be opened asynchronously, otherwise
        /// the channel must support being opened synchronously.
        ///
        /// @param aZipEntry the path of the file entry
        /// @param aModTime the modification time of the entry in microseconds
        /// @param aCompression the compression level, 0 is no compression, 9 is best
        /// @param aChannel the channel to get the data from
        /// @param aQueue adds the operation to the background queue. Will be
        /// performed when processQueue is called.
        ///
        /// @throws NS_ERROR_NOT_INITIALIZED if no zip file has been opened
        /// @throws NS_ERROR_FILE_ALREADY_EXISTS if the path already exists in the zip
        /// @throws NS_ERROR_IN_PROGRESS if another operation is currently in progress
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddEntryChannel([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String aZipEntry, uint aModTime, int aCompression, [MarshalAs(UnmanagedType.Interface)] nsIChannel aChannel, [MarshalAs(UnmanagedType.Bool)] bool aQueue);
		
		/// <summary>
        /// Adds data from an input stream to the zip file.
        ///
        /// @param aZipEntry the path of the file entry
        /// @param aModTime the modification time of the entry in microseconds
        /// @param aCompression the compression level, 0 is no compression, 9 is best
        /// @param aStream the input stream to get the data from
        /// @param aQueue adds the operation to the background queue. Will be
        /// performed when processQueue is called.
        ///
        /// @throws NS_ERROR_NOT_INITIALIZED if no zip file has been opened
        /// @throws NS_ERROR_FILE_ALREADY_EXISTS if the path already exists in the zip
        /// @throws NS_ERROR_IN_PROGRESS if another operation is currently in progress
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddEntryStream([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String aZipEntry, uint aModTime, int aCompression, [MarshalAs(UnmanagedType.Interface)] nsIInputStream aStream, [MarshalAs(UnmanagedType.Bool)] bool aQueue);
		
		/// <summary>
        /// Removes an existing entry from the zip file.
        ///
        /// @param aZipEntry the path of the entry to be removed
        /// @param aQueue adds the operation to the background queue. Will be
        /// performed when processQueue is called.
        ///
        /// @throws NS_ERROR_NOT_INITIALIZED if no zip file has been opened
        /// @throws NS_ERROR_IN_PROGRESS if another operation is currently in progress
        /// @throws NS_ERROR_FILE_NOT_FOUND if no entry with the given path exists
        /// @throws <other-error> on failure to update the zip file
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveEntry([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String aZipEntry, [MarshalAs(UnmanagedType.Bool)] bool aQueue);
		
		/// <summary>
        /// Processes all queued items until complete or some error occurs. The
        /// observer will be notified when the first operation starts and when the
        /// last operation completes. Any failures will be passed to the observer.
        /// The zip writer will be busy until the queue is complete or some error
        /// halted processing of the queue early. In the event of an early failure,
        /// remaining items will stay in the queue and calling processQueue will
        /// continue.
        ///
        /// @throws NS_ERROR_NOT_INITIALIZED if no zip file has been opened
        /// @throws NS_ERROR_IN_PROGRESS if the queue is already in progress
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ProcessQueue([MarshalAs(UnmanagedType.Interface)] nsIRequestObserver aObserver, [MarshalAs(UnmanagedType.Interface)] nsISupports aContext);
		
		/// <summary>
        /// Closes the zip file.
        ///
        /// @throws NS_ERROR_NOT_INITIALIZED if no zip file has been opened
        /// @throws NS_ERROR_IN_PROGRESS if another operation is currently in progress
        /// @throws <other-error> on failure to complete the zip file
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Close();
	}
}
