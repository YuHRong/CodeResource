def number_pattern(n):
    # 检查是否为整数
    if not isinstance(n, int):
        return "Argument must be an integer value."
    
    # 检查是否大于0
    if n < 1:
        return "Argument must be an integer greater than 0."
    
    # 使用 for 循环构建字符串
    result = ""
    for i in range(1, n + 1):
        result += str(i)
        if i < n:  # 不在最后一个数字后添加空格
            result += " "
    
    return result