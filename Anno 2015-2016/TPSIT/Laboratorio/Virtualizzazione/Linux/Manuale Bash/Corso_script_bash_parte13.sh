#!/bin/bash

clear

if [ "$1" = "gui" ] || [ "$1" = "GUI" ] 
then
	echo "------------------------------------------"
	echo "Eseguo lo script con l'interfaccia grafica"
	echo "------------------------------------------"
else	
	if [ "$1" = "cli" ]
	then
		echo "-----------------------------------------------------------"
		echo "Eseguo lo script con l'interfaccia a caratteri del teminale"
		echo "-----------------------------------------------------------"
	else
		echo
		echo "!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!"
		echo -e "Parametro d'esecuzione errato o mancante\r\n(hai impostato: \"$1\")"
		echo 
		echo "I parametri validi per questo script sono (senza virgolette):"
		echo "\"gui\" o \"GUI\" per avviare lo script in modalità grafica"
		echo "\"cli\" per avviare lo script in modalità terminale"
		echo "!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!"
		echo
		exit 99
	fi
fi

