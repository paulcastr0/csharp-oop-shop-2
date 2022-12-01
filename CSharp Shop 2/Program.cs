// See https://aka.ms/new-console-template for more information
using CSharp_Shop_2;

Console.WriteLine("Hello, World!");

List<Prodotto> scaffaliNegozio = new List<Prodotto>() {
    new Prodotto("Goleador", "Una buona caramella", 0.10, 22),
    new Prodotto("Pokémon Scarlatto", "Il nuovo gioco dei Pokémon", 60, 22),
    new Prodotto("Evangelion#1", "Il primo volume del manga di Evangelion", 4.5, 4),
    new Prodotto("Bottiglia di Latte", "Una bottiglia da un litro di latte", 1.6, 4)
    };
foreach (Prodotto prodotto in scaffaliNegozio)
{
    prodotto.StampaProdotto();
}