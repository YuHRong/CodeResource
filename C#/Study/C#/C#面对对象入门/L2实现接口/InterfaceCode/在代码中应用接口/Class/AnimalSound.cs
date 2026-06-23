
namespace 在代码中应用接口;

public class AnimalSound
{
public void MakeAnimalSound(IAnimal animal)
 {
  animal.MakeSound();
 }
}
