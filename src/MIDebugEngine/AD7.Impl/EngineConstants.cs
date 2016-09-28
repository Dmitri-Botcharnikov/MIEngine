// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.MIDebugEngine
{
    static public class EngineConstants
    {
        /// <summary>
        /// This is the engine GUID of the engine. It needs to be changed here and in the registration
        /// when creating a new engine.
        /// </summary>
        public static readonly Guid EngineId = new Guid("{3352D8EC-AE86-41F2-BB8A-90DA85ABCA05}");

        public static readonly Guid GdbEngine = new Guid("{91744D97-430F-42C1-9779-A5813EBD6AB2}");
        public static readonly Guid ClrdbgEngine = new Guid("{6B320935-1391-433A-A8B6-898D0F03164A}");
    }
}
