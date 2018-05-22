# README

* devmem2版本：[devmem2.sh](devmem2.sh)
* C语言系统调用版本：[SuperIOGPIO.c](SuperIOGPIO.c)


## 参考文档

* [How to access the Super IO registers](http://fengweizhang.blogspot.jp/2013/04/how-to-access-super-io-registers.html)
* [Coreboot - SuperIO](http://coreboot.blogspot.jp/2009/01/coreboot-superio.html)
* [Shell command to read device registers?](https://unix.stackexchange.com/questions/4948/shell-command-to-read-device-registers)
* https://github.com/hackndev/tools/blob/master/devmem2.c

## Install dependents

* `sudo apt-get install devmem2`

## 运行devmem2、系统调用

* [devmem2.sh](devmem2.sh]
  ```
  /dev/mem opened.
  Memory mapped at address 0x7feebdcf7000.
  Value at address 0x2E (0x7feebdcf702e): 0x0
  Written 0x87; readback 0x87
  /dev/mem opened.
  Memory mapped at address 0x7f254452a000.
  Value at address 0x2E (0x7f254452a02e): 0x87
  Written 0x87; readback 0x87
  /dev/mem opened.
  Memory mapped at address 0x7f2bb25c1000.
  Value at address 0x2E (0x7f2bb25c102e): 0x87
  Written 0x7; readback 0x7
  /dev/mem opened.
  Memory mapped at address 0x7f5adaf50000.
  Value at address 0x2F (0x7f5adaf5002f): 0xF0
  Written 0x7; readback 0x7
  /dev/mem opened.
  Memory mapped at address 0x7fc61e8e6000.
  Value at address 0x2E (0x7fc61e8e602e): 0x7
  Written 0x1C; readback 0x1C
  /dev/mem opened.
  Memory mapped at address 0x7f5c37f4a000.
  Value at address 0x2F (0x7f5c37f4a02f): 0x7
  Written 0x1C; readback 0x1C
  /dev/mem opened.
  Memory mapped at address 0x7f2c25be1000.
  Value at address 0x2E (0x7f2c25be102e): 0x1C
  Written 0x30; readback 0x30
  /dev/mem opened.
  Memory mapped at address 0x7ff3f8357000.
  Value at address 0x2F (0x7ff3f835702f): 0x1C
  Written 0xDF; readback 0xDF
  /dev/mem opened.
  Memory mapped at address 0x7fd99e4d6000.
  Value at address 0x2E (0x7fd99e4d602e): 0x30
  Written 0xE8; readback 0xE8
  /dev/mem opened.
  Memory mapped at address 0x7f8f471c3000.
  Value at address 0x2F (0x7f8f471c302f): 0xDF
  Written 0x0; readback 0x0
  /dev/mem opened.
  Memory mapped at address 0x7fa1c49c5000.
  Value at address 0x2E (0x7fa1c49c502e): 0xE8
  Written 0xE9; readback 0xE9
  /dev/mem opened.
  Memory mapped at address 0x7ff9dce74000.
  Value at address 0x2F (0x7ff9dce7402f): 0x0
  Written 0xF0; readback 0xF0
  /dev/mem opened.
  Memory mapped at address 0x7fd17c7e1000.
  Value at address 0x2E (0x7fd17c7e102e): 0xE9
  Written 0xE9; readback 0xE9
  /dev/mem opened.
  Memory mapped at address 0x7f3f882e8000.
  Value at address 0x2F (0x7f3f882e802f): 0xF0
  ```
* [autorun.sh](autorun.sh)
  ```
  type = o, addr = 2e, data = 87, backdata = ff
  type = o, addr = 2e, data = 87, backdata = aa
  type = o, addr = 2e, data = 07, backdata = 07
  type = o, addr = 2f, data = 07, backdata = 07
  type = o, addr = 2e, data = 1c, backdata = 1c
  type = o, addr = 2f, data = 1c, backdata = 1c
  type = o, addr = 2e, data = 30, backdata = 30
  type = o, addr = 2f, data = df, backdata = df
  type = o, addr = 2e, data = e8, backdata = e8
  type = o, addr = 2f, data = 00, backdata = 00
  type = o, addr = 2e, data = e9, backdata = e9
  type = o, addr = 2f, data = f0, backdata = f0
  type = i, addr = 2f, data = f0
  type = o, addr = 2e, data = aa, backdata = ff
  ```

