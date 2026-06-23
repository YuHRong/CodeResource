namespace 在代码中应用接口;

class Program
{
 static void Main()
 {
  IAnimal dog = new Dog();
  IAnimal cat = new Cat();

  AnimalSound animalSound = new AnimalSound();
  animalSound.MakeAnimalSound(dog);     // 输出： Woof！
  animalSound.MakeAnimalSound(cat);      // 输出： Meow！
 }
}