#!/bin/bash

clear

# Esempio di comando case
M=15
N=3
case "$M" in
	0) ;;       # non fa niente
	"$N")       echo "M e N sono uguali";;
	2 | 4 | 15) echo "il valore di M è 2 o 4 o 15";;
	[0-9])      echo "il valore di M è una cifra tra 0 e 9";;
	[0-9]*)     echo "il valore di M inizia con un numero";;
	[a-zA-Z])   echo "il valore di M è una lettera dell'alfabeto";; 
	[a-zA-Z]*)  echo "il valore di M inizia con una lettera";; 
	[!0-9]*)    echo "il valore di M non inizia con un numero";; 
	*)          echo  "Errore - parametro non previsto";;
esac

