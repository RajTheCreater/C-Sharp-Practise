namespace CSharpConcepts.Polymorphism.RunTime
{
    public class TestMultipleOverrideParent
    {
        public virtual string GetString(dynamic input)
        {
            return input.ToString();
        }
    }
    public class TestMultipleOverrideChild : TestMultipleOverrideParent
    {
        public override string GetString(dynamic input)
        {
            return input.ToString();
        }
        //public override string GetString(dynamic input)
        //{
        //    return input.ToString();
        //}
    }
    class MultipleOverride
    {
    }
}
