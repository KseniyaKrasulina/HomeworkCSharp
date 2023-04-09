namespace Bf
{
    internal class Deserialize : DATA
    {
        private FileStream fstr;

        public Deserialize(FileStream fstr)
        {
            this.fstr = fstr;
        }
    }
}