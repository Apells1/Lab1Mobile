
public class Main {

    private  FileOutput outFile = new FileOutput("animals.txt");
    private  FileInput inFile = new FileInput("animals.txt");

    public static void main(String[] args) {
        ArrayList<Talkable> zoo = new ArrayList<>();

        // Lines to Replace Begin Here
        UserIP.AddAnimal();
        zoo = UserIP.setZoo();
        // End Lines to Replace
        foreach(Talkable t in zoo){ printOut(thing);}
        outFile.fileClose();
        inFile.fileRead();
        inFile.fileClose();

        FileInput indata = new FileInput("animals.txt");
        String line;
        while ((line = indata.fileReadLine()) != null) {
           Console.WriteLine(line);
        }
    }

    public static void printOut(Talkable p) {
        Console.WriteLine(p.getName() + " says=" + p.talk());
        outFile.fileWrite(p.getName() + " | " + p.talk());
    }
}
