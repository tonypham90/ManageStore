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
    bytedata = int(input(f'Nhập số byte của dữ liệu '));

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
#Tao choi array data
# def binary(bit):
#     binarynumber = [];
#     i = 0
#     #Tao choi array data
#     while i < bit:
#         i += 1
#         binarynumber.append(0)
#     return binarynumber

# # kiem tra ket qua dau vao
# print(len(binarynumber));
# print(binarynumber);

# Ham so in chuoi data
def printbinary(number,binarynumber,run):
    if run:
        a = ""
        for i in binarynumber:
            if len(a) % 4 == 0:
                a += " ";
            a += str(i);
            print(a)
        print(f'Chuoi binary cua so {number} la \n binary: [{a}]')
    else:
        print(f'Gia tri ban chon da nam ngoai vung co the chuyen doi vui long chon gia tri trong khoan [0, {maxnumber}]')

# Ham chuyen doi digit to binary:
def convertobinary(number,bitnumber,run):
     # So nguyen
    a = number;
    # so du
    r = 0;
    binary = []
    if run:
        while len(binary) < bitnumber:
            while a > 0:
                r = a%2;
                a = round(a/2);
                binary.insert(0,r);
                # print (binary)
            binary.insert(0,0)
            # print(binary)
    return binary;
def start():
    play = True
    while play is True:
        clear()
        bit = byteinput();
        print (f'in gia tri bit = {bit}')
        maxvalue = maxnumber(bit);
        number = int(input(f'Gia tri can chuyen doi qua binary khong giau: '));
        check = run(number,maxvalue);
        if check:
            binarystr = convertobinary(number,bit,check);
            printbinary(number,binarystr,check);
        ask = input(f'Ban co muon kiem tra so khac khong? (y/n)').lower()
        print (ask)
        if ask == "y":
            print(f'ask is True')
            play = True

        else:
            print (f'Cam on ban da su dung chuong trinh')
            play = False
            break
start()


            


