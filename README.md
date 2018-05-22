# README

## Code Analysis

## Output
```C#
void GPIO_TESTDlg::Gpio2_Out_detect()
{
	DWORD GPIO2;

	//进入SuperIO芯片控制页表
	SetPortVal(0x2e, 0x87, 1);
	SetPortVal(0x2e, 0x87, 1);

	//进入GPIO控制页表
	SetPortVal(0x2e, 0x07, 1);
	SetPortVal(0x2f, 0x07, 1);  // select logical device number

	//引脚复用，GPIO Port2选择为GPIO口模式
	SetPortVal(0x2e, 0x1C, 1);
	SetPortVal(0x2f, 0x1C, 1);  
	SetPortVal(0x2e, 0x30, 1);  //set configuration the device number register  
	SetPortVal(0x2f, 0xDF, 1);  // set gpio port 2 is active

	//设置GPIO为Input、Output模式，0表示output， 1表示input
	SetPortVal(0x2e, 0xe8, 1);
	SetPortVal(0x2f, 0x00, 1);   //set port2 is 0 = output

	unsigned char B0 = ((CButton*) GetDlgItem(IDC_CHECK1))->GetCheck();
	unsigned char B1 = ((CButton*) GetDlgItem(IDC_CHECK2))->GetCheck();
	unsigned char B2 = ((CButton*) GetDlgItem(IDC_CHECK3))->GetCheck();
	unsigned char B3 = ((CButton*) GetDlgItem(IDC_CHECK4))->GetCheck();
	unsigned char B4 = ((CButton*) GetDlgItem(IDC_CHECK5))->GetCheck();
	unsigned char B5 = ((CButton*) GetDlgItem(IDC_CHECK6))->GetCheck();
	unsigned char B6 = ((CButton*) GetDlgItem(IDC_CHECK7))->GetCheck();
	unsigned char B7 = ((CButton*) GetDlgItem(IDC_CHECK8))->GetCheck();

	GPIO2 = (( (B7 << 7) | (B6 << 6) | (B5 << 5) | (B4 << 4) | (B3 << 3) | (B2 << 2) | (B1 << 1) | (B0) ) & 0xFF);
    //input模式下，获取值；output模式下，设置1为拉高，设置0为拉低
	SetPortVal(0x2e, 0xe9, 1);   
	SetPortVal(0x2f, GPIO2, 1);  //output 

    //退出SuperIO模式
	SetPortVal(0x2e, 0xaa, 1);     
}
```

## Input
```C#
void CL706_GPIO_TESTDlg::Gpio2_In_detect()
{
	DWORD dwPortVal=0;

	SetPortVal(0x2e, 0x87, 1);
	SetPortVal(0x2e, 0x87, 1);

	SetPortVal(0x2e, 0x07, 1);
	SetPortVal(0x2f, 0x07, 1);  // select logical device number

	SetPortVal(0x2e, 0x1C, 1);  
	SetPortVal(0x2f, 0x1C, 1);  
	SetPortVal(0x2e, 0x30, 1);  //set configuration the device number register  
	SetPortVal(0x2f, 0xDF, 1);  // set gpio port 2 is active

	SetPortVal(0x2e, 0xe9, 1);
	SetPortVal(0x2f, 0xFf, 1);   //set port2 is input

	SetPortVal(0x2e,0xe9,1);
	GetPortVal(0x2f, &dwPortVal, 1);
	if(dwPortVal>>3&0x01)
	  m_ButtonLED4.LedOn();
	else
	  m_ButtonLED4.LedOff();
	if(dwPortVal>>2&0x01)
	  m_ButtonLED3.LedOn();
	else
	  m_ButtonLED3.LedOff();
	if(dwPortVal>>1&0x01)
	 m_ButtonLED2.LedOn();
	else
	   m_ButtonLED2.LedOff();
	if(dwPortVal&0x01)
	   m_ButtonLED1.LedOn();
	else
	   m_ButtonLED1.LedOff();

	 SetPortVal(0x2e, 0xaa, 1);    
}
```