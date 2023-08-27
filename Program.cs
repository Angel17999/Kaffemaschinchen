using System;
using System.Threading;
bool bestellung = true;
string weiter;
do
{
    Console.WriteLine("Guten Tag,\nWas möchten sie trinken?\n1.Kaffee\n2.Latte\n3.Kakao");
    Console.WriteLine("Geben sie die Nummer ihres Getränks ein:");
    string milk;
    string sugar;
    int auswahl = Convert.ToInt32(Console.ReadLine());
    switch (auswahl)
    {
        case 1:
            Console.WriteLine("Ihre Wahl ist also Kaffee.\nZubereitung läuft");
            Console.WriteLine("Bohnen werden gemahlen....");
            Thread.Sleep(5000);
            Console.WriteLine("Wasser erhitzt....");
            Thread.Sleep(5000);
            Console.WriteLine("Kaffee aufgeschüttet!");
            Console.WriteLine("Möchten sie Milch in ihrem Kaffee?");
            milk = Console.ReadLine();
            if (milk == "yes" || milk == "ja")
            {
                Console.WriteLine("Milch wird hinzugefügt....");
                Thread.Sleep(3000);
            }
            else
            {
                Console.WriteLine("Okay, keine Milch wird hinzugefügt");
            }
            Console.WriteLine("Zucker?");
            sugar = Console.ReadLine();
            if (sugar == "yes" || sugar == "ja")
            {
                Console.WriteLine("Zucker wird hinzugefügt....");
                Thread.Sleep(3000);
            }
            else
            {
                Console.WriteLine("Kein Zucker wird hinzugefügt.");
            }
            Console.WriteLine("Ihr Kaffee ist fertig.");
            break;
        case 2:
            Console.WriteLine("Ihre Wahl ist also Latte.\nZubereitung läuft");
            Console.WriteLine("Milch wird hinzugefügt und erhitzt....");
            Thread.Sleep(5000);
            Console.WriteLine("Bohnen werden gemahlen....");
            Thread.Sleep(5000);
            Console.WriteLine("Wasser erhitzt....");
            Thread.Sleep(5000);
            Console.WriteLine("Latte aufgeschüttet!");
            Console.WriteLine("Möchten sie Zucker?");
            sugar = Console.ReadLine();
            if (sugar == "yes" || sugar == "ja")
            {
                Console.WriteLine("Zucker wird hinzugefügt....");
                Thread.Sleep(3000);
            }
            else
            {
                Console.WriteLine("Kein Zucker wird hinzugefügt.");
            }
            Console.WriteLine("Ihre Latte ist fertig.");
            break;
        case 3:
            Console.WriteLine("Ihre Wahl ist also Kakao.\nZubereitung läuft");
            Console.WriteLine("Milch wird hinzugefügt und erhitzt....");
            Thread.Sleep(5000);
            Console.WriteLine("Kakaopulver wird hinzugefügt....");
            Thread.Sleep(5000);
            Console.WriteLine("Kakao aufgeschüttet!");
            Console.WriteLine("Möchten sie extra Zucker?");
            sugar = Console.ReadLine();
            if (sugar == "yes" || sugar == "ja")
            {
                Console.WriteLine("Zucker wird hinzugefügt....");
                Thread.Sleep(3000);
            }
            else
            {
                Console.WriteLine("Kein Zucker wird hinzugefügt.");
            }
            Console.WriteLine("Ihre Latte ist fertig.");
            break;
        default:
            Console.WriteLine("Falsche Eingabe.\nVersuchen sie es erneut");
            break;

    }
    Console.WriteLine("Möchten sie erneut etwas bestellen ?");
    weiter = Console.ReadLine();
    if (weiter == "yes" || weiter == "ja")
    {
        continue;
    }
    else if (weiter == "no" || weiter == "nein")
    {
        Console.WriteLine("Vielen Dank für ihre Bestellung!");
        bestellung = false;
    }
    else
    {
        Console.WriteLine("Auf wiedersehen:D");
    }

} while (bestellung == true);
        
