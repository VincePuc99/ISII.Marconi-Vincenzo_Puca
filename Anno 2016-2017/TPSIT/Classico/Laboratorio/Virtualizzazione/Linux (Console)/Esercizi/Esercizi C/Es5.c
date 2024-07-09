#include <stdio.h>
#include <stdlib.h>
#include <sys/types.h>
#include <signal.h>

int main(int argc,char * argv[])
{
	int v1,v2,v3,val1,val2;
	v1=atoi(argv[1]);
	v2=atoi(argv[2]);
	v3=atoi(argv[3]);
	int pid1=fork();
	int pid2=fork();
	if(pid1>0)
	{
		kill(pid1,SIGKILL);

		wait(&val1);
		kill(pid2,SIGKILL);

		wait(&val2);
		printf("val1");
		exit(val1-val2);
	}
	else //figlio pari
	{
		int nump;
		pause();
		//calcolo pari
		exit(4);
	}
	if(pid2=0)
	{
		int numd;
		pause();
		//calcola dispari
		exit(2);
	}


}


