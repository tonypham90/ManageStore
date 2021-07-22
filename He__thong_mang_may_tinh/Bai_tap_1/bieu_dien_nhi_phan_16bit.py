from os import system, name
def clear():
  
    # for windows
    if name == 'nt':
        _ = system('cls')
  
    # for mac and linux(here, os.name is 'posix')
    else:
        _ = system('clear')
clear()
# Tinh so bit và tra lai so bit co the chay du lieu
def byteinput():
    bytedata = int(input(f'Nhập số byte của dữ liệu (1byte = 8bit) '));

    # Tạo chuỗi bit ban đầu của dữ liệu

    bit = bytedata * 8;
    print(f'So bit cua chuoi so la {bit}');
    return bit
# Tim gia tri lon nhat co the duoc nhap vao
def maxnumber(bit):
    maxnumber = 0
    for i in range(bit):
        maxnumber += pow(2,i) 
        # print(i)
        # print (maxnumber)
    print(f'Gia tri lon nhat co the nhap la: {maxnumber}')
    return maxnumber
# Kiem tra du lieu dau vao
def run(number,maxnumber):
    if number > maxnumber or number <0:
        print(f'Gia tri ban chon da nam ngoai vung co the chuyen doi vui long chon gia tri trong khoan [0, {maxnumber}]')
        run = False;
    else:
        run = True;
    return run
# In gia tri tu list
def printbinary(number,binarynumber):
    a = ""
    n=0
    while n < len(binarynumber):
        a += str(binarynumber[n]);
        if (n+1) % 4 == 0 and (n+1) <len(binarynumber):
            a += " ";
        n += 1
        # print(a)
    print(f'Chuoi binary cua so {number} la \n binary: [{a}]')
# Ham chuyen doi digit to binary:
def convertobinary(number,bitnumber):
     # So nguyen
    a = number;
    # so du
    r = 0;
    binary = []
    while len(binary) < bitnumber:
        while a > 0:
            if a>=2:
                r = a%2;
            else:
                r = a
            # print (r)
            a = a-r
            a = int(a/2);
            binary.insert(0,r);
            # print (binary)
        if len(binary) < bitnumber:
            binary.insert(0,0)
        # print(f'binary la {binary}')
        # print(f'Len cua binary la{len(binary)}')
    return binary;
def start():
    clear()
    print("Chuong trinh chuyen doi so nguyen khong am thanh nhi phan")
    play = True
    while play is True:
       
        bit = byteinput();
        print (f'in gia tri bit = {bit}')
        maxvalue = maxnumber(bit);
        number = int(input(f'Gia tri can chuyen doi qua binary khong giau: '));
        check = run(number,maxvalue);
        if check:
            binarystr = convertobinary(number,bit);
            printbinary(number,binarystr);
        ask = input(f'Ban co muon kiem tra so khac khong? (y/n)').lower()
        # print (ask)
        if ask == "y":
            print(f'ask is True')
            play = True
        else:
            print (f'Cam on ban da su dung chuong trinh')
            play = False
            break
start()


            


