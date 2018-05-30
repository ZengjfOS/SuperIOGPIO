# README

## 参考文档

* [How to access the Super IO registers](http://fengweizhang.blogspot.jp/2013/04/how-to-access-super-io-registers.html)
* [Coreboot - SuperIO](http://coreboot.blogspot.jp/2009/01/coreboot-superio.html)
* [Shell command to read device registers?](https://unix.stackexchange.com/questions/4948/shell-command-to-read-device-registers)
* https://github.com/hackndev/tools/blob/master/devmem2.c
* [outb() problem - Segmentation fault](http://forums.justlinux.com/showthread.php?127692-outb()-problem-Segmentation-fault)


## Compile

```shell
root@aplex-desktop:~/SuperIOGPIO-Linux# make
gcc SuperIOGPIO.c -o SuperIOGPIO
root@aplex-desktop:~/SuperIOGPIO-Linux# 
```

## Usage

* [autorun.sh](autorun.sh)
  ```
  root@aplex-desktop:~/SuperIOGPIO-Linux# ./autorun.sh 
  type = o, addr = 2e, data = 87, backdata = 87
  type = o, addr = 2e, data = 87, backdata = 87
  type = o, addr = 2e, data = 07, backdata = 07
  type = o, addr = 2f, data = 07, backdata = 07
  type = o, addr = 2e, data = 1c, backdata = 1c
  type = o, addr = 2f, data = 1c, backdata = 1c
  type = o, addr = 2e, data = 30, backdata = 30
  type = o, addr = 2f, data = df, backdata = df
  type = o, addr = 2e, data = e8, backdata = e8
  type = o, addr = 2f, data = 00, backdata = 00
  type = o, addr = 2e, data = e9, backdata = e9
  type = o, addr = 2f, data = 00, backdata = 00
  type = o, addr = 2e, data = e9, backdata = e9
  type = o, addr = 2f, data = 00, backdata = 00
  type = o, addr = 2e, data = e9, backdata = e9
  type = o, addr = 2f, data = ff, backdata = ff
  type = o, addr = 2e, data = e9, backdata = e9
  type = o, addr = 2f, data = 00, backdata = 00
  type = o, addr = 2e, data = e9, backdata = e9
  type = o, addr = 2f, data = ff, backdata = ff
  type = o, addr = 2e, data = e9, backdata = e9
  type = o, addr = 2f, data = 00, backdata = 00
  ^C
  root@aplex-desktop:~/SuperIOGPIO-Linux# 
  ```

