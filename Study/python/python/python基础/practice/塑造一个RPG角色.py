full_dot = '●'
empty_dot = '○'

def create_character(name, strength, intelligence, charm):
    """
    创建角色并返回格式化字符串
    
    参数:
    name: 角色名称 (字符串)
    strength: 力量值 (整数, 1-4)
    intelligence: 智力值 (整数, 1-4)
    charm: 魅力值 (整数, 1-4)
    
    返回:
    格式化字符串或错误信息
    """
    
    # 验证角色名称
    if not isinstance(name, str):
        return "The character name should be a string"
    
    if name == "":
        return "The character should have a name"
    
    if len(name) > 10:
        return "The character name is too long"
    
    if ' ' in name:
        return "The character name should not contain spaces"
    
    # 验证属性值
    stats = [strength, intelligence, charm]
    
    # 检查是否为整数
    if not all(isinstance(stat, int) for stat in stats):
        return "All stats should be integers"
    
    # 检查是否小于1
    if any(stat < 1 for stat in stats):
        return "All stats should be no less than 1"
    
    # 检查是否超过4
    if any(stat > 4 for stat in stats):
        return "All stats should be no more than 4"
    
    # 检查总和是否为7
    if sum(stats) != 7:
        return "The character should start with 7 points"
    
    # 构建返回字符串
    result = name + "\n"
    
    # 添加力量行
    result += f"STR {full_dot * strength}{empty_dot * (10 - strength)}\n"
    
    # 添加智力行
    result += f"INT {full_dot * intelligence}{empty_dot * (10 - intelligence)}\n"
    
    # 添加魅力行
    result += f"CHA {full_dot * charm}{empty_dot * (10 - charm)}"
    
    return result