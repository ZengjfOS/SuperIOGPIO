#!/bin/sh

setGPIOReg()
{
	./SuperIOGPIO o 0x2e $1
}

setGPIOVal()
{
	./SuperIOGPIO o 0x2f $1
}

getGPIOVal()
{
	./SuperIOGPIO i 0x2f
}

setGPIORegVal()
{
	setGPIOReg $1
	setGPIOVal $2
}

setGPIOMode()
{
	setGPIOReg 0xe8
	setGPIOVal $1 	# set GPIO mode(8 bit present 8 GPIO: 0 -> output; 1 -> input);
}

setOutputVal()
{
	setGPIOReg 0xe9
	setGPIOVal $1 	# set GPIO value(8 bit present 8 GPIO: 0 -> low level; 1 -> high level);
}

getInputVal()
{
	getGPIOVal
}

startSuperIO ()
{
	setGPIOReg 0x87
	setGPIOReg 0x87
}

exitGPIO ()
{
	setGPIOReg 0xaa
}

initGPIO () 
{
	startSuperIO

	setGPIORegVal 0x07 0x07
	setGPIORegVal 0x1C 0x1C
	setGPIORegVal 0x30 0xDF

}


initGPIO
setGPIOMode 0x00 	# set GPIO mode(8 bit present 8 GPIO: 0 -> output; 1 -> input);
setOutputVal 0x00	# set GPIO value(8 bit present 8 GPIO: 0 -> low level; 1 -> high level);

# while [ "$min" -le "$max" ]
while true
do
	setOutputVal 0xff	# set GPIO value(8 bit present 8 GPIO: 0 -> low level; 1 -> high level);
	getInputVal
	sleep 1

	setOutputVal 0x00	# set GPIO value(8 bit present 8 GPIO: 0 -> low level; 1 -> high level);
	getInputVal
	sleep 1

done

exitGPIO
