
public class Dog : Talkable {
    private boolean friendly;

    public Dog(boolean friendly, string name) {
        super(name);
        this.friendly = friendly;
    }

    public boolean isFriendly() {
        return friendly;
    }

   
    public override string talk() {
        return "Bark";
    }

    
    public override string toString() {
        return "Dog: " + "name=" + name + " friendly=" + friendly;
    }


}