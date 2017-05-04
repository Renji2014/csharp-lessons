// Eindimensionale Arrays:
int[] zahlenListe1 = new int[5]; // die 5 Elemente sind 0
int[] zahlenListe2 = { 1, 2, 3, 4, 5 }; // in-line Init.
// Indizes sind 0, 1, ..., n-1 (wobei n = Arrays Laenge)
zahlenListe[1] = zahlenListe2[2] + zahlenListe2[4]; // 3 + 5

// Mehrdimensionale Arrays (Array von Arrays)
int[][] zahlenListe1 = new int[2][];
// die 2 Elemente von zahlenListe1 sind _null_.
// die Elemente muessen intialisiert werden,
zahlenListe1[0] = new int[7];  // sie duerfen untersch.
zahlenListe1[1] = new int[18]; // Laenge haben!
//
// In-line Initialisierung eines mehrdimensionales Arrays
int[][] zahlenListe2 = { new int[] { 1, 2 },
                         new int[] { 3, 4, 5 } };

// Verzweigte Arrays
int[,] zahlenListe1 = new int[2, 3]; // die 6 Elm. sind 0
// In-line Initialisierung
int[,] zahlenListe2 = { { 1, 2, 3 }, { 4, 5, 6 } };