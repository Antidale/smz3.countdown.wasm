namespace smz3.countdown.wasm.Attributes
{
    public class MajorAttribute : Attribute
    {
        public bool Major;

        public MajorAttribute(bool isMajor)
        {
            Major = isMajor;
        }
    }
}
