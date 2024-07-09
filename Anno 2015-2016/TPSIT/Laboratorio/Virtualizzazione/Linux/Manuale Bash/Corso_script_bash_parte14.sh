#!/bin/bash

clear
# formattazione del testo nel terminale
# le definizioni seguenti controllano varie caratteristiche del testo
# che appare a terminale
sottolineato=$(tput smul)     # attiva il sottolineato
nonsottolineato=$(tput rmul)  # disattiva il sottolineato
grassetto=$(tput bold)        # attiva il grassetto
inverso=$(tput rev)           # attiva la modalità inversa 
                              # (scambia sfondo e carattere)
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

# si usano le parentesi graffe quando le variabili sono attaccate al testo
# che segue e si vogliono evitare spazi inutili
echo "${grassetto}Il testo in grassetto$normale si distingue dal resto!"
echo "${sottolineato}Anche il testo sottolineato$nonsottolineato si distingue bene, $grassetto${sottolineato}nevvero${normale}?."
echo "Questa è scrittura normale e ${inverso}questo il modo inverso${normale}. Tutto OK :-)" 
echo "Benvenuto al testo rosso$txtrosso Impariamo le basi della programmazione${normale}!"
echo "Benvenuto al testo verde$txtverde Impariamo le basi della programmazione${normale}!"
echo "Benvenuto al testo giallo$txtgiallo Impariamo le basi della programmazione${normale}!"
echo "Benvenuto al testo blu $txtblu Impariamo le basi della programmazione${normale}!"
echo "Benvenuto al testo porpora$txtporpora Impariamo le basi della programmazione${normale}!"
echo "Benvenuto al testo ciano$txtciano Impariamo le basi della programmazione${normale}!"
echo "Benvenuto al testo bianco$txtbianco Impariamo le basi della programmazione${normale}!"
echo "Benvenuto allo sfondo rosso$txtsforosso Impariamo le basi della programmazione${normale}!"
echo "Benvenuto allo sfondo verde$txtsfoverde Impariamo le basi della programmazione${normale}!"
echo "Benvenuto allo sfondo giallo$txtsfogiallo Impariamo le basi della programmazione${normale}!"
echo "Benvenuto allo sfondo blu$txtsfoblu Impariamo le basi della programmazione${normale}!"
echo "Benvenuto allo sfondo porpora$txtsfoporpora Impariamo le basi della programmazione${normale}!"
echo "Benvenuto allo sfondo ciano$txtsfociano Impariamo le basi della programmazione${normale}!"
echo "Benvenuto allo sfondo bianco$txtsfobianco Impariamo le basi della programmazione${normale}!"
echo "$inverso$txtblu                 **** C O R N I C E  IN  B L U  ****                $normale"
echo "$inverso$txtblu     $normale                                                          $inverso$txtblu     $normale"
echo "$inverso$txtblu     $normale 1. opzione menu uno                                      $inverso$txtblu     $normale"
echo "$inverso$txtblu     $normale 2. opzione menu due                                      $inverso$txtblu     $normale"
echo "$inverso$txtblu     $normale 3. opzione menu tre                                      $inverso$txtblu     $normale"
echo "$inverso$txtblu     $normale                                                          $inverso$txtblu     $normale"
echo "$inverso$txtblu                 **** C O R N I C E  IN  B L U  ****                $normale"
echo "Benvenuto al rosso inverso$txtrosso$inverso Impariamo le basi della programmazione${normale}!"
echo "Benvenuto al verde inverso$txtverde$inverso Impariamo le basi della programmazione${normale}!"
echo "Benvenuto al giallo inverso$txtgiallo$inverso Impariamo le basi della programmazione${normale}!"
echo "Benvenuto al blu inverso$txtblu$inverso Impariamo le basi della programmazione${normale}!"
echo "Benvenuto al porpora inverso$txtporpora$inverso Impariamo le basi della programmazione${normale}!"
echo "Benvenuto al ciano inverso$txtciano$inverso Impariamo le basi della programmazione${normale}!"
echo "Benvenuto al bianco inverso$txtbianco$inverso Impariamo le basi della programmazione${normale}!"

