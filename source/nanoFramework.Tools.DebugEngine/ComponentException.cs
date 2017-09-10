//
// Copyright (c) 2017 The nanoFramework project contributors
// Portions Copyright (c) Microsoft Corporation.  All rights reserved.
// See LICENSE file in the project root for full license information.
//

using System;
using System.Runtime.Serialization;

namespace nanoFramework.Tools.DebugEngine
{
    [Serializable]
    public class ComponentException : Exception
    {
        public ComponentException(int hr)
        {

        }

        public ComponentException()
        {
        }

        public ComponentException(string message) : base(message)
        {
        }

        public ComponentException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ComponentException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}