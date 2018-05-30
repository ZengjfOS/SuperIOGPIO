#include <sys/io.h>
#include <stdio.h>
#include <stdlib.h>

int main(int argc, char** argv) 
{
	char type = 0;
	unsigned short int addr = 0;
	unsigned char data = 0;
	int ret = 0;

	if (argc < 0 || argc >4) {
		printf("SuperIOGPIO i <hex address>");
		printf("SuperIOGPIO o <hex address> <hex value>");
		return -1;
	}

	ret = ioperm(0x2e, 2, 1);
	if (ret != 0) {
		printf("ioperm error.");
		return -1;
	}

	type = *argv[1];
	addr = strtol(argv[2], 0, 0);
	printf("type = %c, addr = %02x", type, addr);

	switch(type) {
	case 'i':
		data = inb(addr);

		printf(", data = %02x\r\n", data);
		break;
	case 'o':
		data = strtol(argv[3], 0, 0);
		printf(", data = %02x", data);

		outb(data, addr);

		data = inb(addr);
		printf(", backdata = %02x\r\n", data);
		break;
	default:
		break;
	}
	
	exit(0);
}
