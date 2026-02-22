def apply_discount(price, discount):
    # 检查 price 是否为数字
    if not isinstance(price, (int, float)):
        return "The price should be a number"
    
    # 检查 discount 是否为数字
    if not isinstance(discount, (int, float)):
        return "The discount should be a number"
    
    # 检查 price 是否大于 0
    if price <= 0:
        return "The price should be greater than 0"
    
    # 检查 discount 是否在 0 到 100 之间（包含边界）
    if discount < 0 or discount > 100:
        return "The discount should be between 0 and 100"
    
    # 计算折扣后的价格，确保处理浮点数精度
    discount_amount = price * discount / 100
    final_price = price - discount_amount
    
    # 如果结果是整数，返回整数，否则返回浮点数
    if final_price == int(final_price):
        return int(final_price)
    else:
        return final_price