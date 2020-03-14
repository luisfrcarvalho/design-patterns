namespace Template
{
    public abstract class AbstractClass
    {
        public AbstractClass()
        {
        }

        public void TemplateMethod()
        {
            DoExecute();
        }

        protected abstract void DoExecute();
    }
}
