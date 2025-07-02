namespace CSharpConcepts.Polymorphism.RunTime
{
    public class NewKeywordParent
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
    }
    public class NewKeywordChild : NewKeywordParent
    {
        public new int Add(int a, int b)
        {
            return a + b;
        }
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }
    }

    public class NewKeyword
    {
    }
}
