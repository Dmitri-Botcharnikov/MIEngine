// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

// MUST match guids.h

using System;

namespace Microsoft.MIDebugPackage
{
    internal static class GuidList
    {
        public const string guidMIDebugPackagePkgString = "EC769E24-0F3D-479F-834D-55F584443C5A";
        public const string guidMIDebugPackageCmdSetString = "690F926A-662E-4139-BD58-BE7E2AD503C1";

        public static readonly Guid guidMIDebugPackageCmdSet = new Guid(guidMIDebugPackageCmdSetString);
    };
}
