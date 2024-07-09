#!/bin/bash

clear
# verifica se il valore nella variabile D è pari o dispari
# confronto fra valori numerici
D=113
N=$((D/2))
M=$((N*2))
echo D=$D
echo N=$N
echo M=$M

if [ "$D" -ne "$M" ] 
then
	echo "Il valore della variabile D è DISPARI"
else
    echo "Il valore della variabile D è PARI"
fi

D=1124
N=$((D/2))
M=$((N*2))
echo; echo D=$D
echo N=$N
echo M=$M

if [ "$D" -eq "$M" ] 
then
	echo "Il valore della variabile D è PARI"
else
    echo "Il valore della variabile D è DISPARI"
fi

read


# confronto fra stringhe
S1="Paperino"
S2="zio Paperone"
S3="Paperino"

echo "======================================================="
echo "S1="$S1;echo "S2="$S2;echo "S3="$S3;echo

if [ "$S1" = "$S3" ] 
then
	echo "Le stringhe S1 e S3 sono uguali"
fi

if [ "$S1" != "$S2" ] 
then
	echo "Le stringhe S1 e S2 non sono uguali"
fi

if [ "${S1:0:2}" = "${S2:4:2}" ] 
then
	echo "Le stringhe S1 e S2 hanno la parte 'Pa' in comune"
fi

if [ -n "$S1" ] 
then
	echo "La stringa S1 non è vuota"
fi

if [ -z "$S4" ] 
then
	echo "La stringa S4 è vuota o inesistente"
fi

if [ "$S1" \< "$S2" ] 
then
	echo "La stringa S1 è più corta della stringa S2"
fi

if [ "$S2" \> "$S1" ] && [ -n "$S3" ] 
then
	echo "La stringa S2 è più lunga della stringa S1 e la stringa S3 non è vuota"
fi


