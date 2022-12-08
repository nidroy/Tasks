SELECT [Tel] FROM [TCustomers]
INNER JOIN (
SELECT [idC], SUM([Price]) AS SumPrice  
FROM [TSales]
WHERE MONTH([DateS]) = 4 AND YEAR([DateS]) = 2022
GROUP BY([idC])
) AS TableSumPrice
ON [TCustomers].[idC] = [TableSumPrice].[idC]
WHERE [TableSumPrice].[SumPrice] > 500