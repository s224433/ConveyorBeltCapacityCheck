#Til at starte med har jeg brugt Console.WriteLine, så programmet kan stille et spørgmål til brugeren. Det første der bliver spurgtb om er om antallet af motorer. Jeg indsætter derefter Console.ReadLine() og det laves om til et hel tal med int.Parse(), fordi at vægten kan indholde decimaler. Det bliver så gemt i variablen weight.

#Efterførlgende laver jeg en beregning: avgLoadPerMotor = weight / motors. Den her formel viser, hvor meget hver motorn kan bære i gennemsnittet.

#Til slut bruger jeg en if/else. hvis gennemsnittet er mindre end eller lig med 5.6 kg, skriver programmet en besked om, at transportbåndet kan bære vægten, og hvis ikke det kan det, udskirver programmet at det ikke kan lade sig gøre.

#Jeg har testet 1 scenarie som er ; 4 motorer og 20 kg → giver "Yes" (fordi 20 / 4 = 5 ≤ 5.6).
