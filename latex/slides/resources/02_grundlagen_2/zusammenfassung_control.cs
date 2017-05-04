// If then else (wenn dann sonst)
int zahl;
if (bedingung) { // then
	// Hier ist bedingung true
	zahl = 2;
} else {
	// Hier ist bedingung false
	zahl = 3;
}
// In-line if / Tertiaere-Verzweigung
// Wenn bedingung, dann zahl = 2, sonst zahl = 3
int zahl = (bedingung) ? 2 : 3;

// Switch - Weg abhaengig vom Wert einer Var.
int zahl = 3;
switch (zahl) {
	case 0: Console.WriteLine("Zahl==0"); break;
	case 1: Console.WriteLine("Zahl==1"); break;
	case 2:
	case 3: Console.WriteLine("Zahl==2 ODER 3"); break;
	default: Console.WriteLine("Zahl <> 0,1,2,3"); break;
}
