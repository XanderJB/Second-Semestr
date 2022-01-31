#include <unistd.h>
#include <malloc.h>
#include <stdio.h>
#include <sys/mman.h>

int data=10;
int main(int argc, char *argv[])
{
	int stack;
	void *heap;
	heap=malloc(1);
	printf("PID=%i\n",getpid());
	printf("Text=%p\n", main);
	printf("Data=%p\n", &data);
	printf("Heap=%p\n", heap);
	printf("libc.so=%p\n", printf);
	printf("Stack=%p\n", &stack);
	
	sleep(100);
	return 0;
}
