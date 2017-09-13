﻿// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using System;
using System.Threading.Tasks;

namespace nanoFramework.Tools.VisualStudio.Extension
{
    /// <summary>
    ///     Provides extensions for <see cref="Task"/> instances.
    /// </summary>
    internal static class TaskExtensions
    {
        /// <summary>
        ///     Creates a task that will complete indicating whether the specified task completed or timed-out.
        /// </summary>
        /// <param name="task">
        ///     The <see cref="Task"/> to wait on for completion.
        /// </param>
        /// <param name="millisecondsTimeout">
        ///     The number of milliseconds to wait, or <see cref="System.Threading.Timeout.Infinite"/> (-1) to wait indefinitely.
        /// </param>
        /// <returns>
        ///     An <see cref="Task"/> instance on which to wait.
        /// </returns>
        /// <exception cref="ArgumentOutOfRangeException">
        ///     <paramref name="millisecondsTimeout"/> is a negative number other than -1, which represents an infinite time-out.
        /// </exception>
        public static async Task<bool> TryWaitForCompleteOrTimeout(this Task task, int millisecondsTimeout)
        {
            if (task != await Task.WhenAny(task, Task.Delay(millisecondsTimeout)).ConfigureAwait(false))
            {
                return false;
            }

            return true;
        }
    }
}
