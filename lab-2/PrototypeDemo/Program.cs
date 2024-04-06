using VirusFamily;

Virus virus = new("Coronavirus", 0.3, "COVID-19");
Virus influenza = new("Influenza", 0.1, "Orthomyxovirus");
Virus hiv = new("HIV", 0.2, "Retrovirus");

virus.Children.Add(influenza);
virus.Children.Add(hiv);

influenza.Children.Add(new Virus("H1N1", 0.03, "Influenza A", 2));

Virus H1N1Copy = (Virus)influenza.Children[0].Clone();
H1N1Copy.Name = "AAA2";
H1N1Copy.Age = 0;
influenza.Children.Add(H1N1Copy);

var a = (Virus) virus.Clone();
a.Children[0].Age = 232;
Console.WriteLine(virus);