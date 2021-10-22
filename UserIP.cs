class UserIP {
private string animal;
private string name;

  private ArrayList<Talkable> zoo = new ArrayList<>();
public void AddAnimal(){
    Console.WriteLine("Enter animal type:");
    animal = Console.ReadLine();
    
    if(animal = "Dog" || animal = "dog"){
         Console.WriteLine("Enter the dogs name:");
    name = Console.ReadLine();
    Console.WriteLine("Are they friendly?");
    bool friendly = Console.ReadLine();
    Dog dog = new Dog(friendly, name);
      zoo.add(dog);
    }
     if(animal = "Cat" || animal = "cat"){
         Console.WriteLine("Enter the cats name:");
    name = Console.ReadLine();
    Console.WriteLine("how many mice have they killed?");
    int mice = Console.ReadLine();
    Cat cat = new Cat(mice, name);
    zoo.add(cat);
    }
     if(animal = "Teacher" || animal = "teacher"){
         Console.WriteLine("Enter the teachers name:");
    name = Console.ReadLine();
    Console.WriteLine("whats their age?");
    int age = Console.ReadLine();
    Teacher teacher = new Teacher(age, name);
    zoo.add(teacher);
    }

}
 public void setZoo(){
        return(zoo);
    }
}



