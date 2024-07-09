#!/bin/bash

################################################################################
# Questa shell ha solo scopo didattico ed è stata costruita durante il corso
# di programmazione sugli script bash pubblicato sul mio canale Youtube
# (http://www.youtube.com/user/VosaxAlo).
#
# autore : Nicola Jelmorini 
# anno   : 2012-2013
# licenza: questo script è software libero: puoi ridistribuirlo e/o modificarlo
#          rispettando i termini della licenza GNU General Public License
#          stabiliti dalla Free Software Foundation, versione 3.
#          Questo script è distribuito nella speranza che possa essere utile,
#          ma SENZA ALCUNA GARANZIA.
#          Consulta la licenza GNU General Public License per avere ulteriori
#          dettagli. 
#          Dovresti aver ricevuto una copia della GNU General Public License
#          insieme a questo programma. 
#          Se non è così, visita <http://www.gnu.org/licenses/>.
#
#
# Uso dello script: seguire semplicemente le istruzioni e le indicazioni che
#                   visualizza lo script stesso
#
################################################################################

clear #pulizia del terminale prima dell'inizio dello script

################################################################################
# Definizioni delle variabili globali utilizzate nel resto dello script
# ------------------------------------------------------------------------------
# Formattazione del testo nel terminale. Le definizioni seguenti controllano
# varie caratteristiche del testo che appare a terminale
sottolineato=$(tput smul)     # attiva il sottolineato
nonsottolineato=$(tput rmul)  # disattiva il sottolineato
grassetto=$(tput bold)        # attiva il grassetto
inverso=$(tput rev)           # attiva la modalità inversa
normale=$(tput sgr0)          # annulla tutti gli effetti e torna al default
txtrosso=$(tput setaf 1)      # carattere rosso
txtverde=$(tput setaf 2)      # carattere verde
txtgiallo=$(tput setaf 3)     # carattere giallo
txtblu=$(tput setaf 4)        # carattere blu
txtporpora=$(tput setaf 5)    # carattere porpora
txtciano=$(tput setaf 6)      # carattere ciano (azzurro)
txtbianco=$(tput setaf 7)     # carattere bianco
txtsforosso=$(tput setab 1)   # sfondo carattere rosso
txtsfoverde=$(tput setab 2)   # sfondo carattere verde
txtsfogiallo=$(tput setab 3)  # sfondo carattere giallo
txtsfoblu=$(tput setab 4)     # sfondo carattere blu
txtsfoporpora=$(tput setab 5) # sfondo carattere porpora
txtsfociano=$(tput setab 6)   # sfondo carattere ciano (azzurro)
txtsfobianco=$(tput setab 7)  # sfondo carattere bianco
# ------------------------------------------------------------------------------
# Tipo di interfaccia (a caratteri o grafica) scelto alla partenza dello script
TipoInterfaccia=$1
#-------------------------------------------------------------------------------
# Tuple con i pianeti del sistema solare e la loro distanza (mio-km) dal Sole
Pianeti[1]="Mercurio";Distanza[1]=57,91
Pianeti[2]="Venere"  ;Distanza[2]=108,00
Pianeti[3]="Terra"   ;Distanza[3]=149,60
Pianeti[4]="Marte"   ;Distanza[4]=227,94
Pianeti[5]="Giove"   ;Distanza[5]=778,40
Pianeti[6]="Saturno" ;Distanza[6]=1426,98
Pianeti[7]="Urano"   ;Distanza[7]=2870,00
Pianeti[8]="Nettuno" ;Distanza[8]=4497,00
# ------------------------------------------------------------------------------
# Tuple per i mesi e i giorni della settimana
Mesi[1]="gennaio"
Mesi[2]="febbraio"
Mesi[3]="marzo"
Mesi[4]="aprile"
Mesi[5]="maggio"
Mesi[6]="giugno"
Mesi[7]="luglio"
Mesi[8]="agosto"
Mesi[9]="settembre"
Mesi[10]="ottobre"
Mesi[11]="novembre"
Mesi[12]="dicembre"

Settimana[1]="lunedì"
Settimana[2]="martedì"
Settimana[3]="mercoledì"
Settimana[4]="giovedì"
Settimana[5]="venerdì"
Settimana[6]="sabato"
Settimana[7]="domenica"


################################################################################
# Definizioni delle funzioni usate nello script
# ------------------------------------------------------------------------------
# Scelta del tipo di interfaccia, se non già fatta alla partenza dello script
# T -> a caratteri (solo terminale)
# G -> con interfaccia grafica
tipo_interfaccia()
{ 
	if [ "$TipoInterfaccia" != "T" ] && [ "$TipoInterfaccia" != "G" ]
	then

		echo "Desideri usare la versione con interfaccia a caratteri nel terminale, oppure quella con interfaccia grafica? (T)erminale/(G)rafica:"
		read TipoInterfaccia
		case "$TipoInterfaccia" in
			"T") echo "${txtverde}Hai scelto il teminale${normale}";read;clear;echo -e "${txtsforosso}${grassetto}                                 A V V I S O                                 ${normale}\r\n${txtsforosso} ${normale}Questo script è stato creato per essere usato a tutto schermo.\r\n${txtsforosso} ${normale}Se non l'hai ancora fatto massimizza la finestra del tuo terminale.\r\n${txtsforosso} ${normale}Grazie. (${grassetto}${sottolineato}CTRL+C${normale} per uscire dallo script ora, oppure ${grassetto}${sottolineato}ENTER${normale} per continuare)";read;interfaccia_terminale;;
			"G") echo "${txtverde}Hai scelto l'interfaccia grafica${normale}";read;interfaccia_grafica;;	
			*)   echo  "${txtrosso}Errore - devi scegliere un tipo di interfaccia valido!${normale}";tipo_interfaccia;;
		esac
	else
		case "$TipoInterfaccia" in
			"T") echo -e "${txtsforosso}${grassetto}                                 A V V I S O                                 ${normale}\r\n${txtsforosso} ${normale}Questo script è stato creato per essere usato a tutto schermo.\r\n${txtsforosso} ${normale}Se non l'hai ancora fatto massimizza la finestra del tuo terminale.\r\n${txtsforosso} ${normale}Grazie. (${grassetto}${sottolineato}CTRL+C${normale} per uscire dallo script ora, oppure ${grassetto}${sottolineato}ENTER${normale} per continuare)";read;interfaccia_terminale;;
			"G") interfaccia_grafica;;
		esac
	fi
}


# ------------------------------------------------------------------------------
# Tipo di interfaccia a caratteri solo con il terminale
interfaccia_terminale()
{ 
clear
# Menu principale dello script
echo "${txtsfociano}${grassetto}                              M E N U  P R I N C I P A L E                              ${normale}"
echo "${txtsfociano} ${normale} 1) dammi una data in cifre (gg.mm.aaaa) per ottenerla in formato esteso              ${txtsfociano} ${normale}"
echo "${txtsfociano} ${normale} 2) wizard esplicativo sul funzionamento dell'interfaccia Unity di Ubuntu             ${txtsfociano} ${normale}"
echo "${txtsfociano} ${normale} 3) elenco di file di una cartella                                                    ${txtsfociano} ${normale}"
echo "${txtsfociano} ${normale} 4) richiamo della calcolatrice di Gnome                                              ${txtsfociano} ${normale}"
echo "${txtsfociano} ${normale} 5) scrittura di un file di testo                                                     ${txtsfociano} ${normale}"
echo "${txtsfociano} ${normale} 6) lettura di un file di testo                                                       ${txtsfociano} ${normale}"
echo "${txtsfociano} ${normale} 7) informazioni sul presente sistema Ubuntu                                          ${txtsfociano} ${normale}"
echo "${txtsfociano} ${normale} 8) quanti sono e quanto distano i pianeti dal nostro Sole?                           ${txtsfociano} ${normale}"
echo "${txtsfociano} ${normale} X) esci dal menu e termina questo script                                             ${txtsfociano} ${normale}"
echo -n "${txtsfociano}                                                            Scegli un'opzione dal menu:"
read SceltaMenu
echo "${normale}"
case "$SceltaMenu" in
	1) menu1;;
	2) menu2;;
	3) menu3;;
	4) menu4;;
	5) menu5;;
	6) menu6;;
	7) menu7;;
	8) menu8;;
	"X" | "x") clear;notify-send -a "Corso script bash" -i face-smile-symbolic "Grazie per aver usato questo script bash :-)";exit;;
	*) echo "${txtsforosso}Errore - opzione menu non prevista!${normale}";read;interfaccia_terminale;;
esac
} # interfaccia_terminale


# ------------------------------------------------------------------------------
# Opzione 1 del menu dell'interfaccia terminale
menu1()
{ 
clear
echo "1) dammi una data in cifre (gg.mm.aaaa, es. 05.03.2012) per ottenerla in formato esteso"
read Data
# se la data non rispetta un minimo di coerenza formale non viene accettata
if [ "${#Data}" -ne 10 ] || [ "${Data:0:2}" -gt 31 ] || [ "${Data:3:2}" -gt 12 ]
then
	echo "${txtsforosso}Errore - data non valida!${normale} (${inverso}digitare M e premere ENTER${normale} per tornare al menu principale)";read Ris
	if [ "${Ris^^}" = "M" ]
	then
		interfaccia_terminale
	else
		menu1
	fi
else
	giorno=${Data:0:2}
	mese=${Data:3:2};mese=${mese#*0} #elimina lo zero superfluo davanti al numero del mese per usarlo come indice della tupla
	anno=${Data:6:4}
	giorno_settimana=`date --date=$mese/$giorno/$anno +%u`
	settimana_anno=`date --date=$mese/$giorno/$anno +%V`
	echo
	echo "--------------------------------------------------------------------------------------------"
	echo "${txtsfogiallo}La data inserita è un ${Settimana[$giorno_settimana]} di ${Mesi[$mese]} dell'anno $anno, giorno nr. $giorno, settimana nr. $settimana_anno${normale}"
	echo "--------------------------------------------------------------------------------------------"
	echo;echo "(${inverso}digitare M e premere ENTER${normale} per tornare al menu principale)";read Ris
	if [ "${Ris^^}" = "M" ]
	then
		interfaccia_terminale
	else
		menu1
	fi
fi
} # menu1

# ------------------------------------------------------------------------------
# Opzione 2 del menu dell'interfaccia terminale
menu2()
{ 
clear
echo;echo;echo
echo "     ${txtsfoblu}${grassetto}     WIZARD ESPLICATIVO SUL FUNZIONAMENTO BASE DELL'INTERFACCIA DI UBUNTU     ${normale}"
echo "     ${txtsfoblu} ${normale}                                                                            ${txtsfoblu} ${normale}"
echo "     ${txtsfoblu} ${normale} Unity è un'interfaccia molto intuitiva che si basa su 4 elementi           ${txtsfoblu} ${normale}"
echo "     ${txtsfoblu} ${normale} fondamentali:                                                              ${txtsfoblu} ${normale}"
echo "     ${txtsfoblu} ${normale} - il Launcher                                                              ${txtsfoblu} ${normale}"
echo "     ${txtsfoblu} ${normale} - la Dash                                                                  ${txtsfoblu} ${normale}"
echo "     ${txtsfoblu} ${normale} - HUD (Head-up display)                                                    ${txtsfoblu} ${normale}"
echo "     ${txtsfoblu} ${normale} - il pannello superiore                                                    ${txtsfoblu} ${normale}"
echo "     ${txtsfoblu} ${normale}                                                                            ${txtsfoblu} ${normale}"
echo "     ${txtsfoblu} ${normale}                                                                            ${txtsfoblu} ${normale}"
echo -n "     ${txtsfoblu}                                         (Enter/A)vanti   (M)enu principale  "
read Ris
echo "${normale}"
case "$Ris" in
	"") menu2_1;;
	"A" | "a") menu2_1;;
	"M" | "m") interfaccia_terminale;;
	*) echo "${txtsforosso}Errore - opzione menu non prevista!${normale}";read;menu2;;
esac
} # menu2

menu2_1()
{ 
clear
echo;echo;echo
echo "     ${txtsfoblu}${grassetto}     WIZARD ESPLICATIVO SU UNITY: IL LAUNCHER                                 ${normale}"
echo "     ${txtsfoblu} ${normale}                                                                            ${txtsfoblu} ${normale}"
echo "     ${txtsfoblu} ${normale} Il Launcher è la barra verticale posizionata sul lato sinistro dello       ${txtsfoblu} ${normale}"
echo "     ${txtsfoblu} ${normale} schermo. Può essere visualizzato permanentemente, oppure può essere        ${txtsfoblu} ${normale}"
echo "     ${txtsfoblu} ${normale} nascosto finché non lo si richiama puntando il mouse sulla sinistra.       ${txtsfoblu} ${normale}"
echo "     ${txtsfoblu} ${normale} Il suo scopo è quello di mettere a disposizione le applicazioni più        ${txtsfoblu} ${normale}"
echo "     ${txtsfoblu} ${normale} usate, mostrare quelle correntemente aperte e passare da un desktop        ${txtsfoblu} ${normale}"
echo "     ${txtsfoblu} ${normale} all'altro.                                                                 ${txtsfoblu} ${normale}"
echo "     ${txtsfoblu} ${normale}                                                                            ${txtsfoblu} ${normale}"
echo "     ${txtsfoblu} ${normale}                                                                            ${txtsfoblu} ${normale}"
echo -n "     ${txtsfoblu}                            (Enter/A)vanti   (I)ndietro   (M)enu principale  "
read Ris
echo "${normale}"
case "$Ris" in
	"") menu2_2;;
	"A" | "a") menu2_2;;
	"I" | "i") menu2;;	
	"M" | "m") interfaccia_terminale;;
	*) echo "${txtsforosso}Errore - opzione menu non prevista!${normale}";read;menu2_1;;
esac

} # menu2_1

menu2_2()
{ 
clear
echo;echo;echo
echo "     ${txtsfoblu}${grassetto}     WIZARD ESPLICATIVO SU UNITY: LA DASH                                     ${normale}"
echo "     ${txtsfoblu} ${normale}                                                                            ${txtsfoblu} ${normale}"
echo "     ${txtsfoblu} ${normale} La Dash è l'oggetto principale dell'interfaccia Unity. Tutto ruota         ${txtsfoblu} ${normale}"
echo "     ${txtsfoblu} ${normale} attorno ad essa. Con la Dash possiamo ricercare ogni tipo di contenuto     ${txtsfoblu} ${normale}"
echo "     ${txtsfoblu} ${normale} sia esso locale che sul web. Grazie a delle Lens specializzate si possono  ${txtsfoblu} ${normale}"
echo "     ${txtsfoblu} ${normale} fare delle ricerche mirate per applicazioni, documenti, immagini, video,   ${txtsfoblu} ${normale}"
echo "     ${txtsfoblu} ${normale} amazon, wikipedia, ecc.                                                    ${txtsfoblu} ${normale}"
echo "     ${txtsfoblu} ${normale} La si richiama con un clic sul pulsante del Launcher con il simbolo di     ${txtsfoblu} ${normale}"
echo "     ${txtsfoblu} ${normale} Ubuntu, oppure premendo il pulsante 'Super'.                               ${txtsfoblu} ${normale}"
echo "     ${txtsfoblu} ${normale}                                                                            ${txtsfoblu} ${normale}"
echo -n "     ${txtsfoblu}                            (Enter/A)vanti   (I)ndietro   (M)enu principale  "
read Ris
echo "${normale}"
case "$Ris" in
	"") menu2_3;;
	"A" | "a") menu2_3;;
	"I" | "i") menu2_1;;	
	"M" | "m") interfaccia_terminale;;
	*) echo "${txtsforosso}Errore - opzione menu non prevista!${normale}";read;menu2_2;;
esac

} # menu2_2

menu2_3()
{ 
clear
echo;echo;echo
echo "     ${txtsfoblu}${grassetto}     WIZARD ESPLICATIVO SU UNITY: HUD (Head-up display)                       ${normale}"
echo "     ${txtsfoblu} ${normale}                                                                            ${txtsfoblu} ${normale}"
echo "     ${txtsfoblu} ${normale} HUD è un tipo di Dash specializzata nella ricerca delle opzioni menu       ${txtsfoblu} ${normale}"
echo "     ${txtsfoblu} ${normale} per l'applicazione della finestra che ha correntemente il fuoco. Bastano   ${txtsfoblu} ${normale}"
echo "     ${txtsfoblu} ${normale} poche lettere per ottenere le opzioni menu corrispondenti.                 ${txtsfoblu} ${normale}"
echo "     ${txtsfoblu} ${normale} Inoltre HUD ha un comportamento intelligente che impara dalle nostre       ${txtsfoblu} ${normale}"
echo "     ${txtsfoblu} ${normale} ricerche e successivamente con ancora meno lettere di ricerca ci presenta  ${txtsfoblu} ${normale}"
echo "     ${txtsfoblu} ${normale} le opzioni menu che abbiamo usato più spesso.                              ${txtsfoblu} ${normale}"
echo "     ${txtsfoblu} ${normale}                                                                            ${txtsfoblu} ${normale}"
echo "     ${txtsfoblu} ${normale}                                                                            ${txtsfoblu} ${normale}"
echo -n "     ${txtsfoblu}                            (Enter/A)vanti   (I)ndietro   (M)enu principale  "
read Ris
echo "${normale}"
case "$Ris" in
	"") menu2_4;;
	"A" | "a") menu2_4;;
	"I" | "i") menu2_2;;	
	"M" | "m") interfaccia_terminale;;
	*) echo "${txtsforosso}Errore - opzione menu non prevista!${normale}";read;menu2_3;;
esac

} # menu2_3

menu2_4()
{ 
clear
echo;echo;echo
echo "     ${txtsfoblu}${grassetto}     WIZARD ESPLICATIVO SU UNITY: IL PANNELLO SUPERIORE                       ${normale}"
echo "     ${txtsfoblu} ${normale}                                                                            ${txtsfoblu} ${normale}"
echo "     ${txtsfoblu} ${normale} Il pannello superiore è l'elemento grafico che ci tiene aggiornati         ${txtsfoblu} ${normale}"
echo "     ${txtsfoblu} ${normale} sullo stato del sistema e visualizza avvisi di ogni tipo (per es.          ${txtsfoblu} ${normale}"
echo "     ${txtsfoblu} ${normale} un mail in arrivo), mediante gli indicatori sulla parte destra.            ${txtsfoblu} ${normale}"
echo "     ${txtsfoblu} ${normale} La parte sinistra invece è riservata al menu globale delle applicazioni.   ${txtsfoblu} ${normale}"
echo "     ${txtsfoblu} ${normale}                                                                            ${txtsfoblu} ${normale}"
echo "     ${txtsfoblu} ${normale}                                                                            ${txtsfoblu} ${normale}"
echo "     ${txtsfoblu} ${normale}                                                                            ${txtsfoblu} ${normale}"
echo "     ${txtsfoblu} ${normale}                                                                            ${txtsfoblu} ${normale}"
echo -n "     ${txtsfoblu}                                             (I)ndietro   (M)enu principale  "
read Ris
echo "${normale}"
case "$Ris" in
	"I" | "i") menu2_3;;	
	"M" | "m") interfaccia_terminale;;
	*) echo "${txtsforosso}Errore - opzione menu non prevista!${normale}";read;menu2_4;;
esac

} # menu2_4


# ------------------------------------------------------------------------------
# Opzione 3 del menu dell'interfaccia terminale
menu3()
{ 
clear
echo "${inverso}3) elenco dei file nella cartella corrente con tutti i dettagli"
echo "---------------------------------------------------------------${normale}"
echo
ls -al
read
clear
echo "${inverso}Mesedimo elenco dei file, ma ordinati in ordine descrescente e con i nomi in maiuscolo"
echo "--------------------------------------------------------------------------------------${normale}"
echo
cat <(ls) | sort -r | tr '[a-z]' ['A-Z']
echo
echo "${inverso}ENTER per tornare al menu principale${normale}"
read
interfaccia_terminale
} # menu3


# ------------------------------------------------------------------------------
# Opzione 4 del menu dell'interfaccia terminale
menu4()
{ 
clear
echo "${inverso}4) richiamo della calcolatrice di Gnome, un programma con interfaccia grafica"
echo "-----------------------------------------------------------------------------${normale}"
echo
gnome-calculator
echo
echo "${inverso}ENTER per tornare al menu principale${normale}"
read
interfaccia_terminale
} # menu4


# ------------------------------------------------------------------------------
# Opzione 5 del menu dell'interfaccia terminale
menu5()
{ 
clear
echo "${inverso}5) scrivi del testo nel file 'testo.txt'"
echo "(CTRL+D per terminare di scrivere)      "
echo "----------------------------------------${normale}"
echo
cat > "testo.txt"
echo;echo;echo
echo "${inverso}Bene, ora puoi anche aggiungere qualcosa allo stesso file se lo desideri"
echo "(CTRL+D per terminare di scrivere)                                      "
echo "------------------------------------------------------------------------${normale}"
echo
cat >> "testo.txt"
echo;echo
echo "${inverso}ENTER per tornare al menu principale${normale}"
read
interfaccia_terminale
} # menu5


# ------------------------------------------------------------------------------
# Opzione 6 del menu dell'interfaccia terminale
menu6()
{ 
clear
echo "${inverso}6) lettura del file 'testo.txt' che hai scritto con la funzione precedente del menu principale"
echo "----------------------------------------------------------------------------------------------${normale}"
echo;echo;echo
echo "*************************** INIZIO TESTO ***************************"
cat "testo.txt"
echo "**************************** FINE TESTO ****************************"
echo;echo
echo "${inverso}ENTER per tornare al menu principale${normale}"
read
interfaccia_terminale
} # menu6


# ------------------------------------------------------------------------------
# Opzione 7 del menu dell'interfaccia terminale
menu7()
{ 
clear
echo "${inverso}7) informazioni sul presente sistema Ubuntu"
echo "-------------------------------------------${normale}"
echo;echo;echo
echo "${txtsfoverde}${grassetto}Dettagli sulla CPU (il processore):${normale}"
echo
lscpu
echo;echo
echo "${inverso}ENTER per continuare${normale}"
read
clear
echo "${txtsfoverde}${grassetto}Dettagli sulle componenti hardware del PC:"
echo "${normale}${txtsfoverde}(paginare con le frecce o i tasti pagina su e pagina giù.
 Uscire con il tasto Q)${normale}"
read
lspci -vv | less
clear
echo "${txtsfoverde}${grassetto}Elenco connessioni USB e periferiche collegate:${normale}"
echo
lsusb
echo;echo
echo "${inverso}ENTER per continuare${normale}"
read
clear
echo "${txtsfoverde}${grassetto}La user connessa e il tipo di sistema Linux:${normale}"
echo
echo "${sottolineato}${txtverde}User connessa${normale}: "$(whoami)
echo "${sottolineato}${txtverde}Tipo di sistema Linux${normale}: "$(uname -a)
echo;echo
echo "${inverso}ENTER per tornare al menu principale${normale}"
read
interfaccia_terminale
} # menu7


# ------------------------------------------------------------------------------
# Opzione 8 del menu dell'interfaccia terminale
menu8()
{ 
clear
echo "${inverso}8) quanti sono e quanto distano i pianeti dal nostro Sole?"
echo "----------------------------------------------------------${normale}"
echo;echo
echo "Le distanze dal Sole sono espresse in ${grassetto}milioni di chilometri${normale} (mio-km)"
echo "La tabella qui sotto è ordinata dal pianeta meno distante verso quello più distante"
echo "I pianeti del sistema solare sono ${txtsfogiallo}${#Pianeti[*]}${normale}"
echo
echo "   _______________________"
echo "   |Pianeta   | Distanza |"
echo "   |----------|----------|"
i=1
Spazi="     " # servono per allineare la struttura della tabellina
for Pianeta in ${Pianeti[*]}
do
	Pianeta=$Pianeta$Spazi
	DistanzaP=${Distanza[$i]}$Spazi
	echo "   | ${Pianeta:0:8} | ${DistanzaP:0:8} |"
	(( i++ ))
done
echo "   |__________|__________|"
echo;echo
echo "${inverso}ENTER per tornare al menu principale${normale}"
read
interfaccia_terminale
} # menu8




# ------------------------------------------------------------------------------
# Tipo di interfaccia grafica con i dialoghi di zenity
interfaccia_grafica()
{ 
# Menu principale dello script
SceltaMenu=$(zenity --list --title="M E N U  P R I N C I P A L E" --text="Scegli la funzionalità che vuoi eseguire (<i>Annulla per terminare</i>):" --width=560 --height=300 --radiolist --hide-column=2 --column "Scelta" --column "Opzione" --column "Descrizione" FALSE 1 "dammi una data in cifre (gg.mm.aaaa) per ottenerla in formato esteso" FALSE 2 "wizard esplicativo sul funzionamento dell'interfaccia Unity di Ubuntu" FALSE 3 "elenco di file di una cartella" FALSE 4 "richiamo della calcolatrice di Gnome" FALSE 5 "scrittura di un file di testo" FALSE 6 "lettura di un file di testo" FALSE 7 "informazioni sul presente sistema Ubuntu" FALSE 8 "quanti sono e quanto distano i pianeti dal nostro Sole?")
# verifica quale pulsante del dialogo è stato premuto
if [ "$?" -eq 0 ] # premuto OK
then
	case "$SceltaMenu" in
		1) Gmenu1;;
		2) Gmenu2;;
		3) Gmenu3;;
		4) Gmenu4;;
		5) Gmenu5;;
		6) Gmenu6;;
		7) Gmenu7;;
		8) Gmenu8;;
		*) zenity --error --no-wrap --text="Devi fare clic su una delle funzionalità per selezionarla e poterla utilizzare.\r\n\r\n Se rinunci e vuoi terminare fai clic su OK qui e poi su Annulla nel menu principale." --title="ERRORE" --window-icon='error' --width=200 --height=150;interfaccia_grafica;;
	esac
else # premuto Annulla - termino script
	notify-send -a "Corso script bash" -i face-smile-symbolic "Grazie per aver usato questo script bash :-)";exit
fi
} # interfaccia_grafica


# ------------------------------------------------------------------------------
# Opzione 1 del menu dell'interfaccia grafica
Gmenu1()
{ 
Data=$(zenity --entry --text="Inserisci una data in cifre (gg.mm.aaaa) e fai clic su OK\r\n(la data per difetto è quella corrente)" --title="Ottenere una data in formato esteso" --entry-text=`date +%d.%m.%Y`)

if [ "$?" -eq 0 ] # premuto OK
then 
	giorno=${Data:0:2}
	mese=${Data:3:2};mese=${mese#*0} #elimina lo zero superfluo davanti al numero del mese per usarlo come indice della tupla
	anno=${Data:6:4}
	giorno_settimana=`date --date=$mese/$giorno/$anno +%u`
	settimana_anno=`date --date=$mese/$giorno/$anno +%V`

	zenity --info --no-wrap --text="La data in formato esteso è un <b>${Settimana[$giorno_settimana]} di ${Mesi[$mese]} dell'anno $anno, giorno nr. $giorno, settimana nr. $settimana_anno</b>" --title="Ecco la data in formato esteso" --window-icon='info' --width=450 --height=100
fi

interfaccia_grafica
} # Gmenu1

# ------------------------------------------------------------------------------
# Opzione 2 del menu dell'interfaccia grafica
Gmenu2()
{ 
	zenity --text-info --no-wrap --width=540 --height=300 --title="IL FUNZIONAMENTO BASE DELL'INTERFACCIA DI UBUNTU" --filename="wizard1.txt" --ok-label="Avanti" --cancel-label="Menu"

	if [ "$?" -eq 0 ] # premuto OK
	then
		Gmenu2_1
	fi

	interfaccia_grafica
} # Gmenu2

Gmenu2_1()
{
	zenity --text-info --no-wrap --width=540 --height=300 --title="WIZARD ESPLICATIVO SU UNITY: IL LAUNCHER" --filename="wizard2.txt" --ok-label="Avanti" --cancel-label="Indietro"
	
	if [ "$?" -eq 0 ] # premuto OK
	then
		Gmenu2_2
	else
		Gmenu2
	fi
} #Gmenu2_1

Gmenu2_2()
{
	zenity --text-info --no-wrap --width=540 --height=300 --title="WIZARD ESPLICATIVO SU UNITY: LA DASH" --filename="wizard3.txt" --ok-label="Avanti" --cancel-label="Indietro"
	
	if [ "$?" -eq 0 ] # premuto OK
	then
		Gmenu2_3
	else
		Gmenu2_1
	fi
} #Gmenu2_2

Gmenu2_3()
{
	zenity --text-info --no-wrap --width=540 --height=300 --title="WIZARD ESPLICATIVO SU UNITY: HUD (Head-up display)" --filename="wizard4.txt" --ok-label="Avanti" --cancel-label="Indietro"
	
	if [ "$?" -eq 0 ] # premuto OK
	then
		Gmenu2_4
	else
		Gmenu2_2
	fi
} #Gmenu2_3

Gmenu2_4()
{
	zenity --text-info --no-wrap --width=540 --height=300 --title="WIZARD ESPLICATIVO SU UNITY: IL PANNELLO SUPERIORE" --filename="wizard5.txt" --ok-label="Menu" --cancel-label="Indietro"
	
	if [ "$?" -eq 0 ] # premuto OK
	then
		interfaccia_grafica
	else
		Gmenu2_3
	fi
} #Gmenu2_4



# ------------------------------------------------------------------------------
# Opzione 3 del menu dell'interfaccia grafica
Gmenu3()
{ 
	cat <(ls -al) > ElencoFile.txt
	zenity --text-info --no-wrap --width=700 --height=350 --title="Elenco di file di una cartella con tutti i dettagli" --filename=ElencoFile.txt
	if [ "$?" -eq 1 ] # premuto Annulla
	then
		interfaccia_grafica
	fi	
	
	cat <(ls) | sort -r | tr '[a-z]' ['A-Z'] > ElencoFile.txt
	zenity --text-info --no-wrap --width=700 --height=350 --title="Elenco dei file ordinati in ordine descrescente e con i nomi in maiuscolo" --filename=ElencoFile.txt

	interfaccia_grafica
} # Gmenu3

# ------------------------------------------------------------------------------
# Opzione 4 del menu dell'interfaccia grafica
Gmenu4()
{ 
gnome-calculator

interfaccia_grafica
} # Gmenu4

# ------------------------------------------------------------------------------
# Opzione 5 del menu dell'interfaccia grafica
Gmenu5()
{ 
	zenity --question --title="DOMANDA..." --text="Desideri pulire il file e scrivere da zero, oppure continuare ad aggiungere contenuto?" --ok-label="Aggiungi testo" --cancel-label="Pulisci il file"
	if [ "$?" -eq 0 ] # premuto OK
	then
		cat <(zenity --text-info --width=700 --height=350 --title="Scrivi liberamente il testo che desideri" --filename=testo.txt --editable) >> testo.txt
	else
		cat <(zenity --text-info --width=700 --height=350 --title="Scrivi liberamente il testo che desideri" --filename=testo.txt --editable) > testo.txt
	fi	 

	interfaccia_grafica
} # Gmenu5

# ------------------------------------------------------------------------------
# Opzione 6 del menu dell'interfaccia grafica
Gmenu6()
{ 
	FileScelto=$(zenity --file-selection --title="DIALOGO PER LA SELEZIONE DI UN FILE" --filename="/home/nicola/Documenti/Tecnica/Tutorial/Miei/Corso Bash/out.txt" --file-filter="Testo | *.txt")
	if [ "$?" -eq 1 ] # premuto Annulla
	then
		interfaccia_grafica
	fi
	
	zenity --text-info --width=540 --height=300 --title="Contenuto del file scelto" --filename="$FileScelto"
	if [ "$?" -eq 0 ] # premuto OK
	then
		Gmenu6
	else
		interfaccia_grafica
	fi
} # Gmenu6

# ------------------------------------------------------------------------------
# Opzione 7 del menu dell'interfaccia grafica
Gmenu7()
{ 
	zenity --info --no-wrap --text="<tt>$(lscpu)</tt>" --title="Dettagli sulla CPU (il processore)" --window-icon='info'
	
	lspci -vv > ComponentiHW.txt
	zenity --text-info --no-wrap --width=700 --height=350 --title="Dettagli sulle componenti hardware del PC" --filename=ComponentiHW.txt
		
	zenity --info --no-wrap --text="<tt>$(lsusb)</tt>" --title="Elenco connessioni USB e periferiche collegate" --window-icon='info'
	zenity --info --no-wrap --text="<tt>User connessa: <b>$(whoami)</b>\r\nTipo di sistema Linux: <b>$(uname -a)</b></tt>" --title="User connessa e il tipo di sistema Linux" --window-icon='info'

	interfaccia_grafica
} # Gmenu7

# ------------------------------------------------------------------------------
# Opzione 8 del menu dell'interfaccia grafica
Gmenu8()
{ 
	echo > Pianeti.txt
	echo >> Pianeti.txt
	echo "Le distanze dal Sole sono espresse in <b>milioni di chilometri</b> (mio-km)" >> Pianeti.txt
	echo "La tabella qui sotto è ordinata dal pianeta meno distante verso quello più distante" >> Pianeti.txt
	echo "I pianeti del sistema solare sono <b>${#Pianeti[*]}</b>" >> Pianeti.txt
	echo >> Pianeti.txt
	echo "   _______________________" >> Pianeti.txt
	echo "   |Pianeta   | Distanza |" >> Pianeti.txt
	echo "   |----------|----------|" >> Pianeti.txt
	i=1
	Spazi="     " # servono per allineare la struttura della tabellina
	for Pianeta in ${Pianeti[*]}
	do
		Pianeta=$Pianeta$Spazi
		DistanzaP=${Distanza[$i]}$Spazi
		echo "   | ${Pianeta:0:8} | ${DistanzaP:0:8} |" >> Pianeti.txt
		(( i++ ))
	done
	echo "   |__________|__________|" >> Pianeti.txt


	# prima modalità sfruttando la tabellina come da interfaccia a caratteri
	zenity --info --no-wrap --text="<tt>$(cat Pianeti.txt)</tt>" --title="Quanti sono e quanto distano i pianeti dal nostro Sole?" --window-icon='info'
	
	# seconda modalità con dialogo tipo lista
	i=1
	ColPianeti=""
	for Pianeta in ${Pianeti[*]}
	do
		ColPianeti="$ColPianeti$Pianeta ${Distanza[$i]} "
		(( i++ ))
	done
	zenity --list --title="Elenco pianeti con la rispettiva distanza dal Sole" --text="Le distanze dal Sole sono espresse in <b>milioni di chilometri</b> (mio-km)\r\n\r\nLa tabella qui sotto è ordinata dal pianeta meno distante verso quello\r\npiù distante (<i>per altri ordinamenti fare clic sui nomi delle colonne</i>)\r\n\r\nI pianeti del sistema solare sono <b>${#Pianeti[*]}</b>" --width=300 --height=385 --column "Pianeta" --column="Distanza" $ColPianeti
	
	interfaccia_grafica
} # Gmenu8


################################################################################

################################################################################
# Corpo principale dello script
# -----------------------------
# siccome questo script usa molto la ricorsività, cioè non segue un'elaborazione
# lineare dall'inizio alla fine, è strutturato tutto con delle funzioni
################################################################################
# si posiziona nella cartella dove è previsto che lo script lavori
# il simbolo "~" sta per la home
# la barra rovesciata "\" fa considerare lo spazio come parte del percorso
cd ~/Documenti/Tecnica/Tutorial/Miei/Corso\ Bash

# avvia l'interfaccia corrispondente a quanto impostato nel parametro di partenza dello script,
# oppure, se non è stato impostato, richiede di impostare con quale interfaccia lavorare
# (non prosegue finché non è stato specificato)
tipo_interfaccia

