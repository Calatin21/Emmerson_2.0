namespace Emmerson_2._0 {
    internal class Program {
        static void Main(string[] args) {
            KundenKartei kartei = new KundenKartei();
            Lager lager = new Lager();
            Artikel artikel1 = new(1, "Stuhl", "Holz Stuhl aus Eichenholz", "Möbel", 49.99, 1, 15, 15);
            Artikel artikel2 = new(2, "Tisch", "Holz Tisch aus Eichenholz", "Möbel", 99.99, 1, 15, 15);
            Artikel artikel3 = new(3, "Tisch", "Tisch aus Plastik", "Möbel", 19.99, 1, 15, 15);
            Artikel artikel4 = new(4, "Tisch", "Tisch mit Glasplatte und Metalgestell", "Möbel", 49.99, 1, 15, 15);
            Artikel artikel5 = new(5, "PC", "Personal Computer", "Elektronik", 499.99, 1, 15, 15);
            Artikel artikel6 = new(6, "Tasse", "Tasse aus Keramik", "Geschirr", 4.99, 1, 15, 5);
            Artikel artikel7 = new(7, "10 Bleistifte", "Bleistift mit Graphitmine", "Schreibwaren", 2.99, 10, 5, 15);
            Artikel artikel8 = new(8, "Display Revised Booster", "36 bosster mit je 15 Karten aus der Revised Edition", "Spielwaren", 499.99, 1, 10, 15);
            Artikel artikel9 = new(9, "Revised Booster", "Booster aus der Revised Edition", "Spielwaren", 29.99, 1, 5, 15);
            Artikel artikel10 = new(10, "Lampe", "Stehlampe aus Metal", "Möbel", 59.99, 1, 15, 15);
            Artikel artikel11 = new(11, "Monitor", "LCD Flachbildschirm Full HD", "Elektronik", 149.99, 1, 15, 15);
            Artikel artikel12 = new(12, "Heringstip", "Hering in Sahnesauce mit Äpfeln und Zwiebeln", "Nahrung", 49.99, 1, 15, 15);
            Artikel artikel13 = new(13, "Äpfel", "6 Jazz Äpfel", "Nahrung", 49.99, 1, 15, 15);
            lager.AddArtikel(artikel1);
            lager.AddArtikel(artikel2);
            lager.AddArtikel(artikel3);
            lager.AddArtikel(artikel4);
            lager.AddArtikel(artikel5);
            lager.AddArtikel(artikel6);
            lager.AddArtikel(artikel7);
            lager.AddArtikel(artikel8);
            lager.AddArtikel(artikel9);
            lager.AddArtikel(artikel10);
            lager.AddArtikel(artikel11);
            lager.AddArtikel(artikel12);
            lager.AddArtikel(artikel13);
            Gast gast = new Gast();         
            bool online = true;
            String antwort = "";
            Console.WriteLine("Willkommen bei Emmerson!!!");
            Console.ReadLine();
            while (online) {
                Console.Clear();
                Console.WriteLine("Was möchten Sie tun?\n1) Einloggen\n2) Registrieren\n3) Einkaufen\n4) Beenden");
                antwort = Console.ReadLine();
                switch (antwort) {
                    case "1":
                    Kunde checkKunde = new Kunde();
                    checkKunde = gast.Login(kartei);
                    if (checkKunde != null) {
                        Einkaufen(checkKunde, kartei, lager);
                    }
                    break;
                    case "2":
                    gast.Registrieren(kartei);
                    break;
                    case "3":
                    Einkaufen(gast, kartei, lager);
                    break;
                    case "4":
                    online = false;
                    break;
                    default:
                    Console.WriteLine("Falsche eingabe!\nTaste drücken zum fortfahren.");
                    Console.ReadLine();
                    break;
                }
            }
        }
        static void Einkaufen(Gast gast, KundenKartei kartei, Lager lager) {
            bool einkaufen = true;
            String antwort = "";
            String wort = "";
            int zahl = 0;
            Artikel auswahl = null;
            while (einkaufen) {
                Console.WriteLine($"Gast was wollen Sie tun?\n1) Artikel suchen\n2) Artickel anzeigen\n3) Artikel in den Warenkorb legen\n4) Artikel aus dem Warenkorb entfernen\n5) Artikelmenge ändern\n6) Warenkorb anzeigen\n7) Zur Kasse\n8) Kauf beenden");
                antwort = Console.ReadLine();
                switch (antwort) {
                    case "1":
                    Console.Write("Bitte geben Sie das Wort ein nachdem Sie suchen wollen: ");
                    wort = Console.ReadLine();
                    gast.ArtikelSuchen(lager, wort);
                    Console.ReadLine();
                    break;
                    case "2":
                    Console.Write("Bitte geben Sie die Artikelnummer des Artikels ein den Sie genauer ansehen wollen: ");
                    zahl = Convert.ToInt32(Console.ReadLine());
                    gast.ArtikelAuswaehlen(lager, zahl);
                    break;
                    case "3":
                    while (zahl >= 0) {
                        Console.Write("Bitte Artikelnummer angeben(-1 für abbruch):");
                        zahl = Convert.ToInt32(Console.ReadLine());
                        if (lager.ArtikelSuchen(zahl) == null) {
                            Console.WriteLine($"Es gibt kein Artikel mit der Artikelnummer {zahl}");
                        } else {
                            auswahl = lager.ArtikelSuchen(zahl);
                            break;
                        }
                    }
                    Console.Write("Und welche menge wollen sie in Ihren Warenkorb legen: ");
                    zahl = Convert.ToInt32(Console.ReadLine());
                    gast.PostenHinzufuegen(auswahl, zahl);
                    break;
                    case "4":
                    while (zahl >= 0) {
                        Console.Write("Bitte Artikelnummer angeben(-1 für abbruch):");
                        zahl = Convert.ToInt32(Console.ReadLine());
                        if (lager.ArtikelSuchen(zahl) == null) {
                            Console.WriteLine($"Es gibt kein Artikel mit der Artikelnummer {zahl}");
                        }
                        else {
                            auswahl = lager.ArtikelSuchen(zahl);
                            break;
                        }
                    }                    
                    gast.PostenEntfernen(auswahl);
                    break;
                    case "5":
                    while (zahl >= 0) {
                        Console.Write("Bitte Artikelnummer angeben(-1 für abbruch):");
                        zahl = Convert.ToInt32(Console.ReadLine());
                        if (lager.ArtikelAuswaehlen(zahl) == null) {
                            Console.WriteLine($"Es gibt kein Artikel mit der Artikelnummer {zahl}");
                        }
                        else {
                            auswahl = lager.ArtikelAuswaehlen(zahl);
                            break;
                        }
                    }
                    Console.Write("Und welche menge wollen sie in Ihren Warenkorb legen: ");
                    zahl = Convert.ToInt32(Console.ReadLine());
                    gast.AnzahlFestlegen(auswahl, zahl);
                    break;
                    case "6":
                    gast.WarenkorbAnzeigen();
                    Console.ReadLine();
                    break;
                    case "7":
                    gast.zurKasse(kartei, "gast");
                    Console.ReadLine();
                    break;
                    case "8":
                    einkaufen = false;
                    break;
                    default:
                    break;
                }
            }

        }
        static void Einkaufen(Kunde kunde, KundenKartei kartei, Lager lager) {
            bool einkaufen = true;
            String antwort = "";
            String wort = "";
            int zahl = 0;
            Artikel auswahl = null;
            while (einkaufen) {
                Console.WriteLine($"{kunde.GetNachname()} was wollen Sie tun?\n1) Artikel suchen\n2) Artickel auswählen\n3) Artikel in den Warenkorb legen\n4) Artikel aus dem Warenkorb entfernen\n5) Artikelmenge ändern\n6) Warenkorb anzeigen\n7) Zur Kasse\n8) Rechnungen anzeigen\n9) Kauf beenden");
                antwort = Console.ReadLine();
                switch (antwort) {
                    case "1":
                    Console.Write("Bitte geben Sie das Wort ein nachdem Sie suchen wollen: ");
                    wort = Console.ReadLine();
                    kunde.ArtikelSuchen(lager, wort);
                    Console.ReadLine();
                    break;
                    case "2":
                    Console.Write("Bitte geben Sie die Artikelnummer des Artikels ein den Sie genauer ansehen wollen: ");
                    zahl = Convert.ToInt32(Console.ReadLine());
                    kunde.ArtikelAuswaehlen(lager, zahl);
                    break;
                    case "3":
                    while (zahl >= 0) {
                        Console.Write("Bitte Artikelnummer angeben(-1 für abbruch):");
                        zahl = Convert.ToInt32(Console.ReadLine());
                        if (lager.ArtikelSuchen(zahl) == null) {
                            Console.WriteLine($"Es gibt kein Artikel mit der Artikelnummer {zahl}");
                        }
                        else {
                            auswahl = lager.ArtikelSuchen(zahl);
                            break;
                        }
                    }
                    Console.Write("Und welche menge wollen sie in Ihren Warenkorb legen: ");
                    zahl = Convert.ToInt32(Console.ReadLine());
                    kunde.PostenHinzufuegen(auswahl, zahl);
                    break;
                    case "4":
                    while (zahl >= 0) {
                        Console.Write("Bitte Artikelnummer angeben(-1 für abbruch):");
                        zahl = Convert.ToInt32(Console.ReadLine());
                        if (lager.ArtikelSuchen(zahl) == null) {
                            Console.WriteLine($"Es gibt kein Artikel mit der Artikelnummer {zahl}");
                        }
                        else {
                            auswahl = lager.ArtikelSuchen(zahl);
                            break;
                        }
                    }
                    kunde.PostenEntfernen(auswahl);
                    break;
                    case "5":
                    while (zahl >= 0) {
                        Console.Write("Bitte Artikelnummer angeben(-1 für abbruch):");
                        zahl = Convert.ToInt32(Console.ReadLine());
                        if (lager.ArtikelSuchen(zahl) == null) {
                            Console.WriteLine($"Es gibt kein Artikel mit der Artikelnummer {zahl}");
                        }
                        else {
                            auswahl = lager.ArtikelSuchen(zahl);
                            break;
                        }
                    }
                    Console.Write("Und welche menge wollen sie in Ihren Warenkorb legen: ");
                    zahl = Convert.ToInt32(Console.ReadLine());
                    kunde.AnzahlFestlegen(auswahl, zahl);
                    break;
                    case "6":
                    kunde.WarenkorbAnzeigen();
                    Console.ReadLine();
                    break;
                    case "7":
                    kunde.zurKasse(kartei, "kunde");
                    Console.ReadLine();
                    break;
                    case "8":
                    kunde.PrintRechnungen();
                    Console.ReadLine();
                    break;
                    case "9":
                    einkaufen = false;
                    break;
                    default:
                    break;
                }
            }
        }
    }
}