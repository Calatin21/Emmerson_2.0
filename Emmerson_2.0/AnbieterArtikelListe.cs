namespace Emmerson_2._0
{
    internal class AnbieterArtikelListe
    {
        Anbieter anbieter;
        List<Artikel> artikels = new List<Artikel>();
        public void SetAnbieter(Anbieter anbieter)
        {
            this.anbieter = anbieter;
        }
        public Anbieter GetAnbieter()
        {
            return this.anbieter;
        }
        public void AddArtikel(Artikel artikel)
        {
            artikels.Add(artikel);
        }
        public void RemoveArtikel(Artikel artikel)
        {
            artikels.Remove(artikel);
        }
        public void PrintArtikels()
        {
            foreach (Artikel item in artikels)
            {
                item.PrintArtikel();
            }
        }
    }
}
