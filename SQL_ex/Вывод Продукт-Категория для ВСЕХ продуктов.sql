USE Shop

SELECT
	Products.product,
	Categories.category
FROM Products
LEFT JOIN Prod_type on Products.prod_id = Prod_type.prod_id
LEFT JOIN Categories on Prod_type.cat_id = Categories.cat_id
