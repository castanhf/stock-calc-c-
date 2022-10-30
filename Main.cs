using System;

namespace ClassObject {

  class Dog {
    string breed;

    public void bark() {
      Console.WriteLine("Bark Bark !!");
      
    }

    public static void Main(string[] args) { 
      Dog bullDog = new Dog();

      bullDog.breed = "Bull Dog";
      Console.WriteLine(bullDog.breed);

      bullDog.bark();   

      Console.ReadLine();
     
    }
  }
}