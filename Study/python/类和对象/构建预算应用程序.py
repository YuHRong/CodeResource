class Category:
    """财务管理类别类，用于跟踪存款、提款和转账"""

    def __init__(self, name):
        """
        初始化类别

        Args:
            name (str): 类别名称
        """
        self.name = name
        self.ledger = []  # 交易记录列表

    def deposit(self, amount, description=""):
        """
        存入金额

        Args:
            amount (float): 存入金额
            description (str, optional): 交易描述，默认为空字符串
        """
        self.ledger.append({"amount": amount, "description": description})

    def withdraw(self, amount, description=""):
        """
        提取金额（负值存储）

        Args:
            amount (float): 提取金额
            description (str, optional): 交易描述，默认为空字符串

        Returns:
            bool: 如果资金充足返回True，否则返回False
        """
        if self.check_funds(amount):
            self.ledger.append({"amount": -amount, "description": description})
            return True
        return False

    def get_balance(self):
        """
        计算当前余额

        Returns:
            float: 当前余额
        """
        return sum(item["amount"] for item in self.ledger)

    def transfer(self, amount, target_category):
        """
        转账到另一个类别

        Args:
            amount (float): 转账金额
            target_category (Category): 目标类别对象

        Returns:
            bool: 如果转账成功返回True，否则返回False
        """
        if self.check_funds(amount):
            # 从当前类别转出
            self.withdraw(amount, f"Transfer to {target_category.name}")
            # 存入目标类别
            target_category.deposit(amount, f"Transfer from {self.name}")
            return True
        return False

    def check_funds(self, amount):
        """
        检查资金是否充足

        Args:
            amount (float): 检查的金额

        Returns:
            bool: 如果金额不超过余额返回True，否则返回False
        """
        return amount <= self.get_balance()

    def __str__(self):
        """
        格式化输出类别信息

        Returns:
            str: 格式化的类别报表
        """
        # 标题行：30个字符，类别名称居中，两边用*填充
        title = f"{self.name:*^30}\n"

        # 交易记录行
        items = ""
        for item in self.ledger:
            # 描述：最多23个字符
            description = item["description"][:23]
            # 金额：右对齐，保留两位小数，总共7个字符
            amount = f"{item['amount']:.2f}"
            # 构建行：描述左对齐23字符，金额右对齐7字符
            items += f"{description:<23}{amount:>7}\n"

        # 总计行
        total = f"Total: {self.get_balance():.2f}"

        return title + items + total


def create_spend_chart(categories):
    """
    创建支出百分比条形图

    Args:
        categories (list): Category对象列表

    Returns:
        str: 格式化后的条形图字符串
    """
    # 如果类别列表为空，返回空字符串
    if not categories:
        return "Percentage spent by category\n"

    # 计算每个类别的总支出（只计算提款，即负数金额）
    spendings = []
    for category in categories:
        total_withdrawals = sum(
            -item["amount"] for item in category.ledger if item["amount"] < 0
        )
        spendings.append(total_withdrawals)

    # 计算总支出
    total_spent = sum(spendings)

    # 计算每个类别的支出百分比（向下取整到最近的10%）
    percentages = []
    if total_spent > 0:
        for spent in spendings:
            percent = int((spent / total_spent) * 100)
            # 向下取整到最近的10%
            percent = (percent // 10) * 10
            percentages.append(percent)
    else:
        # 如果没有支出，所有百分比为0
        percentages = [0] * len(categories)

    # 构建图表
    chart = "Percentage spent by category\n"

    # y轴从100到0，步长10
    for y in range(100, -1, -10):
        # 添加y轴标签，右对齐3个字符
        chart += f"{y:>3}|"
        # 为每个类别添加标记
        for percent in percentages:
            if percent >= y:
                chart += " o "
            else:
                chart += "   "
        chart += " \n"  # 每行末尾添加空格和换行

    # 添加水平分隔线（两个空格后跟三个横线）
    chart += "    " + "-" * (len(categories) * 3 + 1) + "\n"

    # 垂直显示类别名称
    # 找出最长的类别名称长度
    max_name_length = max(len(category.name) for category in categories)

    # 逐行输出类别名称的每个字符
    for i in range(max_name_length):
        chart += "     "  # 5个空格缩进
        for category in categories:
            if i < len(category.name):
                chart += f"{category.name[i]}  "
            else:
                chart += "   "  # 3个空格（一个字符加两个空格）
        if i < max_name_length - 1:
            chart += "\n"
        else:
            chart = chart.rstrip()  # 移除最后多余的空格

    return chart


# 使用示例（用于测试）
if __name__ == "__main__":
    # 创建类别实例
    food = Category("Food")
    clothing = Category("Clothing")
    auto = Category("Auto")

    # 执行交易
    food.deposit(1000, "initial deposit")
    food.withdraw(10.15, "groceries")
    food.withdraw(15.89, "restaurant and more food for dessert")
    food.transfer(50, clothing)

    # 打印Food类别
    print(food)
    print("\n" + "=" * 50 + "\n")

    # 添加更多类别用于支出图表
    food.withdraw(105.55, "groceries")
    clothing.deposit(500, "initial deposit")
    clothing.withdraw(25.55, "buying clothes")
    auto.deposit(1000, "initial deposit")
    auto.withdraw(150.00, "gas")

    # 创建支出图表
    categories_list = [food, clothing, auto]
    spend_chart = create_spend_chart(categories_list)
    print(spend_chart)