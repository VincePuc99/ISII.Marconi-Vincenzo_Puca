#!/bin/bash

clear

glo_var="" #variabile globale vista dentro e fuori le funzioni
ouptut=0   #variabile globale vista dentro e fuori le funzioni

# Esempio di funzione senza parametri
mia_fun()
{ 
	local loc_var=1255
	echo "Questa è la funzione 'mia_fun'"
	echo "##############################"
	glo_var="mia_fun"
	output=$loc_var
	return 5  #al massimo un valore fino a 255
}

# Esempio di funzione con un paio di parametri
mia_fun_par()
{ 
	local loc_var=455
	echo "Questa è la funzione 'mia_fun_par' con parametro1=$1 e parametro2=$2"
	echo "######################################################"
	glo_var="mia_fun_par"
	output=$loc_var
	
	#se il primo parametro è "Pippo" lo script viene interrotto
	if [ "$1" = "Pippo" ]
	then
		echo "L'elaborazione termina qui";read
		exit
	else 
		return 10  #al massimo un valore fino a 255
	fi
}

# Esempio di funzione ricorsiva
# Esegue se stessa finché la variabile "conta" è minore di 10
# È importante che la variabile che funge da contatore sia globale
# perché se fosse locale sarebbe impostata al valore iniziale
# ad ogni esecuzione.
conta=1
mia_fun_ric()
{ 	
	if [ "$conta" -lt 10 ]
	then
		echo "Ciclo nr.$conta per questa funzione ricorsiva"
		echo "---------------------------------------------"
		(( conta++ ))
		mia_fun_ric
	fi
}

# codice principale dello script
echo "RICHIAMO mia_fun";read
mia_fun
echo "Codice ritorno di mia_fun=$?"
echo "glo_var=$glo_var"
echo "loc_var=$loc_var e output=$output"
echo

echo "RICHIAMO mia_fun_par";read
par1="Pippa"
par2="Paperina"
mia_fun_par $par1 $par2
echo "Codice ritorno di mia_fun_par=$?"
echo "glo_var=$glo_var"
echo "loc_var=$loc_var e output=$output"
echo

echo "RICHIAMO mia_fun_ric";read
mia_fun_ric
echo
echo "Elaborazione terminata"

