distance_mi = 15000  # 旅行距离
is_raining = True  # 是否下雨
has_bike = True  # 是否有自行车
has_car = True  # 是否有小轿车
has_ride_share_app = True  # 是否允许乘车

# 修改后的逻辑
if distance_mi <= 1 and not is_raining:
    print(True)
elif 1 < distance_mi <= 6:
    # 距离在1-6英里之间
    if has_bike and not is_raining:
        print(True)
    else:
        print(False)
elif distance_mi > 6:
    # 距离大于6英里
    if has_car or has_ride_share_app:
        print(True)
    else:
        print(False)
else:
    print(False)