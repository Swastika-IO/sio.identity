// Licensed to the Swastika I/O Foundation under one or more agreements.
// The Swastika I/O Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;

namespace Sio.Identity.Data
{
    public static class IdentityBasedData
    {
        public static List<string> UserClaims { get; set; } = new List<string>
                                                            {
                                                                "Add User",
                                                                "Edit User",
                                                                "Delete User"
                                                            };
    }
}
