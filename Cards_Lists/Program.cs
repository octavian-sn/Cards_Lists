using Cards_Lists;
using System;

 Random random = new Random();


Card card = new Card((Values)random.Next(1, 14), (Suits)random.Next(4));
Console.WriteLine(card.Name);
