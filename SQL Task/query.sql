--допустим, что реализовано через таблицу-связку
select
     prod.product_name
    ,cat.category_name
from product_category pc
    full join product prod --не left, потому что не хотим отсекать продукты без связки
        on prod.product_id = pc.product_id
    left join category cat --предположим, что выводить категории без продукта не требуется. Если же нужно - будет тоже full
        on cat.category_id = pc.category_id