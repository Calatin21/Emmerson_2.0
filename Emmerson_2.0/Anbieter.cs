namespace Emmerson_2._0
{
    internal class Anbieter
    {
        int anbieternummer;
        String name;
        public void SetAnbieternummer(int aanummer)
        {
            anbieternummer = aanummer;
        }
        public int GetAnbieternummer()
        {
            return anbieternummer;
        }
        public void Setname(String name)
        {
            this.name = name;
        }
        public String Getname()
        {
            return name;
        }
    }
}
