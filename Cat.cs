class Cat : Talkable  {
    private int mousesKilled;

    public Cat(int mousesKilled, string name) {
        super(name);
        this.mousesKilled = mousesKilled;
    }

    public int getMousesKilled() {
        return mousesKilled;
    }

    public void addMouse() {
        mousesKilled++;
    }

    
    public override string talk() {
        return "Meow";
    }

    public override string toString() {
        return "Cat: " + "name=" + name + " mousesKilled=" + mousesKilled;
    }
}

