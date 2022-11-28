namespace Iterator
{
    public abstract class Element
    {
        protected string Description;

        public Element(string description)
        {
            Description = description;
        }

        public bool IsValidKeyWord(string keyWord)
        {
            return Description.IndexOf(keyWord) != -1;
        }
    }
}
