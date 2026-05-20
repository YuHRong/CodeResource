class Planet():
    def __init__(self, name, planet_type, star):
     
     # 字符串类型检查
        if not isinstance(name, str):
            raise TypeError("name, planet type, and star must be strings")
        if not isinstance(planet_type, str):
            raise TypeError("name, planet type, and star must be strings")
        if not isinstance(star, str):
            raise TypeError("name, planet type, and star must be strings")
        
        # 检查字符串是否为空
        if not name:
            raise ValueError("name, planet_type, and star must be non-empty strings")
        if not planet_type:
            raise ValueError("name, planet_type, and star must be non-empty strings")
        if not star:
            raise ValueError("name, planet_type, and star must be non-empty strings")
           
        self.name = name
        self.planet_type = planet_type
        self.star = star
 
    def orbit(self):
        return f"{self.name} is orbiting around {self.star}..."

    def __str__(self):
        return f"Planet: {self.name} | Type: {self.planet_type} | Star: {self.star}"

planet_1 = Planet('火星', '超高星系', 'sun')
planet_2 = Planet('土星', '超大行星', 'sun')
planet_3 = Planet('金星', '离地球不远不近', 'sun')


print(planet_1)
print(planet_2)
print(planet_3)

print(planet_1.orbit())
print(planet_2.orbit())
print(planet_3.orbit())
