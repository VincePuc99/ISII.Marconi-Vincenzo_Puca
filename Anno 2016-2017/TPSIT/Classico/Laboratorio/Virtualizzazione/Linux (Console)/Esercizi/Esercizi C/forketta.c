#include <stdio.h>

#include <stdlib.h>

#include <unistd.h>

#include <wait.h>

int main()

{
  
int pid_1;
  
int pid_2;
  
pid_1 = fork();

  
if (pid_1 == 0)
  
{ 
    
printf("Sono il figlio lento\n");
    
sleep(10);
    
printf("Fine lento\n");
    
exit(1);
  
}
  
else
  
{
    
pid_2 = fork();
    
    
if(pid_2 == 0)
    
{
      
printf("Sono il figlio veloce\n");
      
sleep(2);
      
printf("Fine veloce\n");
      
exit(2);
    
}   
    
else
    
{    
    
int i;
    
int j;
    
printf("Sono il padre\n");
    
wait(&i);
    
wait(&j);
    
printf("Il figlio lento mi ha detto %d\n",i/256);
    
printf("Il figlio veloce mi ha detto %d\n",j/256);
    
printf("Fine padre\n");
    
exit(0);
    
}
  
}  

}

