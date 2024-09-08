SELECT Product.Name, Category.name
FROM Product LEFT JOIN Category ON Product.uni_id = Category.uni_id