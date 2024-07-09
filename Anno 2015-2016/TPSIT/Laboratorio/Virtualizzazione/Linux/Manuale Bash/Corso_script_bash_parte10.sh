#!/bin/bash

clear

# Esempi di comando for con lista argomenti
echo "******************** FOR CON LISTA ARGOMENTI SINGOLI *******************"
for pianeta in "Mercurio" "Venere" "Terra" "Marte" "Giove"
do
	echo "$pianeta"
done
echo
read

echo "******************** FOR CON LISTA FILE IN CARTELLA *******************"
for docu in $(ls *.sh) 
do
	echo "File contenuto nella cartella: $docu"
done
echo
read

echo "******************** FOR CON LISTA ARGOMENTI MULTIPLI *******************"
for pianeta in "Mercurio 36 circa" "Venere 67 circa" "Terra 93 circa" "Marte 142 circa" "Giove 483 circa"
do
	set -- $pianeta
	echo "$1 è distante $2,000,000 di miglia dal sole $3"
done
echo
read

# Esempio di comando for con limite
echo "******************** FOR CON LIMITE *******************"
LIMITE=10
for ((a=1; a <= LIMITE ; a++))
do
	echo -n "$a "
done
echo
read

# esempio di comando while (fino a che)
echo "******************** WHILE *******************"
var0=0
LIMITE=10
while [ "$var0" -lt "$LIMITE" ]  #equivalente: while (( var0 < LIMITE ))
do
	echo -n "$var0 "
	var0=`expr $var0 + 1` #equivalente: var0=$((var0+1))
done

echo
read

# esempio di comando until (fino al momento in cui)
echo "******************** UNTIL *******************"
LIMITE=10
var=0
until (( var > LIMITE ))
do
	echo -n "$var "
	(( var++ ))
done
echo

