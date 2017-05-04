while (bedingung) {
	// bedingung ist hier immer true
}
do {
	// bedingung darf false das erste Mal sein!
	// Ueberpruefung findet erst am Ende statt!
} while (bedingung)

// for (schleife var; bedingung; step)
for (int i=0; i < 10; ++i) {
	// hier ist bedingung immer wahr
	if (i == 7)
		break; // Schleife geht nicht weiter zu 8, 9
	if (i > 4)
		// Wenn i > 4, restliche Iteration ueberspringen
		continue;
	Console.WriteLine(i);
	// zeigt: 0, 1, 2, 3, 4 aber nicht 5,6,7
}
// In einer for sind:
//   schleife var, bedingung und step ALLE optional