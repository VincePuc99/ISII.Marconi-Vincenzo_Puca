#!/bin/bash

clear

# operazioni base: somma, sottrazione, moltiplicazione, divisione
A=20
B=35
SOMMA=$((A+B))
echo Somma=$SOMMA
SOTTR=$((A-B))
echo Sottrazione=$SOTTR
MOLT=$((A*B))
echo Moltiplicazione=$MOLT
DIVI=$((A/B))
echo "Divisione con aritmetica bash"=$DIVI
DIVI=$(echo "scale=5; $A/$B" | bc -l)
echo "Divisione con comando bc"=$DIVI


# Somma di due valori della tupla e salvataggio del risultato in un altro indice
Numeri=( 25 43 60 2 15 )
# sintassi di calcolo 1
Numeri[5]=`expr ${Numeri[1]} + ${Numeri[3]}`
echo -n "Numeri[5] = " 
echo ${Numeri[5]}
# sintassi di calcolo 2
Numeri[6]=$((${Numeri[0]} * ${Numeri[2]}))
echo -n "Numeri[6] = " 
echo ${Numeri[6]}

