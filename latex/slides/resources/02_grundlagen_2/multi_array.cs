// Ein leeres Array initiallisieren.
int[,] zahlenListe1 = new int[2, 3];
// Ein Array mit Inhalt initialisieren.
int[,] zahlenListe2 = { { 1, 2, 3 }, { 4, 5, 6 } };
// Auf ein Element des Arrays zugreifen.
zahlenListe1[0, 1] = 6 + zahlenListe2[1, 1]; // 6 + 5