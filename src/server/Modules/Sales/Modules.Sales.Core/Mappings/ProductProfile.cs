// --------------------------------------------------------------------------------------------------
// <copyright file="ProductProfile.cs" company="FluentPOS">
// Copyright (c) FluentPOS. All rights reserved.
// The core team: Mukesh Murugan (iammukeshm), Chhin Sras (chhinsras), Nikolay Chebotov (unchase).
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------

using AutoMapper;
using FluentPOS.Modules.Sales.Core.Entities;
using FluentPOS.Shared.DTOs.Catalogs.Products;

namespace FluentPOS.Modules.Sales.Core.Mappings
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<GetProductByIdResponse, Product>().ReverseMap();
        }
    }
}