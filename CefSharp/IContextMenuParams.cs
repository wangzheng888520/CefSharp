﻿// Copyright © 2010-2016 The CefSharp Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.

using System;
using System.Collections.Generic;

namespace CefSharp
{
    /// <summary>
    /// Wrapper for the CefContextMenuParams
    /// </summary>
    public interface IContextMenuParams : IDisposable
    {
        int YCoord { get; }
        int XCoord { get; }

        // TODO: Implement:
        //virtual TypeFlags GetTypeFlags() OVERRIDE;

        string LinkUrl { get; }
        string UnfilteredLinkUrl { get; }
        string SourceUrl { get; }
        bool HasImageContents { get; }
        string PageUrl { get; }
        string FrameUrl { get; }
        string FrameCharset { get; }


        // TODO: Implement:
        //virtual MediaType GetMediaType() OVERRIDE;
        //virtual MediaStateFlags GetMediaStateFlags() OVERRIDE;


        string SelectionText { get; }
        string MisspelledWord { get; }
    
        List<string> DictionarySuggestions { get; }  

        bool IsEditable { get; }
        bool IsSpellCheckEnabled { get; }
     
          
        // TODO: Implement:
        //virtual EditStateFlags GetEditStateFlags() OVERRIDE;

        /// <summary>
        /// Gets a value indicating whether the object has been disposed of.
        /// </summary>
        bool IsDisposed { get; }
    }
}
