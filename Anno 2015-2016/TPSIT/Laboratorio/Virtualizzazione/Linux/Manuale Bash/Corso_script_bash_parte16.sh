#!/bin/bash

# visualizzazione di un esempio per tutti i tipi di dialogo
clear
echo "dialogo tipo CALENDAR con tutte le opzioni usate."
read
zenity --calendar --text="Questo è un dialogo di tipo calendario" --day=10 --month=03 --year=2013 --date-format=%d.%m.%Y
read

clear
echo "dialogo tipo ENTRY senza opzione del valore inserito nascosto."
read
zenity --entry --text="Questo è un dialogo di tipo input" --entry-text="Valore per difetto"
read

clear
echo "dialogo tipo ENTRY con opzione del valore inserito nascosto (stile password)."
read
zenity --entry --text="Questo è un dialogo di tipo input protetto" --entry-text="Valore protetto" --hide-text
read

clear
echo "dialogo tipo ERROR con tutte le opzioni usate"
read
zenity --error --no-wrap --no-markup --text="Questo è un dialogo tipo errore." --title="DIALOGO DEMO ERROR" --window-icon='error' --width=400 --height=300

clear
echo "dialogo tipo FILE SELECTION con la modalità di selezione multipla di file e filtro su un tipo di file."
read
zenity --file-selection --title="DIALOGO PER SELEZIONE FILE" --filename="/home/nicola/Documenti/Tecnica/Tutorial/Miei/Corso Bash" --multiple --separator=";" --file-filter="Script | *.sh"
read

clear
echo "dialogo tipo FILE SELECTION con la modalità di selezione di una cartella"
read
zenity --file-selection --title="DIALOGO PER SELEZIONE CARTELLE" --filename="/home/nicola/Documenti/Tecnica/Tutorial/Miei/Corso Bash" --directory
read

clear
echo "dialogo tipo FILE SELECTION con la modalità di selezione di un file e con attivata l'opzione per salvare un file"
read
zenity --file-selection --title="DIALOGO PER SELEZIONE/SALVATAGGIO DI UN FILE" --filename="/home/nicola/Documenti/Tecnica/Tutorial/Miei/Corso Bash/out2.txt" --save --confirm-overwrite
read

clear
echo "dialogo tipo INFO con tutte le opzioni usate e un'icona standard. Resta aperto con un timeout di 3 secondi, poi si chiude da solo."
read
zenity --info --no-wrap --no-markup --text="Questo è un dialogo base e questo è il suo testo" --title="DIALOGO DEMO" --window-icon='warning' --width=400 --height=300 --timeout=3

clear
echo "dialogo tipo INFO con un'icona personalizzata e innesti di linguaggio markup stile tag di HTML."
read
zenity --info --text="Questo è un dialogo base e questo è il suo testo. <big>Blue text</big> is <i>cool</i>!
<sup>L'URL è:</sup> <tt><u>http://www.ubuntu.com</u></tt>" --title="DIALOGO DEMO" --window-icon="/home/nicola/Immagini/Avatar/Face_soccorso.png" --width=380 --height=150

clear
echo "dialogo tipo LIST con opzione di selezione multipla e possibilità di modificare i testi delle voci"
read
zenity --list --title="Elenco voci da selezionare" --text="Questo è un dialogo di tipo elenco oggetti" --width=250 --height=250 --column="TIPO" --column "OGGETTO" Frutto Mela Frutto Arancia Pianeta Terra Pianeta Luna Verdura Carota Verdura Cipolla --separator=";" --multiple --editable --print-column=2
read

clear
echo "dialogo tipo LIST con opzione di selezione singola con radio-list senza possibilità di modificare i testi delle voci (le voci si ordinano con clic sulle intestazioni delle colonne)"
read
zenity --list --title="Elenco voci fra le quali sceglierne una" --text="Questo è un dialogo di tipo elenco oggetti" --width=250 --height=250 --radiolist --column "Scelta" --column="TIPO" --column "OGGETTO" FALSE Frutto Mela TRUE Frutto Arancia FALSE Pianeta Terra FALSE Satellite Luna FALSE Verdura Carota FALSE Verdura Cipolla --print-column=3
read

clear
echo "dialogo tipo LIST con opzione di selezione multipla con check-list senza possibilità di modificare i testi delle voci e senza intestazione delle colonne"
read
zenity --list --title="Elenco voci fra le quali sceglierne anche più di una" --text="Questo è un dialogo di tipo elenco oggetti" --width=250 --height=250 --checklist --separator=";" --multiple --hide-header --column "Scelta" --column="TIPO" --column "OGGETTO" FALSE Frutto Mela TRUE Frutto Arancia FALSE Pianeta Terra FALSE Satellite Luna FALSE Verdura Carota FALSE Verdura Cipolla --print-column=3
read

clear
echo "dialogo tipo PROGRESS per mostrare lo stato d'avanzamento di un'operazione. Richiede l'input di un altro comando. Usiamo il comando find per elencare tutti i file della home, giusto per mostrare l'effetto di progressione della barra d'avanzamento."
read
find -name '*.jpg' | zenity --progress --title="AVANZAMENTO..." --text="Visualizzazione grafica dell'avanzamento dell'operazione richiesta" --auto-kill --pulsate

clear
echo "dialogo tipo QUESTION con pulsanti standard."
read
zenity --question --title="DOMANDA...?..." --text="Pensi che questo dialogo possa fare al caso nostro?"
echo $?
read

clear
echo "dialogo tipo QUESTION con pulsanti personalizzati."
read
zenity --question --title="DOMANDINA...?..." --text="Pensi che questo dialogo possa fare al caso nostro?" --ok-label="Ma certo!" --cancel-label="Purtroppo per niente :-("

clear
echo "dialogo tipo TEXT INFO con pulsanti standard. Senza possibilità di modifica del testo e con la casellina di accettazione. Richiede un file di testo salvato a parte."
read
zenity --text-info --title="TESTO INFORMATIVO..." --filename="/home/nicola/Documenti/Tecnica/Tutorial/Miei/Corso Bash/out.txt" --checkbox="Accetto le condizioni"
echo $?
read

clear
echo "dialogo tipo TEXT INFO con pulsanti personalizzati. È possibile modificare il testo prima di proseguire. Richiede un file di testo salvato a parte."
read
zenity --text-info --title="TESTO INFORMATIVO..." --filename="/home/nicola/Documenti/Tecnica/Tutorial/Miei/Corso Bash/out.txt" --ok-label="Mi sta bene" --cancel-label="No, rinuncio" --editable
read

clear
echo "dialogo tipo WARNING per visualizzare un avviso."
read
zenity --warning --title="Attenzione AVVISO..." --text="Prestare attenzione a questo avviso prima di proseguire!"

clear
echo "dialogo tipo SCALE per visualizzare un oggetto a scorrimento per impostare un valore su una scala (il parametro [step] è attivo quando ci si muove con le frecce, mentre con il mouse si va di un'unità alla volta)."
read
zenity --scale --title="Impostare il valore desiderato sulla scala" --text="Valore soglia da non superare:" --value=10 --min-value=2 --max-value=150 --step=10
read

clear
echo "dialogo tipo COLOR SELECTION per scegliere un codice di colore."
read
zenity --color-selection --title="Scegliere il colore preferito" --color="red" --show-palette
read

clear
echo "dialogo tipo PASSWORD per inserire user e password (o solo la password se non c'è l'opzione del campo user)."
read
zenity --password --title="Introdurre le credenziali d'accesso" --username
read

clear
echo "dialogo tipo FORMS per inserire diverse informazioni in campi separati. Sono possibili campi liberi (testo e/o numeri), campi protetti tipo password e calendari per scelta date."
read
zenity --forms --title="Introdurre tutti i dati necessari" --width=750 --text="Modulo per la ripresa dei dati del corso sugli script bash" --separator=";" --forms-date-format=%d.%m.%Y --add-entry="Titolo corso:" --add-password="Codice segreto del corso:" --add-calendar="Data inizio:" --add-calendar="Data fine:" --add-entry="Osservazioni del partecipante:"
read
echo "dialogo tipo elenco caricato direttamente con tipi di file"
find . -name "*.sh" -or -name "*.txt" | zenity --list --column "Bash scripts"
read

# interazione con i diversi dialoghi di zenity
# --------------------------------------------
# quando il dialogo prevede un solo valore di ritorno si
# può interrogare con questo comando dopo l'esecuzione del
# dialogo: param=$?
# il valore "vero" è 0 (per esempio pulsante OK premuto),
# il valore "falso" è 1 (per esempio pulsante Anulla premuto).
clear
echo "esempi di interazione con i dialoghi"
read
zenity --question --title="DOMANDA...?..." --text="Pensi che questo dialogo possa fare al caso nostro?"
par=$?
echo "Hai risposto: $par"
read

# oppure si può assegnare il valore di ritorno direttamente ad
# una variabile quando questo è diverso dal semplice vero/falso
clear
data=`zenity --calendar --text="Selezionare una data" --day=10 --month=03 --year=2013 --date-format=%d.%m.%Y`
echo "Data scelta=$data"
read

# quando il dialogo prevede più valori di ritorno, come il tipo forms,
# allora bisogna poter separare i valori tornati in una sola stringa
# nei singoli parametri previsti. Noi solitamente impostiamo il punto
# e virgola per separare un valore dall'altro, ma può essere qualsiasi
# carattere, come il pipe "|" usato da zenity laddove non possiamo
# sceglierlo noi.
# Il modo più semplice per distinguere i singoli valori fra un 
# separatore e l'altro è quello di modificare temporaneamente il
# separatore di elenchi di sistema che per difetto è lo spazio.
# Il separatore di elenchi è contenuto nella variabile $IFS.
# Qui sotto un esempio che usa il separatore per difetto. Vogliamo
# elencare ad uno ad uno i pianeti che sono contenuti in una stringa
# separati da uno spazio
clear
echo "Elenco dei pianeti del nostro sistema solare (separati da spazi):
================================================================"
Pianeti="Mercurio Venere Pianeta-Terra Marte Giove Saturno Uranio Nettuno"
for pianeta in $Pianeti
do
	echo $pianeta
done
read

# Qui sotto un esempio che usa il separatore ";". Vogliamo
# elencare ad uno ad uno i pianeti che sono contenuti in una stringa
# separati da un punto e virgola
echo;echo "Elenco dei pianeti del nostro sistema solare (separati da ;):
============================================================"
Pianeti_sep="Mercurio;Venere;Pianeta Terra;Marte;Giove;Saturno;Uranio;Nettuno"
# modifico temporaneamente il separatore standard
IFS=';'
for pianeta in $Pianeti_sep
do
	echo $pianeta
done

# salvo i valori separati in una tupla e li elenco nuovamente
Tabe=($Pianeti_sep)
echo;echo "La tupla Tabe(*) contiene ora: " ${Tabe[*]}
# visualizzo la tupla finché ci sono valori
echo;echo "Elenco dei pianeti dalla tupla scorrendo il suo indice:
======================================================"
i=0

while [ -n "${Tabe[$i]}" ] #equivalente: while [ "${Tabe[$i]}" != "" ]
do
	echo " Indice=$i - Tabe($i)=" ${Tabe[$i]}
	let "i++" 
done  
# reimposto il separatore standard (spazio)
IFS=' '

