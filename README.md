# �������� ������� ��� Mindbox

## ������� #1
� ShapesLibrary.Models ��������� ������ Circle � Triange, ����������� �� ��������� IMeasurable. IMeasurable ����������� ����� CalculateArea(). ��� ������� ����������� �������� Circle ��� Triange, ����� CalculateArea() ��������� ������� ������. 

����� IsARightAngledTriangle() ������ Triange ��������� ���������, �������� �� ����������� �������������.

������� �������������� unit-�������, �������������� � ShapesLibrary.Tests.

## ������� #2
SELECT product_category.product_id, product_category.category_id, products.name, categories.name
FROM product_category
	INNER JOIN products
		ON product_category.product_id = products.id
	INNER JOIN  categories
		ON product_category.category_id = categories.id