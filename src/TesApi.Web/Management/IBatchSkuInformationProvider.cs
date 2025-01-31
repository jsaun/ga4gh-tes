﻿// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Threading.Tasks;
using Tes.Models;

namespace TesApi.Web.Management
{
    /// <summary>
    /// Provider of pricing and size information of the Vm SKUs supported by Batch.
    /// </summary>
    public interface IBatchSkuInformationProvider
    {
        /// <summary>
        /// Returns the size and pricing information for Batch supported VMs
        /// </summary>
        /// <param name="region"></param>
        /// <returns></returns>
        public Task<List<VirtualMachineInformation>> GetVmSizesAndPricesAsync(string region);
    }
}
