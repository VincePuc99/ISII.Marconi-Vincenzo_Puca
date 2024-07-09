#!/bin/bash

clear

# il comando ">" scrive l'output di un comando in un nuovo file di testo
ls > out.txt
echo "ho scritto l'output del comando nel file out.txt"
read

# il comando ">>" permette di continuare a scrivere l'output di
# un comando accumulandolo in un file di testo già esistente
ls >> out.txt
echo "ho aggiunto l'output del comando nel file out.txt"
read

# il comando pipe "|" oppure l'equivalente comando "<(comando)"
# permettono di prendere l'output di un comando e di farlo proseguire
# come input di un comando successivo
ls -l | cat
read
echo "**********************************************"
cat <(ls -l)
read
echo "**********************************************"
cat <(ls -l) <(ls -al)
read
echo "**********************************************"
cat out.txt | sort -r | uniq
read

# il carattere speciale apice rovesciato (backquote) "`" permette di
# usare l'output di un comando come argomento (parametro) di un altro
echo;echo "Il nome dell'utente connesso è `whoami`"
read
echo "**********************************************"
echo -e "Ecco il contenuto del file out.txt:\r\n`cat out.txt`"
read

# la forma "$(comando)" è equivalente alla precedente, ma permette
# di facilmente combinare più output di comandi innestati
echo "**********************************************"
echo "Il nome dell'utente connesso è $(whoami)"
read
echo -e "Contenuto di un file script\r\n$(cat $(ls *03.sh))"

