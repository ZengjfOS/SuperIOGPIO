# README

**本分支是Windows操作SuperIO方法，Linux版本请参考**: [SuperIOGPIO Linux Branch](https://github.com/ZengjfOS/SuperIOGPIO/tree/Linux)

## 示例使用说明

![./images/SuperIOGPIO.png](./images/SuperIOGPIO.png)

* 开发环境：VS2015
* `Port Info`: 操作整个GPIO Port的部分，目前主板有8个GPIO，这部分API可以直接操作8个GPIO口；
  * `Port Address (Hex)`: 主要是给原生InpOut32接口提供的地址值；
  * `Port Value (Hex)`: 设置的，或者执行程序返回的显示值；
  * `Read BYTE`、`Write BYTE`: InpOut32提供的原生单字节访问接口；
  * `Read Mode`、`Write Mode`: 是获取、设置8个GPIO的输入输出模式；
  * `Read Value`、`Write Value`: 是获取、设置8个GPIO的值；
* `Pin Info`: 针对单独的某一个GPIO进行操作；
  * `Pin Index (Hex)`: GPIO口Pin脚索引，`0~7`；
  * `Pin Mode (Hex)`: GPIO口Pin脚输入输出模式设置，`0（输出模式）、1（输入模式）`；
  * `Pin Value (Hex)`: GPIO口Pin脚对应的值；

## 参考库

[InpOut32 and InpOutx64](http://www.highrez.co.uk/downloads/inpout32/?yyue=a21bo.50862.201879)

## 下载已编译程序

[SuperIOGPIO.rar](SuperIOGPIO.rar)

## 二次封装使用库

* 参考源代码： [AplexOS7116GPIO.cs](AplexOS7116GPIO.cs)；
* 将[inpout32_lib](inpout32_lib)目录下的库文件拷贝到编译后的的`bin/Debug`、`bin/Release`目录，程序运行依赖这两个库；
* API说明：
  * `public static uint initInpOut32Lib()`  
    初始化检查InpOut32库；
  * `public static void initGPIO()`  
    初始化GPIO控制器；
  * `public static void freeGPIO()`  
    释放GPIO控制器；
  * `public static void setPinsMode(short iData)`  
    一次性设置所有GPIO口是为Input、Output模式，每一位表示一个对应的GPIO口，`1`表示Input，`0`表示Output，目前只有8个GPIO，对应short类型的低八位，`7~0` bit对应`7~0` GPIO；
  * `public static short getPinsMode()`  
    一次性获取所有GPIO口是为Input、Output模式，每一位表示一个对应的GPIO口，`1`表示Input，`0`表示Output，目前只有8个GPIO，对应short类型的低八位，`7~0` bit对应`7~0` GPIO；
  * `public static short getPinMode(short pin)`  
    获取pin对应的GPIO口模式，`1`表示Input，`0`表示Output，目前只有8个GPIO，pin取值范围为`0~7`；
  * `public static void setPinMode(short pin, short mode)`  
    设置pin对应的GPIO口模式，目前只有8个GPIO，pin取值范围为`0~7`。mode取值为`1`表示Input，`0`表示Output；
  * `public static void setPinsVal(short iData)`  
    一次性设置所有GPIO口值，每一位表示一个对应的GPIO口，`1`表示Input，`0`表示Output，目前只有8个GPIO，对应short类型的低八位，`7~0` bit对应`7~0` GPIO；
  * `public static short getPinsVal()`  
    一次性获取所有GPIO口值，每一位表示一个对应的GPIO口，`1`表示Input，`0`表示Output，目前只有8个GPIO，对应short类型的低八位，`7~0` bit对应`7~0` GPIO；
  * `public static short getPinVal(short pin)`  
    获取pin对应的GPIO口值，目前只有8个GPIO，pin取值范围为`0~7`，返回值0表示低电平，1表示高电平；
  * `public static void setPinVal(short pin, short val)`  
    设置pin对应的GPIO口值，目前只有8个GPIO，pin取值范围为`0~7`，val的值0表示低电平，1表示高电平；
