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
# Uso dello script: ???? si apre un menu dal quale scegliere ????
#
################################################################################

:<<test_if
# comandi della shell
echo -n "Immetti parametro PIPPA: "
read PIPPA
echo Hai impostato PIPPA=$PIPPA

if [ "$PIPPA" -eq 5 ] || [ "$PIPPA" = "Pippa" ]
then
	echo Hai fornito il valore 5 oppure Pippa
else
	echo Hai fornito un valore diverso da 5 e da Pippa
fi

echo -n "Digita il valore ab= "
read ab
echo Hai impostato ab=$ab

if [ "$ab" -gt 0 ] && [ "$ab" -lt 5 ]
then
	echo valore fra zero e 4
else
	echo valore minore di zero oppure maggiore di 4
fi
test_if

:<<loop_for
echo;echo;echo "Elenco dei pianeti del nostro sistema solare:"
for pianeta in Mercurio Venere "Pianeta Terra" Marte Giove Saturno Uranio Nettuno
do
	echo $pianeta # Ogni pianeta visualizato su una riga separata (gli spazi separano una voce dall'altra)
done
loop_for

