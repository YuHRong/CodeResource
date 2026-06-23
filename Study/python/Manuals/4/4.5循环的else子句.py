for n in range(2, 10):
    
    for x in range(2, n):
        
        if n % x ==0:
            
            print(n, 'equals', x, ' * ', n//x)
            
            break
        
    else:
        # 循环到底未找到一个因数
            print(n, 'is a prime number')