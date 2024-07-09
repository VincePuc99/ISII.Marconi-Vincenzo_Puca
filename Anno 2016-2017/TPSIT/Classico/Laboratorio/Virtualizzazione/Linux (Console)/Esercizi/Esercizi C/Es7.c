#include<stdio.h>

main(int argc,char *argv[0])
{ 
  int i;
  
  for(i = 1; i < argc; i++)
  {
    
  if(*argv[i] == '1')
    printf("\nI\n");
  
  if(*argv[i] == '2')
    printf("\nII\n");
  
  if(*argv[i] == '3')
    printf("\nIII\n");
  
  if(*argv[i] == '4')
    printf("\nIV\n");
  
  if(*argv[i] == '5')
    printf("\nV\n");
  
  }
   return argc;
  
}