#!/bin/bash

clear

# verifica l'esistenza di un file
if [ -e "/home/nicola/Documenti/Tecnica/Tutorial/Miei/Corso Bash/Corso_script_bash_finalex.sh" ]
then
	echo "OK, il file dello script esiste; molto bene :-)"
	# usato un nostro file immagine come icona
	notify-send -a "Corso script bash" -i "/home/nicola/Documenti/Tecnica/Tutorial/Miei/foto1_mouse.png" "PERFETTO, il file dello script esiste ed è nella giusta cartella :-)"
else
	echo "MALEDIZIONE, il file dello script non esiste; molto male :-("
	# usata una delle icone predefinite di sistema (stock-icon)
	notify-send -a "Corso script bash" -i notification-power "Accidenti, manca un file molto importante. Verificare l'installazione!"
fi
