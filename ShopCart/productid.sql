SELECT     Product.ProductId, Product.Name, Product.Description, Product.ProductTypeId, Product.Active, Product.Visible, Product.Removable, Product.ShortName, 
                      ProductSku.Sku, ProductSku.IsDefault, ProductBundle.IncludedProductId, ProductBundle.IncludedSku, ProductSkuRule.InvalidProductId, ProductSkuRule.InvalidSku, 
                      ProductSkuRule.ReplacementProductId, ProductSkuRule.ReplacementSku, ProductType.Name AS ProductType, ProductType.MaxQuantityPerProduct, 
                      ProductType.CanOnlyHaveOneProductPerType
FROM         Product LEFT OUTER JOIN
                      ProductType ON Product.ProductTypeId = ProductType.ProductTypeId LEFT OUTER JOIN
                      ProductSkuRule ON Product.ProductId = ProductSkuRule.ProductId LEFT OUTER JOIN
                      ProductSku ON Product.ProductId = ProductSku.ProductId LEFT OUTER JOIN
                      ProductBundle ON Product.ProductId = ProductBundle.ProductId
ORDER BY ProductType, Product.ProductId, ProductSku.Sku