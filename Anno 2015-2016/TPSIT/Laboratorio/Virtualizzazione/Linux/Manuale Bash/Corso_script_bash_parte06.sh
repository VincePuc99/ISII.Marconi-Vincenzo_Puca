#!/bin/bash

clear

# il carattere $
echo $USER
echo Pippa =\> $(ls)
read

# le parentesi graffe {}
echo {a..e}
Tabe[3]="Corso Bash"
echo "Tabe(3)="${Tabe[3]}
Pippa=$(echo {15..19})
echo "Pippa="$Pippa
echo n{1,2,3}-xx
# ottenere una stringa tutta maiuscola
x="Ciao Mondo";echo ${x^^}
# ottenere una stringa tutta minuscola
x="Ciao Mondo";echo ${x,,}
# ottenere solo la prima lettera maiuscola
x="ciao mondo";echo ${x^}
x="ciao mondo";echo ${x:0:3}
x="ciao mondo";echo ${x:3:5}
x="oggi è.il 02.03.2013"; echo ${#x}
x="oggi è.il 02.03.2013"; echo ${x#*.}
x="oggi è.il 02.03.2013"; echo ${x##*.}
x="oggi è.il 02.03.2013"; echo ${x%.*}
x="oggi è.il 02.03.2013"; echo ${x%%.*}

read

# la barra rovesciata (backslash) \
echo \$USER
read

# le virgolette semplici ''
echo "Senza virgolette:" file ~/Musica/*.txt Pippa =\> $(whoami)
echo "Con virgolette:" 'file ~/Musica/*.txt Pippa =\> $(whoami)'
read

# le virgolette doppie
echo "Senza virgolette:" file ~/Musica/*.txt Pippa =\> $(whoami)
echo "Con virgolette:" "file ~/Musica/*.txt Pippa =\> $(whoami)"
read

# modifica della forma e del contenuto di una stringa
echo "Questo è un messaggio stringa" | tr '[a-z]' ['A-Z']
echo "Questo è un messaggio stringa" | tr '[a-z,è]' ['A-Z',È]
echo "Questo è un messaggio stringa" | tr 'è' "e'"
echo "Questo è un messaggio stringa" | tr 's' '$'
echo "Questo è un messaggio stringa" | tr -d 's'
echo "Questo è un messaggio stringa" | tr -s 'g' '*'

