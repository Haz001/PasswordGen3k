import random
os_i = True
try:
    import os
except:
    os_i = False
pwd = str()
run = True
lc_lst = ['a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z']
smbl_lst = ['!','"','£','$','%','^','&','*','(',')','\\','|',',','<','.','>','[',']','{','}','_','-','+','=',':',';','@',"'",'#','~']
while(run):
    os.system("cls")
    print("Welcome to Password Gen 3000\nTo create a password choose an option:\n0 - BasicPassword\n1 - Exit")
    try:
        cmd = int(input(">"))
        if (cmd == 0):
            print("How many letters (10 recomended)")
            try:
                cmd = int(input(">"))
                pwd=str()
                count=1
                while(count <= cmd):
                    r_i = random.randint(0,3)
                    if(r_i == 0):
                        pwd+=random.choice(lc_lst)
                    elif(r_i == 1):
                        pwd+=random.choice(lc_lst).upper()
                    elif(r_i == 2):
                        pwd+=str(random.randint(0,9))
                    else:
                        pwd+=random.choice(smbl_lst)
                    count+=1;
                
                print("Your new password is:\n"+pwd)                
                input("Press enter to go back to main menu")
            except:
                print("error")
        elif (cmd == 1):
            run=False
        else:
            print("error")
    except:
        print("error")
