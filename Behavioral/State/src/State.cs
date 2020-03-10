namespace StatePattern
{
    /*
     * Since we're not sharing any common code to the child classes, we could have used an Interface.
     */
    public abstract class State
    {
        public abstract string draw();
    }
}
