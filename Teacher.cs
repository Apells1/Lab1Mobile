
public class Teacher  {    private int age;

    public Teacher(int age, string name) {
        super(name);
        this.age = age;
    }

    public int getAge() {
        return age;
    }

    public void setAge(int age) {
        this.age = age;
    }

  
    public override string talk() {
        return "Don't forget to do the assigned reading!";
    }
}
