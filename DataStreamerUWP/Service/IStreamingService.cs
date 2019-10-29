﻿//*********************************************************
//
// Copyright (c) Microsoft. All rights reserved.
// This code is licensed under the MIT License (MIT).
// THIS CODE IS PROVIDED AS IS WITHOUT WARRANTY OF
// ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING ANY
// IMPLIED WARRANTIES OF FITNESS FOR A PARTICULAR
// PURPOSE, MERCHANTABILITY, OR NON-INFRINGEMENT.
//
//*********************************************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.DataStreamer.UWP
{
    public interface IStreamingService
    {
        Task<string> Connect();
        Task         Disconnect();

        Task         StartData();
        Task         StopData();
        Task         StartRecording(string fileName);
        Task         StopRecording();
        Task         Reset();
        Task         Ready();
        Task         NotReady();
        Task         UpdateManifest();
    }
}