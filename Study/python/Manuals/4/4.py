users = {'Hans': 'active', 'Éléonore': 'inactive', '景太郎': 'active' }

# 策略：迭代一个副本
for user, status in users.copy().items():
    
    if status == 'inactive':
        del users[user]
        
# 策略：创建一个新多项集
active_users = {}

for user, status in users.items():

    if status == 'active':

        active_users[user] = status
        

print(users)