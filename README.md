# Тестовое задание для Mindbox

## Задание #1
В ShapesLibrary.Models находятся классы Circle и Triange, подписанные на интерфейс IMeasurable. IMeasurable декларирует метод CalculateArea(). Для каждого конкретного инстанса Circle или Triange, метод CalculateArea() вычисляет площадь фигуры. 

Метод IsARightAngledTriangle() класса Triange позволяет проверить, является ли треугольник прямоугольным.

Решение сопровождается unit-тестами, расположенными в ShapesLibrary.Tests.

## Задание #2
SELECT product_category.product_id, product_category.category_id, products.name, categories.name
FROM product_category
	INNER JOIN products
		ON product_category.product_id = products.id
	INNER JOIN  categories
		ON product_category.category_id = categories.id