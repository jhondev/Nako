﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DecodedRawTransaction.cs" company="SoftChains">
//   Copyright 2016 Dan Gershony
//   //  Licensed under the MIT license. See LICENSE file in the project root for full license information.
//   //  THIS CODE AND INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
//   //  EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED WARRANTIES 
//   //  OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Nako.Client.Types
{
    using System.Collections.Generic;

    public class DecodedRawTransaction
    {
        public string Hex { get; set; }
        public string TxId { get; set; }
        public int Version { get; set; }
        public long Time { get; set; }
        public long Locktime { get; set; }
        public List<Vin> VIn { get; set; }
        public List<Vout> VOut { get; set; }
        public long Confirmations { get; set; }
        public string BlockHash { get; set; }
        public string BlockTime { get; set; }
    }
}
