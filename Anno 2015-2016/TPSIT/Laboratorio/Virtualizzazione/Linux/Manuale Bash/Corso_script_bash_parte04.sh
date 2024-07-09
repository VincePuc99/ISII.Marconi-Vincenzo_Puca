#!/bin/bash

clear

# le tuple - i differenti modi di definirle
Settimana[1]=Lunedì
Settimana[2]=Martedì
Settimana[3]=Mercoledì
Settimana[4]=Giovedì
Settimana[5]=Venerdì
Settimana[6]=Sabato
Settimana[7]="Domenica - il meritato riposo"

Mesi=([1]=gennaio [2]=febbraio [3]=marzo [4]=aprile [5]=maggio [6]=giugno [7]=luglio [8]=agosto [9]=settembre [10]=ottobre [11]=novembre [12]=dicembre)
Valori=( zero uno due tre quattro )

# la tupla si può interrogare con il suo indice:
echo ${Settimana[1]}
echo ${Settimana[5]}
echo "numero valori nella tupla Settimana="${#Settimana[*]}
echo ${Mesi[*]}
echo ${Valori[0]}
echo ${Valori[1]}

