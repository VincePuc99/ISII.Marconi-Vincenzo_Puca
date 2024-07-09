#!/bin/bash

clear
# verifica se il valore nelle variabili D1 e D2 è pari o dispari
echo "Immettere due numeri interi: "
read D1 D2
N=$((D1/2))
M=$((N*2))
echo D1=$D1
echo N=$N
echo M=$M

if [ "$D1" -ne "$M" ] 
then
	echo "Il valore della variabile D1 è DISPARI"
else
    echo "Il valore della variabile D1 è PARI"
fi

N=$((D2/2))
M=$((N*2))
echo D2=$D2
echo N=$N
echo M=$M

if [ "$D2" -ne "$M" ] 
then
	echo "Il valore della variabile D2 è DISPARI"
else
    echo "Il valore della variabile D2 è PARI"
fi

# prende quanto immesso dall'utente e lo archivia in una tupla
echo
echo "Immetti i tuoi colori preferiti separati da uno spazio"
read -a colori
echo
echo "Numero di colori immesso=${#colori[*]}"
echo "Colori specificati: ${colori[*]}"
echo
read

# legge le righe da un file ad una ad una e le visualizza in maiuscolo
i=0
while read -r testofile
do
	(( i++ ))
	echo -e "riga letta nr.$i: ${testofile^^}\r\n"
done < "/home/nicola/Documenti/Tecnica/Tutorial/Miei/Corso Bash/out.txt"
read

clear
# intercettazione del tasto speciale "F12"
Escape=$'\x1b'
F12=$Escape"[24~"
echo;echo "Premi il tasto F12: "
read -s -n5 ris
if [ "$ris" = "$F12" ]
then
	echo "ok hai premuto F12"
else
	echo "hai premuto un tasto diverso da F12"
fi

