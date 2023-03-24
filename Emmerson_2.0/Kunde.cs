namespace Emmerson_2._0 {
    internal class Kunde : Gast {
        String nachname;
        String vorname;
        DateTime geburtsdatum;
        String loginname;
        String passwort;
        List<Rechnung> rechnungen = new List<Rechnung>();
        public Kunde () {

        }
        public Kunde(Warenkorb warenkorb, int id, String nachname, String vorname, DateTime geburtstag, String loginname, String passwort) {
            this.SetWarenkorb(warenkorb);           
            this.SetId(id);
            this.nachname = nachname;
            this.vorname = vorname;
            this.geburtsdatum = geburtstag;
            this.loginname = loginname;
            this.passwort = passwort;
        }
        public void Setnachname(String nname) {
            this.nachname = nname;
        }
        public String GetNachname() {
            return this.nachname;
        }
        public void SetVorname(String vname) {
            vorname = vname;
        }
        public String GetVorname() {
            return this.vorname;
        }
        public void SetGeburtsdatum(DateTime datum) {
            geburtsdatum = datum;
        }
        public DateTime GetGeburtsdatum() {
            return geburtsdatum;
        }
        public void SetLoginname(String login) {
            loginname = login;
        }
        public String GetLoginname() {
            return loginname;
        }
        public void SetPasswort(String wort) {
            this.passwort = wort;
        }
        public String GetPasswort() {
            return passwort;
        }
        public void PrintKunde() {
            Console.WriteLine($"\t\t\tKunden ID: {this.GetId()}\nNachname: {this.nachname}\nVorname: {this.vorname}\nGeburtsdatum: {this.geburtsdatum}\nLogin Name: {this.loginname}");
        }
        public void AddRechnung(Rechnung rechnung) {
            rechnungen.Add(rechnung);
        }
        public void RemoveRechnung(Rechnung rechnung) {
            rechnungen.Remove(rechnung);
        }
        public void PrintRechnungen() {
            foreach (Rechnung item in rechnungen) {
                item.Printrechnug();
            }
        }
        public List<Rechnung> GetRechnungen() {
            return rechnungen;
        }
    }
}
