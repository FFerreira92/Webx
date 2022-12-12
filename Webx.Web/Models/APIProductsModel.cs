﻿using System;

namespace Webx.Web.Models
{
    public class APIProductsModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public string Brand { get; set; }

        public string Category { get; set; }

        public Guid ImageId { get; set; }

        public string ImageFullPath => ImageId == Guid.Empty
            ? $"https://supershoptpsi.azurewebsites.net/images/noimage.png"
            : $"https://supershoptpsi.blob.core.windows.net/products/{ImageId}";
    }
}
