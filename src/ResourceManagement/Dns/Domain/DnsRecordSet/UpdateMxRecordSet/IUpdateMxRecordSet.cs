// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace Microsoft.Azure.Management.Dns.Fluent.DnsRecordSet.UpdateMXRecordSet
{
    using Microsoft.Azure.Management.Dns.Fluent.DnsRecordSet.Update;

    /// <summary>
    /// The entirety of a MX record set update as a part of parent DNS zone update.
    /// </summary>
    public interface IUpdateMXRecordSet :
        Microsoft.Azure.Management.Dns.Fluent.DnsRecordSet.Update.IWithMXRecordMailExchange,
        Microsoft.Azure.Management.Dns.Fluent.DnsRecordSet.Update.IUpdate
    {

    }
}